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
    public partial class AddStudent : Form
    {
        private string ConnectionString;
        private int GroupId;    
        public AddStudent(int groupId, string connectionString)
        {
            InitializeComponent();
            this.GroupId = groupId;
            this.ConnectionString = connectionString;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Student_Name.Text) || string.IsNullOrWhiteSpace(txt_Student_Surname.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                string query = "INSERT INTO Students (Name, Surname, Group_id) VALUES (@Name, @Surname, @GroupId)";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Name", txt_Student_Name.Text);
                    cmd.Parameters.AddWithValue("@Surname", txt_Student_Surname.Text);
                    cmd.Parameters.AddWithValue("@GroupId", GroupId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Студент добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
