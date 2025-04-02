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
            trv_Data.ItemDrag += trv_Data_ItemDrag; // Начало перетаскивания
            trv_Data.DragEnter += trv_Data_DragEnter; // Проверка, можно ли сюда перетаскивать
            trv_Data.DragDrop += trv_Data_DragDrop; // Обработка завершения перетаскивания
            trv_Data.AllowDrop = true;

        }
        private void trv_Data_ItemDrag(object sender, ItemDragEventArgs e)
        {
            TreeNode draggedNode = (TreeNode)e.Item;

            if (draggedNode.ImageIndex == 2)
            {
                DoDragDrop(draggedNode, DragDropEffects.Move);
            }
        }


        private void trv_Data_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                TreeNode targetNode = trv_Data.GetNodeAt(trv_Data.PointToClient(new Point(e.X, e.Y)));
                if (targetNode != null && targetNode.ImageIndex == 1) // Если это группа
                {
                    e.Effect = DragDropEffects.Move;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private void trv_Data_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
            Point targetPoint = trv_Data.PointToClient(new Point(e.X, e.Y));
            TreeNode targetNode = trv_Data.GetNodeAt(targetPoint);

            if (targetNode == null)
            {
                MessageBox.Show("Не удалось определить целевой узел!");
                return;
            }

            if (draggedNode != null && targetNode.ImageIndex == 1)
            {

                // Обновление БД и дерева
                int newGroupId = (int)targetNode.Tag;
                int studentId = (int)draggedNode.Tag;

                using (SqlConnection cn = new SqlConnection(ConnectionString))
                {
                    cn.Open();
                    string query = "UPDATE Students SET Group_id = @NewGroup WHERE Id = @StudentId";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@NewGroup", newGroupId);
                        cmd.Parameters.AddWithValue("@StudentId", studentId);
                        cmd.ExecuteNonQuery();
                    }
                }

                draggedNode.Remove();
                targetNode.Nodes.Add(draggedNode);
                targetNode.Expand();
            }
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
                    // Получаем только что добавленный факультет
                    using (SqlConnection cn = new SqlConnection(ConnectionString))
                    {
                        cn.Open();
                        string query = "SELECT TOP 1 Id, Title FROM Faculties ORDER BY Id DESC";
                        using (SqlCommand cmd = new SqlCommand(query, cn))
                        {
                            using (SqlDataReader dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    int facultyId = (int)dr["Id"];
                                    string facultyName = dr["Title"].ToString();

                                    // Создаем новый узел факультета и добавляем его в дерево
                                    var facultyNode = new TreeNode(facultyName, 0, 0);
                                    facultyNode.Tag = facultyId;
                                    facultyNode.ContextMenuStrip = facultyMenuStrip;
                                    trv_Data.Nodes.Add(facultyNode);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void изменитьФакультетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trv_Data.SelectedNode != null && trv_Data.SelectedNode.Parent == null) // Факультет
            {
                int facultyId = (int)trv_Data.SelectedNode.Tag;
                using (var form = new ChangeFaculty(facultyId, trv_Data.SelectedNode.Text))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // Получаем обновленное название факультета
                        using (SqlConnection cn = new SqlConnection(ConnectionString))
                        {
                            cn.Open();
                            string query = "SELECT Title FROM Faculties WHERE Id = @FacultyId";
                            using (SqlCommand cmd = new SqlCommand(query, cn))
                            {
                                cmd.Parameters.AddWithValue("@FacultyId", facultyId);
                                using (SqlDataReader dr = cmd.ExecuteReader())
                                {
                                    if (dr.Read())
                                    {
                                        trv_Data.SelectedNode.Text = dr["Title"].ToString();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void удалитьФакультетToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (trv_Data.SelectedNode != null && trv_Data.SelectedNode.Parent == null) // Факультет
            {
                int facultyId = (int)trv_Data.SelectedNode.Tag;

                if (MessageBox.Show("Вы уверены, что хотите удалить этот факультет?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();

                        // Удаляем студентов, если они есть в группах этого факультета
                        string deleteStudentsQuery = "DELETE FROM Students WHERE Group_id IN (SELECT Id FROM Groups WHERE Faculty_id = @FacultyId)";
                        using (SqlCommand cmd1 = new SqlCommand(deleteStudentsQuery, conn))
                        {
                            cmd1.Parameters.AddWithValue("@FacultyId", facultyId);
                            cmd1.ExecuteNonQuery();
                        }

                        // Удаляем все группы факультета
                        string deleteGroupsQuery = "DELETE FROM Groups WHERE Faculty_id = @FacultyId";
                        using (SqlCommand cmd2 = new SqlCommand(deleteGroupsQuery, conn))
                        {
                            cmd2.Parameters.AddWithValue("@FacultyId", facultyId);
                            cmd2.ExecuteNonQuery();
                        }

                        // Удаляем сам факультет
                        string deleteFacultyQuery = "DELETE FROM Faculties WHERE Id = @FacultyId";
                        using (SqlCommand cmd3 = new SqlCommand(deleteFacultyQuery, conn))
                        {
                            cmd3.Parameters.AddWithValue("@FacultyId", facultyId);
                            cmd3.ExecuteNonQuery();
                        }
                    }

                    // Удаляем узел из дерева
                    trv_Data.SelectedNode.Remove();
                    MessageBox.Show("Факультет удалён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void добавитьГруппуToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (trv_Data.SelectedNode != null && trv_Data.SelectedNode.Parent == null) // Если выбран факультет
            {
                int facultyId = (int)trv_Data.SelectedNode.Tag;

                using (var form = new AddGroup(facultyId, ConnectionString))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // Получаем последнюю добавленную группу
                        using (SqlConnection cn = new SqlConnection(ConnectionString))
                        {
                            cn.Open();
                            string query = "SELECT TOP 1 Id, Title FROM Groups WHERE Faculty_id = @FacultyId ORDER BY Id DESC";
                            using (SqlCommand cmd = new SqlCommand(query, cn))
                            {
                                cmd.Parameters.AddWithValue("@FacultyId", facultyId);
                                using (SqlDataReader dr = cmd.ExecuteReader())
                                {
                                    if (dr.Read())
                                    {
                                        string groupName = dr["Title"].ToString();
                                        int groupId = (int)dr["Id"];

                                        // Создаем новый узел группы и добавляем в дерево
                                        var groupNode = new TreeNode(groupName, 1, 1);
                                        groupNode.Tag = groupId;
                                        groupNode.ContextMenuStrip = groupContextMenu;
                                        trv_Data.SelectedNode.Nodes.Add(groupNode);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите факультет, чтобы добавить группу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void изменитьГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trv_Data.SelectedNode == null)
            {
                MessageBox.Show("Выберите группу для изменения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int groupId = (int)trv_Data.SelectedNode.Tag;
            string groupName = trv_Data.SelectedNode.Text;

            using (var form = new ChangeGroup(groupId, groupName, ConnectionString))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Обновляем название группы в дереве
                    using (SqlConnection cn = new SqlConnection(ConnectionString))
                    {
                        cn.Open();
                        string query = "SELECT Title FROM Groups WHERE Id = @GroupId";
                        using (SqlCommand cmd = new SqlCommand(query, cn))
                        {
                            cmd.Parameters.AddWithValue("@GroupId", groupId);
                            using (SqlDataReader dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    trv_Data.SelectedNode.Text = dr["Title"].ToString();
                                }
                            }
                        }
                    }
                }
            }
        }
        private void удалитьгруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trv_Data.SelectedNode != null && trv_Data.SelectedNode.Parent != null) // Группа
            {
                int groupId = (int)trv_Data.SelectedNode.Tag;

                if (MessageBox.Show("Вы уверены, что хотите удалить эту группу?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();

                        // Удаляем студентов из группы
                        string deleteStudentsQuery = "DELETE FROM Students WHERE Group_id = @GroupId";
                        using (SqlCommand cmd1 = new SqlCommand(deleteStudentsQuery, conn))
                        {
                            cmd1.Parameters.AddWithValue("@GroupId", groupId);
                            cmd1.ExecuteNonQuery();
                        }

                        // Удаляем саму группу
                        string deleteGroupQuery = "DELETE FROM Groups WHERE Id = @GroupId";
                        using (SqlCommand cmd2 = new SqlCommand(deleteGroupQuery, conn))
                        {
                            cmd2.Parameters.AddWithValue("@GroupId", groupId);
                            cmd2.ExecuteNonQuery();
                        }
                    }

                    // Удаляем узел группы из дерева
                    trv_Data.SelectedNode.Remove();
                    MessageBox.Show("Группа удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void добавитьстудентаContextMenuStrip_Click(object sender, EventArgs e)
        {
            if (trv_Data.SelectedNode != null && trv_Data.SelectedNode.Parent != null) // Выбрана группа
            {
                int groupId = (int)trv_Data.SelectedNode.Tag;
                using (var form = new AddStudent(groupId, ConnectionString))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // Динамически добавляем нового студента в дерево
                        using (SqlConnection cn = new SqlConnection(ConnectionString))
                        {
                            cn.Open();
                            string query = "SELECT TOP 1 Id, Name, Surname FROM Students WHERE Group_id = @GroupId ORDER BY Id DESC";
                            using (SqlCommand cmd = new SqlCommand(query, cn))
                            {
                                cmd.Parameters.AddWithValue("@GroupId", groupId);
                                using (SqlDataReader dr = cmd.ExecuteReader())
                                {
                                    if (dr.Read())
                                    {
                                        string studentName = dr["Name"].ToString() + " " + dr["Surname"].ToString();
                                        int studentId = (int)dr["Id"];

                                        // Создаем новый узел студента и добавляем его к группе
                                        var studentNode = new TreeNode(studentName, 2, 2);
                                        studentNode.Tag = studentId;
                                        studentNode.ContextMenuStrip = studentСontextMenu;
                                        trv_Data.SelectedNode.Nodes.Add(studentNode);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void изменитьстудентаContextMenuStrip_Click(object sender, EventArgs e)
        {
            if (trv_Data.SelectedNode != null && trv_Data.SelectedNode.Parent != null) // Выбран студент
            {
                int studentId = (int)trv_Data.SelectedNode.Tag;
                string[] nameParts = trv_Data.SelectedNode.Text.Split(' ');
                string name = nameParts.Length > 0 ? nameParts[0] : "";
                string surname = nameParts.Length > 1 ? nameParts[1] : "";

                using (var form = new ChangeStudent(studentId, name, surname, ConnectionString))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // Обновляем текст узла без полной перезагрузки
                        using (SqlConnection cn = new SqlConnection(ConnectionString))
                        {
                            cn.Open();
                            string query = "SELECT Name, Surname FROM Students WHERE Id = @StudentId";
                            using (SqlCommand cmd = new SqlCommand(query, cn))
                            {
                                cmd.Parameters.AddWithValue("@StudentId", studentId);
                                using (SqlDataReader dr = cmd.ExecuteReader())
                                {
                                    if (dr.Read())
                                    {
                                        trv_Data.SelectedNode.Text = dr["Name"].ToString() + " " + dr["Surname"].ToString();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void удалитьстудентаContextMenuStrip_Click(object sender, EventArgs e)
        {
            if (trv_Data.SelectedNode != null && trv_Data.SelectedNode.Parent != null) // Выбран студент
            {
                int studentId = (int)trv_Data.SelectedNode.Tag;

                if (MessageBox.Show("Вы уверены, что хотите удалить этого студента?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (SqlConnection cn = new SqlConnection(ConnectionString))
                    {
                        cn.Open();
                        string query = "DELETE FROM Students WHERE Id = @StudentId";
                        using (SqlCommand cmd = new SqlCommand(query, cn))
                        {
                            cmd.Parameters.AddWithValue("@StudentId", studentId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Удаляем узел из дерева
                    trv_Data.SelectedNode.Remove();
                    MessageBox.Show("Студент удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        
    }
}
