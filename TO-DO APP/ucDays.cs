using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TO_DO_APP
{
    public partial class ucDays : UserControl
    {
        string _day, date, weekday;
        public static string static_day;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Александра\source\repos\TO-DO APP\TO-DO APP\TasksDb.mdf";

        private void panel1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                this.BackColor = Color.FromArgb(255, 150, 79);
            }
            else
            {
                checkBox1.Checked = false;
                this.BackColor = Color.White;
            }

            static_day = label1.Text;
            timer1.Start();
            string selectedDate = $"{Todoform.static_month}/{static_day}/{Todoform.static_year}";
            EditEventForm eventsListForm = new EditEventForm(selectedDate);
            eventsListForm.ShowDialog();
        }

        public ucDays(string day)
        {
            InitializeComponent();
            _day = day;
            label1.Text = day;
            checkBox1.Hide();
            date = Todoform._month + "/" + _day + "/" + Todoform._year;
        }

        private void sundays()
        {
            try
            {
                DateTime day = DateTime.Parse(date);
                weekday = day.ToString("ddd");
                if (weekday == "Sun")
                {
                    label1.ForeColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    label1.ForeColor = Color.FromArgb(64, 64, 64);
                }
            }
            catch (Exception) { }
        }

        private void ucDays_Load(object sender, EventArgs e)
        {
            sundays();
        }

        private void displayEvent()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string sql = "SELECT * FROM tbl_calendar WHERE date = @date";
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@date", $"{Todoform.static_month}/{ucDays.static_day}/{Todoform.static_year}");
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
                {
                    lbevent.Text = reader["event"].ToString();
                }
            reader.Dispose();
            cmd.Dispose();
            connection.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
        
    }
}
