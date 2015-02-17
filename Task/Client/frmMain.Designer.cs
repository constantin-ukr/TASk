namespace Client
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tvSeminars = new System.Windows.Forms.TreeView();
            this.imgTV = new System.Windows.Forms.ImageList(this.components);
            this.lvShowPersons = new System.Windows.Forms.ListView();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.txShowDetailPerson = new System.Windows.Forms.TextBox();
            this.grbxToolbar = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.imgListToolbar = new System.Windows.Forms.ImageList(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslSelectSeminar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.grbxToolbar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvSeminars
            // 
            this.tvSeminars.AllowDrop = true;
            this.tvSeminars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvSeminars.HotTracking = true;
            this.tvSeminars.ImageIndex = 0;
            this.tvSeminars.ImageList = this.imgTV;
            this.tvSeminars.Location = new System.Drawing.Point(3, 70);
            this.tvSeminars.Name = "tvSeminars";
            this.tvSeminars.SelectedImageIndex = 0;
            this.tvSeminars.Size = new System.Drawing.Size(278, 364);
            this.tvSeminars.TabIndex = 0;
            this.tvSeminars.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvSeminars_BeforeExpand);
            this.tvSeminars.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvSeminars_NodeMouseClick);
            this.tvSeminars.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvSeminars_NodeMouseDoubleClick);
            this.tvSeminars.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvSeminars_DragDrop);
            this.tvSeminars.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvSeminars_DragEnter);
            // 
            // imgTV
            // 
            this.imgTV.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTV.ImageStream")));
            this.imgTV.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTV.Images.SetKeyName(0, "seminar.png");
            this.imgTV.Images.SetKeyName(1, "people.png");
            // 
            // lvShowPersons
            // 
            this.lvShowPersons.AllowDrop = true;
            this.lvShowPersons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvShowPersons.LargeImageList = this.imgIcon;
            this.lvShowPersons.Location = new System.Drawing.Point(285, 70);
            this.lvShowPersons.Name = "lvShowPersons";
            this.lvShowPersons.Size = new System.Drawing.Size(352, 209);
            this.lvShowPersons.SmallImageList = this.imgIcon;
            this.lvShowPersons.StateImageList = this.imgIcon;
            this.lvShowPersons.TabIndex = 1;
            this.lvShowPersons.UseCompatibleStateImageBehavior = false;
            this.lvShowPersons.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvShowPersons_ItemDrag);
            this.lvShowPersons.DragOver += new System.Windows.Forms.DragEventHandler(this.lvShowPersons_DragOver);
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "people.png");
            this.imgIcon.Images.SetKeyName(1, "people.png");
            // 
            // txShowDetailPerson
            // 
            this.txShowDetailPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txShowDetailPerson.Location = new System.Drawing.Point(287, 285);
            this.txShowDetailPerson.Multiline = true;
            this.txShowDetailPerson.Name = "txShowDetailPerson";
            this.txShowDetailPerson.Size = new System.Drawing.Size(352, 149);
            this.txShowDetailPerson.TabIndex = 2;
            // 
            // grbxToolbar
            // 
            this.grbxToolbar.Controls.Add(this.btnDelete);
            this.grbxToolbar.Controls.Add(this.btnUpdate);
            this.grbxToolbar.Controls.Add(this.btnAdd);
            this.grbxToolbar.Location = new System.Drawing.Point(3, 4);
            this.grbxToolbar.Name = "grbxToolbar";
            this.grbxToolbar.Size = new System.Drawing.Size(181, 60);
            this.grbxToolbar.TabIndex = 3;
            this.grbxToolbar.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.ImageIndex = 2;
            this.btnDelete.ImageList = this.imgListToolbar;
            this.btnDelete.Location = new System.Drawing.Point(122, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 42);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // imgListToolbar
            // 
            this.imgListToolbar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListToolbar.ImageStream")));
            this.imgListToolbar.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListToolbar.Images.SetKeyName(0, "add.png");
            this.imgListToolbar.Images.SetKeyName(1, "edit.png");
            this.imgListToolbar.Images.SetKeyName(2, "delete.jpg");
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageIndex = 1;
            this.btnUpdate.ImageList = this.imgListToolbar;
            this.btnUpdate.Location = new System.Drawing.Point(64, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(52, 42);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleDescription = "Add";
            this.btnAdd.ImageIndex = 0;
            this.btnAdd.ImageList = this.imgListToolbar;
            this.btnAdd.Location = new System.Drawing.Point(6, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 42);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Tag = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslSelectSeminar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(649, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslSelectSeminar
            // 
            this.tsslSelectSeminar.Name = "tsslSelectSeminar";
            this.tsslSelectSeminar.Size = new System.Drawing.Size(115, 17);
            this.tsslSelectSeminar.Text = "Вибраний семінар: ";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(525, 16);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(53, 42);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(584, 16);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(53, 42);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 459);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grbxToolbar);
            this.Controls.Add(this.txShowDetailPerson);
            this.Controls.Add(this.lvShowPersons);
            this.Controls.Add(this.tvSeminars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grbxToolbar.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvSeminars;
        private System.Windows.Forms.ListView lvShowPersons;
        private System.Windows.Forms.TextBox txShowDetailPerson;
        private System.Windows.Forms.GroupBox grbxToolbar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ImageList imgListToolbar;
        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.ImageList imgTV;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslSelectSeminar;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSettings;
    }
}