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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2lab_kpo_tree
{
    public partial class MainForm : Form
    {
        string ConnectionString = @"Data Source=D0NEL;Initial Catalog=University;Integrated Security=True";
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            trv_Data.Nodes.Clear();
            using (var cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                string strSQL = @"SELECT id, Title FROM Faculties";
                var cmd = new SqlCommand(strSQL, cn);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var node = new TreeNode(dr["Title"].ToString(), 0, 0);
                        node.Tag = (int)dr["id"]; // ID факультета
                        node.ContextMenuStrip = facultyMenuStrip; // Контекстное меню
                        trv_Data.Nodes.Add(node);

                        LoadGroups((int)dr["id"], node);
                    }
                }
            }
        }


        void LoadGroups(int facultyId, TreeNode parent)
        {
            using (var cn = new SqlConnection())
            {
                cn.ConnectionString = ConnectionString;
                cn.Open();
                string strSQL = @"SELECT * FROM Groups G where G.Faculty_id = @facultyId";
                var cmd = new SqlCommand(strSQL, cn);

                cmd.Parameters.AddWithValue("@facultyId", facultyId);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var node = new TreeNode(dr["Title"].ToString(), 1, 1);
                        node.Tag = (int)dr["id"];
                        parent.Nodes.Add(node);
                        node.ContextMenuStrip = groupContextMenu;
                        LoadStudents((int)dr["id"], node); 
                    }
                }
            }
        }

        void LoadStudents(int group_id, TreeNode parent)
        {
            using (var cn = new SqlConnection())
            {
                cn.ConnectionString = ConnectionString;
                cn.Open();
                string strSQL = @"SELECT * FROM Students S where S.Group_id = @group_id";
                var cmd = new SqlCommand(strSQL, cn);

                cmd.Parameters.AddWithValue("@group_id", group_id);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var node = new TreeNode(dr["Name"].ToString() + " " + dr["Surname"].ToString(), 2, 2); 
                        node.Tag = (int)dr["id"];
                        parent.Nodes.Add(node);
                        node.ContextMenuStrip = studentСontextMenu; 
                    }
                }
            }
        }
        private void добавитьФакультетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new AddFaculty())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    btn_load.PerformClick(); // Обновляем дерево
                }
            }
        }
        private void изменитьФакультетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trv_Data.SelectedNode != null && trv_Data.SelectedNode.Parent == null) // Факультет
            {
                int facultyId = GetFacultyIdByName(trv_Data.SelectedNode.Text);
                using (var form = new UpdateFaculty(facultyId, trv_Data.SelectedNode.Text))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        btn_load.PerformClick(); // Обновляем дерево
                    }
                }
            }
        }
        private void удалитьФакультетToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (trv_Data.SelectedNode != null && trv_Data.SelectedNode.Parent == null) // Факультет
            {
                int facultyId = (int)trv_Data.SelectedNode.Tag; // Получаем ID факультета из тега выбранного узла

                if (MessageBox.Show("Вы уверены, что хотите удалить этот факультет?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();
                        // Удаляем студентов, если нужно (если у вас есть связь с группой):
                        string deleteStudentsQuery = "DELETE FROM Students WHERE Group_id IN (SELECT Id FROM Groups WHERE Faculty_id = @FacultyId)";
                        using (SqlCommand cmd3 = new SqlCommand(deleteStudentsQuery, conn))
                        {
                            cmd3.Parameters.AddWithValue("@FacultyId", facultyId);
                            cmd3.ExecuteNonQuery();
                        }

                        // Если хотите удалить также группы и студентов:
                        // Удаляем все группы, связанные с этим факультетом:
                        string deleteGroupsQuery = "DELETE FROM Groups WHERE Faculty_id = @FacultyId";
                        using (SqlCommand cmd2 = new SqlCommand(deleteGroupsQuery, conn))
                        {
                            cmd2.Parameters.AddWithValue("@FacultyId", facultyId);
                            cmd2.ExecuteNonQuery();
                        }

                        string query = "DELETE FROM Faculties WHERE Id = @Id"; // Удаляем факультет
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", facultyId);
                            cmd.ExecuteNonQuery();
                        }

                    }
                    MessageBox.Show("Факультет и все связанные данные удалены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_load.PerformClick(); // Обновляем дерево
                }
            }
        }



        private void изменитьГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_change_stdn_Click(object sender, EventArgs e)
        {

        }

        private void добавитьГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private int GetFacultyIdByName(string facultyName)
        {
            using (var cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                var cmd = new SqlCommand("SELECT Id FROM Faculties WHERE Title = @Title", cn);
                cmd.Parameters.AddWithValue("@Title", facultyName);
                return (int)cmd.ExecuteScalar();
            }
        }
        private bool FacultyHasGroups(int facultyId)
        {
            using (var cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                var cmd = new SqlCommand("SELECT COUNT(*) FROM Groups WHERE Faculty_id = @FacultyId", cn);
                cmd.Parameters.AddWithValue("@FacultyId", facultyId);

                var result = cmd.ExecuteScalar();
                return result != null && (int)result > 0;
            }
        }

        public void DeleteFaculty(int facultyId)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить этот факультет?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection("your_connection_string"))
                {
                    conn.Open();
                    string query = "DELETE FROM Faculties WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", facultyId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Факультет удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
