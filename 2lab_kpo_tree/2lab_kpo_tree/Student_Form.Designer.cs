namespace _2lab_kpo_tree
{
    partial class Student_Form
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
            this.name_stdn_write = new System.Windows.Forms.TextBox();
            this.stdnt_name = new System.Windows.Forms.Label();
            this.stdn_surname = new System.Windows.Forms.Label();
            this.surname_stdn_write = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name_stdn_write
            // 
            this.name_stdn_write.Location = new System.Drawing.Point(216, 93);
            this.name_stdn_write.Name = "name_stdn_write";
            this.name_stdn_write.Size = new System.Drawing.Size(302, 22);
            this.name_stdn_write.TabIndex = 5;
            // 
            // stdnt_name
            // 
            this.stdnt_name.AutoSize = true;
            this.stdnt_name.Location = new System.Drawing.Point(113, 96);
            this.stdnt_name.Name = "stdnt_name";
            this.stdnt_name.Size = new System.Drawing.Size(33, 16);
            this.stdnt_name.TabIndex = 4;
            this.stdnt_name.Text = "Имя";
            // 
            // stdn_surname
            // 
            this.stdn_surname.AutoSize = true;
            this.stdn_surname.Location = new System.Drawing.Point(113, 139);
            this.stdn_surname.Name = "stdn_surname";
            this.stdn_surname.Size = new System.Drawing.Size(66, 16);
            this.stdn_surname.TabIndex = 6;
            this.stdn_surname.Text = "Фамилия";
            // 
            // surname_stdn_write
            // 
            this.surname_stdn_write.Location = new System.Drawing.Point(216, 136);
            this.surname_stdn_write.Name = "surname_stdn_write";
            this.surname_stdn_write.Size = new System.Drawing.Size(302, 22);
            this.surname_stdn_write.TabIndex = 7;
            // 
            // Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 276);
            this.Controls.Add(this.surname_stdn_write);
            this.Controls.Add(this.stdn_surname);
            this.Controls.Add(this.name_stdn_write);
            this.Controls.Add(this.stdnt_name);
            this.Name = "Student_Form";
            this.Text = "Student_Form";
            this.Load += new System.EventHandler(this.Student_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_stdn_write;
        private System.Windows.Forms.Label stdnt_name;
        private System.Windows.Forms.Label stdn_surname;
        private System.Windows.Forms.TextBox surname_stdn_write;
    }
}