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
            this.изменитьГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьгруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьстудентаContextMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьФакультетToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.studentСontextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьстудентаContextMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьстудентаContextMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.facultyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьФакультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьФакультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.добавитьГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
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
            this.изменитьГруппуToolStripMenuItem,
            this.toolStripMenuItem2,
            this.добавитьстудентаContextMenuStrip,
            this.toolStripMenuItem4,
            this.удалитьгруппуToolStripMenuItem});
            this.groupContextMenu.Name = "groupContextMenu";
            this.groupContextMenu.Size = new System.Drawing.Size(211, 116);
            // 
            // изменитьГруппуToolStripMenuItem
            // 
            this.изменитьГруппуToolStripMenuItem.Name = "изменитьГруппуToolStripMenuItem";
            this.изменитьГруппуToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.изменитьГруппуToolStripMenuItem.Text = "Изменить группу";
            this.изменитьГруппуToolStripMenuItem.Click += new System.EventHandler(this.изменитьГруппуToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(207, 6);
            // 
            // удалитьгруппуToolStripMenuItem
            // 
            this.удалитьгруппуToolStripMenuItem.Name = "удалитьгруппуToolStripMenuItem";
            this.удалитьгруппуToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.удалитьгруппуToolStripMenuItem.Text = "Удалить";
            this.удалитьгруппуToolStripMenuItem.Click += new System.EventHandler(this.удалитьгруппуToolStripMenuItem_Click);
            // 
            // добавитьстудентаContextMenuStrip
            // 
            this.добавитьстудентаContextMenuStrip.Name = "добавитьстудентаContextMenuStrip";
            this.добавитьстудентаContextMenuStrip.Size = new System.Drawing.Size(210, 24);
            this.добавитьстудентаContextMenuStrip.Text = "Добавить студента";
            this.добавитьстудентаContextMenuStrip.Click += new System.EventHandler(this.добавитьстудентаContextMenuStrip_Click);
            // 
            // удалитьФакультетToolStripMenuItem1
            // 
            this.удалитьФакультетToolStripMenuItem1.Name = "удалитьФакультетToolStripMenuItem1";
            this.удалитьФакультетToolStripMenuItem1.Size = new System.Drawing.Size(226, 24);
            this.удалитьФакультетToolStripMenuItem1.Text = "Удалить";
            this.удалитьФакультетToolStripMenuItem1.Click += new System.EventHandler(this.удалитьФакультетToolStripMenuItem1_Click);
            // 
            // studentСontextMenu
            // 
            this.studentСontextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.studentСontextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьстудентаContextMenuStrip,
            this.toolStripSeparator1,
            this.удалитьстудентаContextMenuStrip});
            this.studentСontextMenu.Name = "groupContextMenu";
            this.studentСontextMenu.Size = new System.Drawing.Size(211, 58);
            // 
            // изменитьстудентаContextMenuStrip
            // 
            this.изменитьстудентаContextMenuStrip.Name = "изменитьстудентаContextMenuStrip";
            this.изменитьстудентаContextMenuStrip.Size = new System.Drawing.Size(210, 24);
            this.изменитьстудентаContextMenuStrip.Text = "Изменить студента";
            this.изменитьстудентаContextMenuStrip.Click += new System.EventHandler(this.изменитьстудентаContextMenuStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // удалитьстудентаContextMenuStrip
            // 
            this.удалитьстудентаContextMenuStrip.Name = "удалитьстудентаContextMenuStrip";
            this.удалитьстудентаContextMenuStrip.Size = new System.Drawing.Size(210, 24);
            this.удалитьстудентаContextMenuStrip.Text = "Удалить";
            this.удалитьстудентаContextMenuStrip.Click += new System.EventHandler(this.удалитьстудентаContextMenuStrip_Click);
            // 
            // facultyMenuStrip
            // 
            this.facultyMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.facultyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьФакультетToolStripMenuItem,
            this.изменитьФакультетToolStripMenuItem,
            this.toolStripMenuItem1,
            this.добавитьГруппуToolStripMenuItem,
            this.toolStripMenuItem3,
            this.удалитьФакультетToolStripMenuItem1});
            this.facultyMenuStrip.Name = "facultyMenuStrip";
            this.facultyMenuStrip.Size = new System.Drawing.Size(227, 112);
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
            this.изменитьФакультетToolStripMenuItem.Text = "Изменить факультет";
            this.изменитьФакультетToolStripMenuItem.Click += new System.EventHandler(this.изменитьФакультетToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(223, 6);
            // 
            // добавитьГруппуToolStripMenuItem
            // 
            this.добавитьГруппуToolStripMenuItem.Name = "добавитьГруппуToolStripMenuItem";
            this.добавитьГруппуToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.добавитьГруппуToolStripMenuItem.Text = "Добавить группу";
            this.добавитьГруппуToolStripMenuItem.Click += new System.EventHandler(this.добавитьГруппуToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(223, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(207, 6);
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
        private System.Windows.Forms.ToolStripMenuItem изменитьГруппуToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
      
        private System.Windows.Forms.ContextMenuStrip studentСontextMenu;
        private System.Windows.Forms.ToolStripMenuItem изменитьстудентаContextMenuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem удалитьстудентаContextMenuStrip;
        private System.Windows.Forms.ContextMenuStrip facultyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьФакультетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьФакультетToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьФакультетToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьгруппуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьГруппуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьстудентаContextMenuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
    }
}

