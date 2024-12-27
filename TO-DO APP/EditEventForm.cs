using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TO_DO_APP
{
    public partial class EditEventForm : MetroFramework.Forms.MetroForm
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Александра\source\repos\TO-DO APP\TO-DO APP\TasksDb.mdf";
        private string _date;

        public EditEventForm(string date)
        {
            InitializeComponent();
            _date = date;
            LoadEvents();
        }
        private void LoadEvents()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM tbl_calendar WHERE date = @date";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@date", _date);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string eventDescription = reader["event"].ToString();
                    listBoxEvents.Items.Add(eventDescription);
                }
                reader.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newEventDescription = txtNewEvent.Text;
            if (!string.IsNullOrWhiteSpace(newEventDescription))
            {
                AddEvent(newEventDescription);
                listBoxEvents.Items.Add(newEventDescription);
                txtNewEvent.Clear();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите описание события.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItem != null)
            {
                string selectedEvent = listBoxEvents.SelectedItem.ToString();
                DeleteEvent(selectedEvent);
                listBoxEvents.Items.Remove(selectedEvent);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите событие для удаления.");
            }
        }
        private void AddEvent(string eventDescription)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO tbl_calendar (event, date) VALUES (@Event, @Date)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Event", eventDescription);
                    command.Parameters.AddWithValue("@Date", _date);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void DeleteEvent(string eventDescription)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM tbl_calendar WHERE event = @Event AND date = @Date";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Event", eventDescription);
                    command.Parameters.AddWithValue("@Date", _date);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void EditEventForm_Load(object sender, EventArgs e)
        {
            txtdate.Text = Todoform.static_month + "/" + ucDays.static_day + "/" + Todoform.static_year;
        }

    }
}
