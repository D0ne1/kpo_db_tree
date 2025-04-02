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
    public partial class ChangeGroup : Form
    {
        private string ConnectionString;
        private int GroupId;
        public ChangeGroup(int groupId, string groupName, string connectionString)
        {
            InitializeComponent();
            GroupId = groupId;
            ConnectionString = connectionString;
            txt_new_group_title.Text = groupName;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_new_group_title.Text))
            {
                MessageBox.Show("Название группы не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                string query = "UPDATE Groups SET Title = @Title WHERE Id = @GroupId";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Title", txt_new_group_title.Text);
                    cmd.Parameters.AddWithValue("@GroupId", GroupId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Группа обновлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
