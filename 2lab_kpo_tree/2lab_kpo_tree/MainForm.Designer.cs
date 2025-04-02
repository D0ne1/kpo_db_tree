namespace _2lab_kpo_tree
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_load = new System.Windows.Forms.Button();
            this.trv_Data = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.studentСontextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_add_stdn = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_change_stdn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_delete_stnd = new System.Windows.Forms.ToolStripMenuItem();
            this.facultyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьФакультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьФакультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьФакультетToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupContextMenu.SuspendLayout();
            this.studentСontextMenu.SuspendLayout();
            this.facultyMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_load.Location = new System.Drawing.Point(561, 468);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(176, 32);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Загрузить";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // trv_Data
            // 
            this.trv_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trv_Data.ImageIndex = 0;
            this.trv_Data.ImageList = this.imageList1;
            this.trv_Data.Location = new System.Drawing.Point(12, 14);
            this.trv_Data.Name = "trv_Data";
            this.trv_Data.SelectedImageIndex = 0;
            this.trv_Data.Size = new System.Drawing.Size(724, 448);
            this.trv_Data.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "290144_building_office_finance buildings_icon.png");
            this.imageList1.Images.SetKeyName(1, "103577_group_half_icon.png");
            this.imageList1.Images.SetKeyName(2, "211857_man_icon.png");
            // 
            // groupContextMenu
            // 
            this.groupContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.groupContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьГруппуToolStripMenuItem,
            this.изменитьГруппуToolStripMenuItem,
            this.toolStripMenuItem2,
            this.удалитьФакультетToolStripMenuItem1});
            this.groupContextMenu.Name = "groupContextMenu";
            this.groupContextMenu.Size = new System.Drawing.Size(206, 82);
            // 
            // добавитьГруппуToolStripMenuItem
            // 
            this.добавитьГруппуToolStripMenuItem.Name = "добавитьГруппуToolStripMenuItem";
            this.добавитьГруппуToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.добавитьГруппуToolStripMenuItem.Text = "Добавить группу...";
            this.добавитьГруппуToolStripMenuItem.Click += new System.EventHandler(this.добавитьГруппуToolStripMenuItem_Click);
            // 
            // изменитьГруппуToolStripMenuItem
            // 
            this.изменитьГруппуToolStripMenuItem.Name = "изменитьГруппуToolStripMenuItem";
            this.изменитьГруппуToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.изменитьГруппуToolStripMenuItem.Text = "Изменить...";
            this.изменитьГруппуToolStripMenuItem.Click += new System.EventHandler(this.изменитьГруппуToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(202, 6);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьФакультетToolStripMenuItem1.Name = "удалитьФакультетToolStripMenuItem";
            this.удалитьФакультетToolStripMenuItem1.Size = new System.Drawing.Size(205, 24);
            this.удалитьФакультетToolStripMenuItem1.Text = "Удалить";
            // 
            // studentСontextMenu
            // 
            this.studentСontextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.studentСontextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add_stdn,
            this.btn_change_stdn,
            this.toolStripSeparator1,
            this.btn_delete_stnd});
            this.studentСontextMenu.Name = "groupContextMenu";
            this.studentСontextMenu.Size = new System.Drawing.Size(218, 82);
            // 
            // btn_add_stdn
            // 
            this.btn_add_stdn.Name = "btn_add_stdn";
            this.btn_add_stdn.Size = new System.Drawing.Size(217, 24);
            this.btn_add_stdn.Text = "Добавить студента...";
            // 
            // btn_change_stdn
            // 
            this.btn_change_stdn.Name = "btn_change_stdn";
            this.btn_change_stdn.Size = new System.Drawing.Size(217, 24);
            this.btn_change_stdn.Text = "Изменить...";
            this.btn_change_stdn.Click += new System.EventHandler(this.btn_change_stdn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // btn_delete_stnd
            // 
            this.btn_delete_stnd.Name = "btn_delete_stnd";
            this.btn_delete_stnd.Size = new System.Drawing.Size(217, 24);
            this.btn_delete_stnd.Text = "Удалить";
            // 
            // facultyMenuStrip
            // 
            this.facultyMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.facultyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьФакультетToolStripMenuItem,
            this.изменитьФакультетToolStripMenuItem,
            this.toolStripMenuItem1,
            this.удалитьФакультетToolStripMenuItem1});
            this.facultyMenuStrip.Name = "facultyMenuStrip";
            this.facultyMenuStrip.Size = new System.Drawing.Size(227, 110);
            // 
            // добавитьФакультетToolStripMenuItem
            // 
            this.добавитьФакультетToolStripMenuItem.Name = "добавитьФакультетToolStripMenuItem";
            this.добавитьФакультетToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.добавитьФакультетToolStripMenuItem.Text = "Добавить факультет...";
            this.добавитьФакультетToolStripMenuItem.Click += new System.EventHandler(this.добавитьФакультетToolStripMenuItem_Click);
            // 
            // изменитьФакультетToolStripMenuItem
            // 
            this.изменитьФакультетToolStripMenuItem.Name = "изменитьФакультетToolStripMenuItem";
            this.изменитьФакультетToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.изменитьФакультетToolStripMenuItem.Text = "Изменить";
            this.изменитьФакультетToolStripMenuItem.Click += new System.EventHandler(this.изменитьФакультетToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(223, 6);
            // 
            // удалитьФакультетToolStripMenuItem1
            // 
            this.удалитьФакультетToolStripMenuItem1.Name = "удалитьФакультетToolStripMenuItem1";
            this.удалитьФакультетToolStripMenuItem1.Size = new System.Drawing.Size(226, 24);
            this.удалитьФакультетToolStripMenuItem1.Text = "Удалить";
            this.удалитьФакультетToolStripMenuItem1.Click += new System.EventHandler(this.удалитьФакультетToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 512);
            this.Controls.Add(this.trv_Data);
            this.Controls.Add(this.btn_load);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ИС \"Универ\"";
            this.groupContextMenu.ResumeLayout(false);
            this.studentСontextMenu.ResumeLayout(false);
            this.facultyMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
       
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TreeView trv_Data;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip groupContextMenu;
        private System.Windows.Forms.ToolStripMenuItem добавитьГруппуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьГруппуToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
      
        private System.Windows.Forms.ContextMenuStrip studentСontextMenu;
        private System.Windows.Forms.ToolStripMenuItem btn_add_stdn;
        private System.Windows.Forms.ToolStripMenuItem btn_change_stdn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btn_delete_stnd;
        private System.Windows.Forms.ContextMenuStrip facultyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьФакультетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьФакультетToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьФакультетToolStripMenuItem1;
    }
}

