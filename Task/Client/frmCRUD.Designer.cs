namespace Client
{
    partial class frmCRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label memoLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label taxLabel;
            System.Windows.Forms.Label zipLabel;
            System.Windows.Forms.Label nameLabel;
            this.tabControlPerson = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.memoTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.btnAddSem = new System.Windows.Forms.Button();
            this.btnDelSem = new System.Windows.Forms.Button();
            this.listFreeSem = new System.Windows.Forms.ListBox();
            this.listParticipateSem = new System.Windows.Forms.ListBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            memoLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            taxLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.tabControlPerson.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(10, 16);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 4;
            iDLabel.Text = "ID:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(275, 27);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 6;
            cityLabel.Text = "City:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(17, 66);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(48, 13);
            birthdayLabel.TabIndex = 4;
            birthdayLabel.Text = "Birthday:";
            // 
            // memoLabel
            // 
            memoLabel.AutoSize = true;
            memoLabel.Location = new System.Drawing.Point(493, 63);
            memoLabel.Name = "memoLabel";
            memoLabel.Size = new System.Drawing.Size(39, 13);
            memoLabel.TabIndex = 8;
            memoLabel.Text = "Memo:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(254, 66);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "Address:";
            // 
            // taxLabel
            // 
            taxLabel.AutoSize = true;
            taxLabel.Location = new System.Drawing.Point(37, 103);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new System.Drawing.Size(28, 13);
            taxLabel.TabIndex = 10;
            taxLabel.Text = "Tax:";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new System.Drawing.Point(277, 103);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(25, 13);
            zipLabel.TabIndex = 12;
            zipLabel.Text = "Zip:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(27, 27);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // tabControlPerson
            // 
            this.tabControlPerson.Controls.Add(this.tabPage1);
            this.tabControlPerson.Controls.Add(this.tabPage2);
            this.tabControlPerson.Location = new System.Drawing.Point(12, 11);
            this.tabControlPerson.Name = "tabControlPerson";
            this.tabControlPerson.SelectedIndex = 0;
            this.tabControlPerson.Size = new System.Drawing.Size(753, 486);
            this.tabControlPerson.TabIndex = 0;
            this.tabControlPerson.SelectedIndexChanged += new System.EventHandler(this.tabControlPerson_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(745, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Refenet";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 164);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(734, 276);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(zipLabel);
            this.groupBox1.Controls.Add(this.zipTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(taxLabel);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(this.taxTextBox);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(memoLabel);
            this.groupBox1.Controls.Add(this.birthdayDateTimePicker);
            this.groupBox1.Controls.Add(this.memoTextBox);
            this.groupBox1.Controls.Add(birthdayLabel);
            this.groupBox1.Controls.Add(cityLabel);
            this.groupBox1.Controls.Add(this.cityTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 152);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(652, 123);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(316, 100);
            this.zipTextBox.MaxLength = 5;
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(136, 20);
            this.zipTextBox.TabIndex = 13;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(85, 24);
            this.nameTextBox.MaxLength = 30;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(133, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // taxTextBox
            // 
            this.taxTextBox.Location = new System.Drawing.Point(85, 100);
            this.taxTextBox.MaxLength = 10;
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.Size = new System.Drawing.Size(133, 20);
            this.taxTextBox.TabIndex = 11;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(316, 63);
            this.addressTextBox.MaxLength = 30;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(136, 20);
            this.addressTextBox.TabIndex = 5;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(85, 63);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.birthdayDateTimePicker.TabIndex = 5;
            // 
            // memoTextBox
            // 
            this.memoTextBox.Location = new System.Drawing.Point(538, 24);
            this.memoTextBox.Multiline = true;
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.Size = new System.Drawing.Size(163, 96);
            this.memoTextBox.TabIndex = 9;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(316, 24);
            this.cityTextBox.MaxLength = 30;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(136, 20);
            this.cityTextBox.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(iDLabel);
            this.tabPage2.Controls.Add(this.iDTextBox);
            this.tabPage2.Controls.Add(this.btnAddSem);
            this.tabPage2.Controls.Add(this.btnDelSem);
            this.tabPage2.Controls.Add(this.listFreeSem);
            this.tabPage2.Controls.Add(this.listParticipateSem);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(745, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Seminar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // iDTextBox
            // 
            this.iDTextBox.Location = new System.Drawing.Point(37, 13);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 5;
            // 
            // btnAddSem
            // 
            this.btnAddSem.Location = new System.Drawing.Point(287, 233);
            this.btnAddSem.Name = "btnAddSem";
            this.btnAddSem.Size = new System.Drawing.Size(75, 23);
            this.btnAddSem.TabIndex = 3;
            this.btnAddSem.Text = "<-";
            this.btnAddSem.UseVisualStyleBackColor = true;
            this.btnAddSem.Click += new System.EventHandler(this.btnAddSem_Click);
            // 
            // btnDelSem
            // 
            this.btnDelSem.Location = new System.Drawing.Point(287, 180);
            this.btnDelSem.Name = "btnDelSem";
            this.btnDelSem.Size = new System.Drawing.Size(75, 23);
            this.btnDelSem.TabIndex = 2;
            this.btnDelSem.Text = "->";
            this.btnDelSem.UseVisualStyleBackColor = true;
            this.btnDelSem.Click += new System.EventHandler(this.btnDelSem_Click);
            // 
            // listFreeSem
            // 
            this.listFreeSem.FormattingEnabled = true;
            this.listFreeSem.Location = new System.Drawing.Point(381, 65);
            this.listFreeSem.Name = "listFreeSem";
            this.listFreeSem.Size = new System.Drawing.Size(247, 381);
            this.listFreeSem.TabIndex = 1;
            this.listFreeSem.SelectedIndexChanged += new System.EventHandler(this.listFreeSem_SelectedIndexChanged);
            // 
            // listParticipateSem
            // 
            this.listParticipateSem.FormattingEnabled = true;
            this.listParticipateSem.Location = new System.Drawing.Point(6, 65);
            this.listParticipateSem.Name = "listParticipateSem";
            this.listParticipateSem.Size = new System.Drawing.Size(259, 381);
            this.listParticipateSem.TabIndex = 0;
            this.listParticipateSem.SelectedIndexChanged += new System.EventHandler(this.listParticipateSem_SelectedIndexChanged);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Client.DataT3Service.Person);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Бере участь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Не бере участь";
            // 
            // frmCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 506);
            this.Controls.Add(this.tabControlPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCRUD";
            this.Load += new System.EventHandler(this.frmCRUD_Load);
            this.tabControlPerson.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPerson;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.Button btnAddSem;
        private System.Windows.Forms.Button btnDelSem;
        private System.Windows.Forms.ListBox listFreeSem;
        private System.Windows.Forms.ListBox listParticipateSem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox memoTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}