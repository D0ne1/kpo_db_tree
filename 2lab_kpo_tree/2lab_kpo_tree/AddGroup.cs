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
        private readonly string _facultyId;
        private const string ConnectionString = @"Data Source=D0NEL;Initial Catalog=University;Integrated Security=True";
        public AddGroup(string facultyId)
        {
            InitializeComponent();
            _facultyId = facultyId;

            // Автоматически заполняем FacultyId и делаем его неизменяемым
            textBoxFacultyId.Text = _facultyId;
            textBoxFacultyId.ReadOnly = true;
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
            // Проверяем, что Title не пустой
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                return; // Просто выходим без сообщения
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    // Если Id не указан, делаем автоинкремент
                    string sqlQuery = string.IsNullOrEmpty(textBoxId.Text)
                        ? "INSERT INTO Groups (Faculty_id, Title) VALUES (@facultyId, @title)"
                        : "INSERT INTO Groups (Id, Faculty_id, Title) VALUES (@id, @facultyId, @title)";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                    {
                        if (!string.IsNullOrEmpty(textBoxId.Text))
                        {
                            cmd.Parameters.AddWithValue("@id", int.Parse(textBoxId.Text));
                        }

                        cmd.Parameters.AddWithValue("@facultyId", int.Parse(_facultyId));
                        cmd.Parameters.AddWithValue("@title", textBoxTitle.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                this.DialogResult = DialogResult.None; // Оставляем форму открытой при ошибке
            }
        }
        // Валидация ввода для ID (только цифры)
        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Валидация ввода для Title (можно добавить специфичные проверки)
        private void textBoxTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Пример: запрет специальных символов
            if (e.KeyChar == '\'' || e.KeyChar == '"' || e.KeyChar == ';')
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
