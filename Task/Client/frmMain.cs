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
    public partial class frmMain : Form
    {        
        private List<DataT3Service.Person> _persons;
        private List<DataT3Service.Seminar> _seminars;

        private  string _selectedSeminarName;


        private void OnInit()
        {            
            _selectedSeminarName = string.Empty;
            

            tvSeminars.Nodes.Add(new TreeNode("Семінари", 0, 0, new TreeNode[] { new TreeNode("...") }));                     

            tvSeminars.CollapseAll();

            lvShowPersons.Columns.Add("", -2, HorizontalAlignment.Left);
            lvShowPersons.Columns.Add("Name");
            lvShowPersons.Columns.Add("Birthday");
            lvShowPersons.Columns.Add("City");
            lvShowPersons.Columns.Add("Tax");

            lvShowPersons.View = View.Details;
            lvShowPersons.FullRowSelect = true;
            lvShowPersons.GridLines = true;
            lvShowPersons.AllowColumnReorder = true;
            lvShowPersons.CheckBoxes = true;
            lvShowPersons.FullRowSelect = true;
            lvShowPersons.GridLines = true;
        }

        public frmMain()
        {
            InitializeComponent();
            OnInit();

            lvShowPersons.SelectedIndexChanged += lvShowPersons_SelectedIndexChanged;
        }

        void lvShowPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = lvShowPersons.SelectedItems;

            string detailInfo = string.Empty;
            //знайти лектора по назві і вивести всю інформація про нього
            foreach (ListViewItem item in selectedItems)
            {
                DataT3Service.Person person = _persons.Where(val=> val.Name == item.SubItems[1].Text).First();

                detailInfo = String.Format(
                "Імя: {0}{7}Дата народження:{1}{7}Адреса:{2}{7}Індекс:{3}{7}Місто:{4}{7}Тах:{5}{7}Опис:{6}{7}",
                    person.Name, person.Birthday, person.Address, person.Zip, person.City, person.Tax, person.Memo,
                    Environment.NewLine);
            }

            txShowDetailPerson.Text = detailInfo;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCRUD crud = new frmCRUD(TypeOperation.Add, _selectedSeminarName);
            crud.Show();

        }

        private void tvSeminars_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvSeminars_NodeMouseDoubleClick(sender, e);
        }

        private void lvShowPersons_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void tvSeminars_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void tvSeminars_DragDrop(object sender, DragEventArgs e)
        {
            var items = e.Data.GetData("System.Windows.Forms.ListView+SelectedListViewItemCollection") as ListView.SelectedListViewItemCollection;

            TreeNode parentNode = this.tvSeminars.GetNodeAt(this.tvSeminars.PointToClient(new Point(e.X, e.Y)));

            if (items == null || parentNode.Level != 1)
            {
                return;
            }

            // знайти список усіх користувачів по назві які додаються, по назві з Items
            List<DataT3Service.Person> addPerson = new List<DataT3Service.Person>();

            // додавання у вузлів користувачів для конкретного симінару та в БД
            foreach (ListViewItem item in items)
            {
                // перевырити чи вузол з таким ыменем вже є якщо є то пропустити ітерацію
                // пройтися по всім вкладеним вузлам і отримати їхні тексти і звірити їх з
                // додаваним запсом
                bool isAdd = true;

                foreach (TreeNode itemNode in parentNode.Nodes)
                {
                    if (item.Text == item.SubItems[1].Text)
                    {
                        isAdd = false;
                    }
                }

                if (!isAdd)
                {
                    TreeNode node = new TreeNode(item.SubItems[1].Text, 1, 1);
                    addPerson.Add(_persons.Where(val => val.Name == item.SubItems[1].Text).First());
                    parentNode.Nodes.Add(node);
                }
                else
                {
                    continue;
                }
            }

            Program.client.AddAssociationSem_Per(_seminars.Where(val => val.Name == parentNode.Text).First(), addPerson);
        }

        private void lvShowPersons_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lvShowPersons.DoDragDrop(lvShowPersons.SelectedItems, DragDropEffects.Move);
        }

        private void tvSeminars_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //todo: load all persons with ListView

            lvShowPersons.Items.Clear();
            if (e.Node.Parent == null)
            {
                _selectedSeminarName = string.Empty;
                tsslSelectSeminar.Text = "Вибраний семінар: ";

                _persons = Program.client.GetPersons();
                ListViewItem[] items = FoundPersonsByListView(_persons);
                lvShowPersons.Items.AddRange(items);
            }
            else if (e.Node.Level == 1)
            {
                tsslSelectSeminar.Text = "Вибраний семінар: " + e.Node.Text;
                ListViewItem[] items = FoundPersonsByListView(
                    Program.client.GetPersonsForSeminar(_seminars.Where(val => val.Name == e.Node.Text).FirstOrDefault()));
                lvShowPersons.Items.AddRange(items);
            }
            else
            {
                _selectedSeminarName = string.Empty;
                tsslSelectSeminar.Text = "Вибраний семінар: ";
            }
        }

        private ListViewItem[] FoundPersonsByListView(List<DataT3Service.Person> persons)
        {
            ListViewItem[] items = new ListViewItem[persons.Count];

            for (int i = 0, len = items.Length; i < len; i++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(persons[i].Name);
                item.SubItems.Add(persons[i].Birthday.ToString());
                item.SubItems.Add(persons[i].City);
                item.SubItems.Add(persons[i].Zip);
                items[i] = item;
            }
            return items;
        }

        private void tvSeminars_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                e.Node.Nodes.Clear();
                _selectedSeminarName = string.Empty;
                tsslSelectSeminar.Text = "Вибраний семінар: ";

                List<DataT3Service.Seminar> listSeminars = Program.client.GetSeminars();
                _seminars = listSeminars;
                TreeNode[] trees = new TreeNode[listSeminars.Count];

                for (int i = 0, len = listSeminars.Count; i < len; i++)
                {
                    trees[i] = new TreeNode(listSeminars[i].Name, 0, 0, new TreeNode[] { new TreeNode("...") });
                }

                e.Node.Nodes.AddRange(trees);
            }
            else if (e.Node.Level == 1)
            {
                //todo: load persons for this seminar and show those their in ListView
                e.Node.Nodes.Clear();

                _selectedSeminarName = e.Node.Text;
                tsslSelectSeminar.Text = "Вибраний семінар: " + e.Node.Text;

                List<DataT3Service.Person> listSeminars =
                Program.client.GetPersonsForSeminar(_seminars.Where(val => val.Name == e.Node.Text).FirstOrDefault());

                TreeNode[] trees = new TreeNode[listSeminars.Count];

                for (int i = 0, len = listSeminars.Count; i < len; i++)
                {
                    trees[i] = new TreeNode(listSeminars[i].Name, 1, 1);
                }

                e.Node.Nodes.AddRange(trees);
            }
            else
            {
                //todo: don't anything with Node
                _selectedSeminarName = string.Empty;
                tsslSelectSeminar.Text = "Вибраний семінар: ";
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataT3Service.Person person = new DataT3Service.Person();
            ListView.SelectedListViewItemCollection selectedItems = lvShowPersons.SelectedItems;

            foreach (ListViewItem item in selectedItems)
            {
                person = _persons.Where(val => val.Name == item.SubItems[1].Text).First();                
            }

            if(DialogResult.OK == MessageBox.Show(String.Format("Ви дійсно бажаєте видалити лектора {0}?", person.Name),
                "Видалення користувача", MessageBoxButtons.OKCancel))
            {
                Program.client.RemovePersons(new List<DataT3Service.Person>() { person });
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataT3Service.Person person = new DataT3Service.Person();
            ListView.SelectedListViewItemCollection selectedItems = lvShowPersons.SelectedItems;

            foreach (ListViewItem item in selectedItems)
            {
                person = _persons.Where(val => val.Name == item.SubItems[1].Text).First();
            }

            if (person.ID == 0)
            {
                if (DialogResult.OK == MessageBox.Show(
                    "Не вибрано жодного користувача для редагування.\nВсеодно відкрити?",
                    "Повідомлення", MessageBoxButtons.OKCancel))
                {
                    frmCRUD crud = new frmCRUD(TypeOperation.Update, _selectedSeminarName, null);
                    crud.Show();
                }
            }
            else
            {
                frmCRUD crud = new frmCRUD(TypeOperation.Update, _selectedSeminarName, person);
                crud.Show();
            }
            
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }


    }
}
