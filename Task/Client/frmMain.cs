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
        private List<Person> persons;
        private List<Seminar> seminars;

        private void CreateDB()
        {
            this.persons = new List<Person>()
            {
                new Person()
                {
                    Id = "1",
                    Name = "Petro",
                    Age = "28"
                },
                new Person()
                {
                    Id = "2",
                    Name = "Vasya",
                    Age = "28"
                },
                new Person()
                {
                    Id = "3",
                    Name = "Vova",
                    Age = "38"
                }
            };

            this.seminars = new List<Seminar>()
            {
                new Seminar()
                {
                    ID = "1",
                    Name = "C#"
                },
                new Seminar()
                {
                    ID = "2",
                    Name = "ASP.NET"
                }
            };
        }

        private void ShowPersons()
        {
            lvShowPersons.Items.Clear();
            ListViewItem[] items = new ListViewItem[persons.Count];

            for (int i = 0, len = items.Length; i < len; i++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(persons[i].Id);
                item.SubItems.Add(persons[i].Name);
                item.SubItems.Add(persons[i].Age);
                items[i] = item;
            }
            lvShowPersons.Items.AddRange(items);
        }

        private void OnInit()
        {
            TreeNode[] semNodes = new TreeNode[seminars.Count];

            for (int i = 0, len = semNodes.Length; i < len; i++)
            {
                semNodes[i] = new TreeNode(seminars[i].Name, 0, 0);
            }


            tvSeminars.Nodes.Add(new TreeNode("Семінари", 0, 0, semNodes));
            

            tvSeminars.CollapseAll();

            lvShowPersons.Columns.Add("", -2, HorizontalAlignment.Left);
            lvShowPersons.Columns.Add("Name");//, -2, HorizontalAlignment.Left);
            lvShowPersons.Columns.Add("Zip");//, -2, HorizontalAlignment.Left);
            lvShowPersons.Columns.Add("Tax");//, -2, HorizontalAlignment.Left);

            // Set the view to show details.
            lvShowPersons.View = View.Details;
            
            lvShowPersons.FullRowSelect = true;
            // Display grid lines.
            lvShowPersons.GridLines = true;

            lvShowPersons.LabelEdit = true;
            // Allow the user to rearrange columns.
            lvShowPersons.AllowColumnReorder = true;
            // Display check boxes.
            lvShowPersons.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            lvShowPersons.FullRowSelect = true;
            // Display grid lines.
            lvShowPersons.GridLines = true;
        }

        public frmMain()
        {
            CreateDB();
            InitializeComponent();
            OnInit();

            lvShowPersons.SelectedIndexChanged += lvShowPersons_SelectedIndexChanged;
        }

        void lvShowPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection breakfast =
            this.lvShowPersons.SelectedItems;

            string s = string.Empty;

            foreach (ListViewItem item in breakfast)
            {
                s += String.Format("{3}ID: {0}{3}Name: {1}{3}Age: {2}{3}", 
                    item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text,Environment.NewLine);
            }

            txShowDetailPerson.Text = s;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

                DataT3Service.T3InterfaceClient client;
                client = new DataT3Service.T3InterfaceClient();

                List<DataT3Service.Seminar> listSeminars = client.GetSeminars();

                TreeNode[] trees = new TreeNode[listSeminars.Count];

                for(int i=0, len=listSeminars.Count; i < len; i++)
                {
                    trees[i] = new TreeNode(listSeminars[i].Name);
                }

                tvSeminars.Nodes.AddRange(trees);
        }

        private void tvSeminars_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null)
                ShowPersons();
        }

        private void tvSeminars_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            //e.Node.ForeColor = System.Drawing.Color.DarkGreen;
           
        }

        private void lvShowPersons_MouseMove(object sender, MouseEventArgs e)
        {
            
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

			// Начинаем обработку каждого элемента в кtvSeminarsоллекции
            foreach (ListViewItem item in items)
            {
                TreeNode node = new TreeNode(item.SubItems[1].Text);
                parentNode.Nodes.Add(node);
            }



            //	item.ListView.Items.Remove(item);	// Так как мы перетаскиваем из одного листа в другой, то элемент сначала надо удалить из "родительского" листа
			//	listView.Items.Add(item);  
        }

        private void lvShowPersons_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lvShowPersons.DoDragDrop(lvShowPersons.SelectedItems, DragDropEffects.Move);
        }
    }
}
