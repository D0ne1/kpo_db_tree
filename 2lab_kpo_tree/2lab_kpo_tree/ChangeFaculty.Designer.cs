namespace _2lab_kpo_tree
{
    partial class ChangeFaculty
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_new_faculty = new System.Windows.Forms.TextBox();
            this.btn_update_faculty = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новое имя факультета";
            // 
            // txt_new_faculty
            // 
            this.txt_new_faculty.Location = new System.Drawing.Point(216, 77);
            this.txt_new_faculty.Name = "txt_new_faculty";
            this.txt_new_faculty.Size = new System.Drawing.Size(192, 22);
            this.txt_new_faculty.TabIndex = 1;
            // 
            // btn_update_faculty
            // 
            this.btn_update_faculty.Location = new System.Drawing.Point(84, 166);
            this.btn_update_faculty.Name = "btn_update_faculty";
            this.btn_update_faculty.Size = new System.Drawing.Size(90, 23);
            this.btn_update_faculty.TabIndex = 2;
            this.btn_update_faculty.Text = "Изменить";
            this.btn_update_faculty.UseVisualStyleBackColor = true;
            this.btn_update_faculty.Click += new System.EventHandler(this.btn_update_faculty_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(216, 166);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // ChangeFaculty
            // 
            this.AcceptButton = this.btn_update_faculty;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(420, 214);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_update_faculty);
            this.Controls.Add(this.txt_new_faculty);
            this.Controls.Add(this.label1);
            this.Name = "ChangeFaculty";
            this.Text = "UpdateFaculty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_new_faculty;
        private System.Windows.Forms.Button btn_update_faculty;
        private System.Windows.Forms.Button btn_Cancel;
    }
}