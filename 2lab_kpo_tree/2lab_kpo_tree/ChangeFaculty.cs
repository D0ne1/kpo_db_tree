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
    public partial class ChangeFaculty : Form
    {
        private int facultyId;
        public ChangeFaculty(int id, string currentTitle)
        {
            InitializeComponent();
            facultyId = id;
            txt_new_faculty.Text = currentTitle;
        }

        private void btn_update_faculty_Click(object sender, EventArgs e)
        {
            string newTitle = txt_new_faculty.Text.Trim();
            if (string.IsNullOrEmpty(newTitle))
            {
                MessageBox.Show("Название факультета не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=D0NEL;Initial Catalog=University;Integrated Security=True"))
            {
                conn.Open();
                string query = "UPDATE Faculties SET Title = @Title WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", newTitle);
                    cmd.Parameters.AddWithValue("@Id", facultyId);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Факультет успешно обновлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
