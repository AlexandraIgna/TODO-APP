using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TO_DO_APP
{ 
    public partial class AddTaskForm : MetroFramework.Forms.MetroForm
    {
        private string сonnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Александра\source\repos\TO-DO APP\TO-DO APP\TasksDb.mdf";
        public string TaskDescription { get; private set; }
        public string TaskCategory { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public bool TaskDone { get; private set; }

        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString() 
            {
                return Name;
            }
        }

        public AddTaskForm()
        {
            InitializeComponent();
            LoadCategories();
        }
        private void LoadCategories()
        {
            List<Category> categories = new List<Category>();

            using (SqlConnection connection = new SqlConnection(сonnectionString))
            {
                connection.Open();
                string query = "SELECT Id, Name FROM Categories"; 
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    categories.Add(new Category
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString()
                    });
                }
            }

            comboBoxCategories.DataSource = categories;
            comboBoxCategories.DisplayMember = "Name"; 
            comboBoxCategories.ValueMember = "Id"; 
        }

            private void btnAdd_Click(object sender, EventArgs e)
        {
            TaskDescription = txtDescription.Text;
            TaskCategory = (comboBoxCategories.SelectedItem as Category)?.Name;
            StartDate = dtpStartDate.Value;
            EndDate = dtpEndDate.Value;

                this.DialogResult = DialogResult.OK; 
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
            this.Close();
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            this.categoriesTableAdapter.Fill(this.tasksDbDataSet2.Categories);

        }


    }
}
