using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Globalization;

namespace TO_DO_APP
{
    public partial class Todoform : MetroFramework.Forms.MetroForm
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
        int nHeightEllipse
        );

        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Александра\source\repos\TO-DO APP\TO-DO APP\TasksDb.mdf";

        public static int _year, _month;
        public static int static_month, static_year;

        public DateTime ReminderDate { get; private set; }
        public bool IsReminderSet { get; private set; }
        public Todoform()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnTasks.Height;
            pnlNav.Top = btnTasks.Top;
            pnlNav.Left = btnTasks.Left;
            btnTasks.BackColor = Color.FromArgb(245, 245, 245);

            LoadTasks();
            LoadCategories();

        }

        //подключение к бд
        private void LoadTasks()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM [Table]";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                dataGridView1.Columns["Описание"].HeaderText = "Описание";
                dataGridView1.Columns["Категория"].HeaderText = "Категория";
                dataGridView1.Columns["Начало даты"].HeaderText = "Начало";
                dataGridView1.Columns["Конец даты"].HeaderText = "Конец";
                dataGridView1.Columns["Сделан"].HeaderText = "Сделан";

                dataGridView1.Columns["Id"].Visible = false;
            }
        }
        //навигация панели
        private void btnTasks_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTasks.Height;
            pnlNav.Top = btnTasks.Top;
            pnlNav.Left = btnTasks.Left;
            btnTasks.BackColor = Color.FromArgb(245, 245, 245);

            tabControl1.SelectedTab = tabTasks;
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnEvents.Height;
            pnlNav.Top = btnEvents.Top;
            btnEvents.BackColor = Color.FromArgb(245, 245, 245);

            tabControl1.SelectedTab = tabEvents;
        }

        

        private void btnCategory_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCategory.Height;
            pnlNav.Top = btnCategory.Top;
            btnCategory.BackColor = Color.FromArgb(245, 245, 245);

            tabControl1.SelectedTab = tabCategory;
        }

        private void btnTasks_Leave(object sender, EventArgs e)
        {
            btnTasks.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnEvents_Leave(object sender, EventArgs e)
        {
            btnEvents.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnCategory_Leave(object sender, EventArgs e)
        {
            btnCategory.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Добавление и удаление новой задачи
        private void AddTask(object sender, EventArgs e)
        {
            using (AddTaskForm addTaskForm = new AddTaskForm())
            {
                if (addTaskForm.ShowDialog() == DialogResult.OK)
                {
                    string description = addTaskForm.TaskDescription;
                    string category = addTaskForm.TaskCategory;
                    DateTime startDate = addTaskForm.StartDate;
                    DateTime endDate = addTaskForm.EndDate;
                    bool done = addTaskForm.TaskDone;

                    AddTask(description, category, startDate, endDate, done);
                }
            }
        }
        private void AddTask(string description, string category, DateTime startDate, DateTime endDate, bool done)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO [Table] ([Описание], [Категория], [Начало даты], [Конец даты], [Сделан]) " +
                               "VALUES (@Description, @Category, @StartDate, @EndDate, @Done)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Category", category);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);
                    command.Parameters.AddWithValue("@Done", done);
                    command.ExecuteNonQuery();
                }
            }

            LoadTasks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                int taskId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["Id"].Value); 

                DeleteTask(taskId);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите задачу для удаления.");
            }
        }

        private void DeleteTask(int taskId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM [Table] WHERE Id = @TaskId"; 

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaskId", taskId);
                    command.ExecuteNonQuery();
                }
            }

            LoadTasks(); 
        }
        
        //Календарь
        private void Form1_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);
        }
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            _month += 1;
            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            showDays(_month, _year);
        }

        private void btnPrev_Click_1(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            showDays(_month, _year);
        }
        private void showDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;

            string montName = new DateTimeFormatInfo().GetMonthName(month);
            lbMonth.Text = montName.ToUpper() + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int weekDay = (int)startOfTheMonth.DayOfWeek;
            for (int i = 0; i < weekDay; i++)
            {
                ucDays uc = new ucDays(""); 
                flowLayoutPanel1.Controls.Add(uc);
            }
            for (int i = 1; i <= daysInMonth; i++)
            {
                ucDays uc = new ucDays(i.ToString());
                flowLayoutPanel1.Controls.Add(uc);
            }
            static_month = month;
            static_year = year;
        }
        //Категории
        private void LoadCategories()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT [Id], [Name] FROM [Categories]";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                listBoxCategories.Items.Clear();
                while (reader.Read())
                {
                    listBoxCategories.Items.Add(new Category
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    });
                }
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();
            if (!string.IsNullOrEmpty(categoryName))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO [Categories] ([Name]) VALUES (@Name)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = categoryName;
                        command.ExecuteNonQuery();
                    }
                }
                LoadCategories();
                txtCategoryName.Clear();
            }
            else
            {
                MessageBox.Show("Введите название категории.");
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedItem != null)
            {
                Category selectedCategory = (Category)listBoxCategories.SelectedItem;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM [Categories] WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@Id", SqlDbType.Int).Value = selectedCategory.Id;
                        command.ExecuteNonQuery();
                    }
                }
                LoadCategories();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите категорию для удаления.");
            }
        }

        private void listBoxCategories_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedItem != null)
            {
                Category selectedCategory = (Category)listBoxCategories.SelectedItem;
                LoadTasksByCategory(selectedCategory.Name);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        

        private void LoadTasksByCategory(string category)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM [Table] WHERE [Категория] = @Category";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.Add("@Category", SqlDbType.NVarChar).Value = category;

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewCategory.DataSource = dataTable;

                dataGridViewCategory.Columns["Описание"].HeaderText = "Описание";
                dataGridViewCategory.Columns["Категория"].HeaderText = "Категория";
                dataGridViewCategory.Columns["Начало даты"].HeaderText = "Начало";
                dataGridViewCategory.Columns["Конец даты"].HeaderText = "Конец";
                dataGridViewCategory.Columns["Сделан"].HeaderText = "Сделан";
                dataGridViewCategory.Columns["Id"].Visible = false; 
            }
        }
        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
            
            public override string ToString()
            {
                return Name;
            }
        }
        // Поиск
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtSearch.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Table] WHERE [Описание] LIKE @searchString", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@searchString", "%" + searchString + "%");
                DataTable tasksTable = new DataTable();
                adapter.Fill(tasksTable);
                dataGridView1.DataSource = tasksTable;
            }
        
        }
    }
}
