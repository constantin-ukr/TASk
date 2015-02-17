using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmCRUD : Form
    {
        string _seminarName;
        string _delItemName;
        string _addItemName;
        DataT3Service.Person _person;
        TypeOperation _operation;
        public frmCRUD(TypeOperation operation, string seminarName = null, DataT3Service.Person person = null)
        {
            _person = person;            
            _operation = operation;
            _seminarName = seminarName;
            InitializeComponent();
            btnAddSem.Enabled = btnDelSem.Enabled = false;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (_operation == TypeOperation.Add)
            {
                return;
            }
            var q = from p in Program.client.GetPersons()
                    where p.ID == Convert.ToInt32(dataGridView1["ID", e.RowIndex].Value.ToString())
                    select p;

            nameTextBox.Text = q.First().Name;
            birthdayDateTimePicker.Text =
                String.IsNullOrEmpty(q.First().Birthday.ToString()) ?
                DateTime.Now.Date.ToShortDateString() :
                q.First().Birthday.ToString();

            addressTextBox.Text = q.First().Address;
            zipTextBox.Text = q.First().Zip;
            cityTextBox.Text = q.First().City;
            taxTextBox.Text = q.First().Tax;
            memoTextBox.Text = q.First().Memo;

            _person = q.First();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTextBox.Text.Trim()))
            {
                nameTextBox.BackColor = Color.LightPink;
                MessageBox.Show("Поле 'Name'  не може бути пустим");
                return;
            }


            DataT3Service.Person person = new DataT3Service.Person();
            person.Name = nameTextBox.Text.Trim();
            person.Birthday = birthdayDateTimePicker.Value;
            person.Address = addressTextBox.Text.Trim();
            person.Zip = zipTextBox.Text.Trim();
            person.City = cityTextBox.Text.Trim();
            person.Tax = taxTextBox.Text.Trim();
            person.Memo = memoTextBox.Text.Trim();

            Program.client.AddPersons(new List<DataT3Service.Person>() { person });

            if (!String.IsNullOrEmpty(_seminarName))
            {
                DataT3Service.Seminar s =
                        (from sem in Program.client.GetSeminars()
                         where sem.Name == _seminarName
                         select sem).First();

                Program.client.AddAssociationSem_Per(s, new List<DataT3Service.Person>() { person });

                _person = (from p in Program.client.GetPersons()
                           where p.Name == person.Name
                           where p.Birthday == person.Birthday
                           where p.Address == person.Address
                           select p).First();

                iDTextBox.Text = _person.ID.ToString();
            }
            _operation = TypeOperation.None;
        }

        private void frmCRUD_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadData();
        }

        private List<DataT3Service.Person> LoadData()
        {
            return (from p in Program.client.GetPersons()
                     select p).ToList();
        }

        private void tabControlPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            iDTextBox.Text = _person.ID.ToString();
            listParticipateSem.Items.Clear();
            listFreeSem.Items.Clear();
            Reload();
        }

        private void Reload()
        {
            listParticipateSem.Items.Clear();
            listFreeSem.Items.Clear();

            var seminarPract = from seminar in Program.client.GetSeminarsForPerson(_person)
                               select seminar.Name;


            listParticipateSem.Items.AddRange((seminarPract).ToArray());


            var seminarFree = from all in Program.client.GetSeminars()
                              where !(from use in Program.client.GetSeminarsForPerson(_person)
                                      select use.Name)
                              .Contains(all.Name)

                              select all.Name;

            listFreeSem.Items.AddRange((seminarFree).ToArray());
        }

        private void listParticipateSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelSem.Enabled = (listParticipateSem.SelectedIndex != -1) ? true : false;

            _delItemName = listParticipateSem.SelectedItem.ToString();
        }

        private void listFreeSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddSem.Enabled = (listFreeSem.SelectedIndex != -1) ? true : false;
            _addItemName = listFreeSem.SelectedItem.ToString();
        }

        private void btnDelSem_Click(object sender, EventArgs e)
        {  

            DataT3Service.Seminar seminar = (from sem in Program.client.GetSeminars()
                                             where sem.Name == _delItemName select sem).First();

            Program.client.RemoveAssociationPer_Sem(_person, new List<DataT3Service.Seminar>() {seminar});
            btnDelSem.Enabled = false;
            Reload();
        }

        private void btnAddSem_Click(object sender, EventArgs e)
        {
            DataT3Service.Seminar seminar = (from sem in Program.client.GetSeminars()
                                             where sem.Name == _addItemName select sem).First();
            
            Program.client.AddAssociationPer_Sem(_person, new List<DataT3Service.Seminar>() { seminar });
            btnDelSem.Enabled = false;
            Reload();
        }
    }
}
