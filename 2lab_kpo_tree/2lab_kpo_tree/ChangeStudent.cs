using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _2lab_kpo_tree
{
    public partial class ChangeStudent : Form
    {
        private string ConnectionString;
        private int StudentId;
        public ChangeStudent(int studentId, string name, string surname, string connectionString)
        {
            InitializeComponent();
            this.StudentId = studentId;
            this.ConnectionString = connectionString;
            txt_new_name.Text = name;
            txt_new_surname.Text = surname;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_new_name.Text) || string.IsNullOrWhiteSpace(txt_new_surname.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                string query = "UPDATE Students SET Name = @Name, Surname = @Surname WHERE Id = @StudentId";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Name", txt_new_name.Text);
                    cmd.Parameters.AddWithValue("@Surname", txt_new_surname.Text);
                    cmd.Parameters.AddWithValue("@StudentId", StudentId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Данные студента обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
