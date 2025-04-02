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
    public partial class AddGroup : Form
    {
        private string ConnectionString;
        private int FacultyId;

        public AddGroup(int facultyId, string connectionString)
        {
            InitializeComponent();
            FacultyId = facultyId;
            ConnectionString = connectionString;
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFacultyId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                MessageBox.Show("Введите название группы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                string query = "INSERT INTO Groups (Title, FacultyId) VALUES (@Title, @FacultyId)";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Title", textBoxTitle.Text);
                    cmd.Parameters.AddWithValue("@FacultyId", FacultyId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Группа добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
