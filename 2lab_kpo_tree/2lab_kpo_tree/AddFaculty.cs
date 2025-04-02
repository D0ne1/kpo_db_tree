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

namespace _2lab_kpo_tree
{
    public partial class AddFaculty : Form
    {
        public AddFaculty()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string facultyTitle = txt_faculty.Text.Trim();
            if (string.IsNullOrEmpty(facultyTitle))
            {
                MessageBox.Show("Название факультета не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=D0NEL;Initial Catalog=University;Integrated Security=True"))
            {
                conn.Open();
                string query = "INSERT INTO Faculties (Title) VALUES (@Title)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", facultyTitle);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Факультет успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
