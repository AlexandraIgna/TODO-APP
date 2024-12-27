namespace TO_DO_APP
{
    partial class Todoform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Todoform));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTasks = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.btnPrev = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.lbMonth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel43 = new System.Windows.Forms.Panel();
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.tasksDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksDbDataSet = new TO_DO_APP.TasksDbDataSet();
            this.tasksDbDataSet1 = new TO_DO_APP.TasksDbDataSet1();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new TO_DO_APP.TasksDbDataSet1TableAdapters.TableTableAdapter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Controls.Add(this.btnEvents);
            this.panel1.Controls.Add(this.btnTasks);
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 634);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.BlueViolet;
            this.pnlNav.Location = new System.Drawing.Point(0, 150);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 5;
            // 
            // btnCategory
            // 
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCategory.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(0, 100);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(190, 50);
            this.btnCategory.TabIndex = 4;
            this.btnCategory.Text = "Категории";
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            this.btnCategory.Leave += new System.EventHandler(this.btnCategory_Leave);
            // 
            // btnEvents
            // 
            this.btnEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEvents.FlatAppearance.BorderSize = 0;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEvents.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnEvents.Image = ((System.Drawing.Image)(resources.GetObject("btnEvents.Image")));
            this.btnEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.Location = new System.Drawing.Point(0, 50);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(190, 50);
            this.btnEvents.TabIndex = 5;
            this.btnEvents.Text = "События";
            this.btnEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            this.btnEvents.Leave += new System.EventHandler(this.btnEvents_Leave);
            // 
            // btnTasks
            // 
            this.btnTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTasks.FlatAppearance.BorderSize = 0;
            this.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasks.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btnTasks.Image = ((System.Drawing.Image)(resources.GetObject("btnTasks.Image")));
            this.btnTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.Location = new System.Drawing.Point(0, 0);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(190, 50);
            this.btnTasks.TabIndex = 1;
            this.btnTasks.Text = "Задачи";
            this.btnTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            this.btnTasks.Leave += new System.EventHandler(this.btnTasks_Leave);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTasks);
            this.tabControl1.Controls.Add(this.tabEvents);
            this.tabControl1.Controls.Add(this.tabCategory);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(186, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 663);
            this.tabControl1.TabIndex = 5;
            // 
            // tabTasks
            // 
            this.tabTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.tabTasks.Controls.Add(this.btnDelete);
            this.tabTasks.Controls.Add(this.btnAdd);
            this.tabTasks.Controls.Add(this.dataGridView1);
            this.tabTasks.Location = new System.Drawing.Point(4, 25);
            this.tabTasks.Name = "tabTasks";
            this.tabTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabTasks.Size = new System.Drawing.Size(928, 634);
            this.tabTasks.TabIndex = 0;
            this.tabTasks.Text = "Задачи";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(840, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(749, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.AddTask);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridView1.Location = new System.Drawing.Point(6, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(928, 603);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tabEvents
            // 
            this.tabEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.tabEvents.Controls.Add(this.btnPrev);
            this.tabEvents.Controls.Add(this.btnNext);
            this.tabEvents.Controls.Add(this.lbMonth);
            this.tabEvents.Controls.Add(this.label7);
            this.tabEvents.Controls.Add(this.label6);
            this.tabEvents.Controls.Add(this.label5);
            this.tabEvents.Controls.Add(this.label4);
            this.tabEvents.Controls.Add(this.label3);
            this.tabEvents.Controls.Add(this.label2);
            this.tabEvents.Controls.Add(this.label1);
            this.tabEvents.Controls.Add(this.flowLayoutPanel1);
            this.tabEvents.Location = new System.Drawing.Point(4, 25);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Size = new System.Drawing.Size(928, 634);
            this.tabEvents.TabIndex = 1;
            this.tabEvents.Text = "События";
            // 
            // btnPrev
            // 
            this.btnPrev.Image = global::TO_DO_APP.Properties.Resources.free_icon_arrow_left_98474791;
            this.btnPrev.Location = new System.Drawing.Point(256, 23);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(30, 30);
            this.btnPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPrev.TabIndex = 17;
            this.btnPrev.TabStop = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click_1);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::TO_DO_APP.Properties.Resources.free_icon_arrow_right_15494543;
            this.btnNext.Location = new System.Drawing.Point(292, 23);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNext.TabIndex = 18;
            this.btnNext.TabStop = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMonth.Location = new System.Drawing.Point(22, 25);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(89, 28);
            this.lbMonth.TabIndex = 16;
            this.lbMonth.Text = "Месяц";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(156, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Вс";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(626, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Пт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(537, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Чт";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(438, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ср";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(723, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Сб";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(347, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Вт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(241, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Пн";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.panel43);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(111, 96);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(686, 406);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel43
            // 
            this.panel43.Location = new System.Drawing.Point(1, 1);
            this.panel43.Margin = new System.Windows.Forms.Padding(1);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(124, 79);
            this.panel43.TabIndex = 43;
            // 
            // tabCategory
            // 
            this.tabCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.tabCategory.Controls.Add(this.btnDeleteCategory);
            this.tabCategory.Controls.Add(this.btnAddCategory);
            this.tabCategory.Controls.Add(this.txtCategoryName);
            this.tabCategory.Controls.Add(this.listBoxCategories);
            this.tabCategory.Controls.Add(this.dataGridViewCategory);
            this.tabCategory.Location = new System.Drawing.Point(4, 25);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Size = new System.Drawing.Size(928, 634);
            this.tabCategory.TabIndex = 3;
            this.tabCategory.Text = "Категории";
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.btnDeleteCategory.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteCategory.Location = new System.Drawing.Point(471, 597);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(102, 34);
            this.btnDeleteCategory.TabIndex = 3;
            this.btnDeleteCategory.Text = "Удалить";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.btnAddCategory.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCategory.Location = new System.Drawing.Point(363, 597);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(102, 34);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Добавить";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCategoryName.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCategoryName.Location = new System.Drawing.Point(6, 597);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(351, 34);
            this.txtCategoryName.TabIndex = 1;
            this.txtCategoryName.Text = "Добавить категорию";
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.listBoxCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCategories.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxCategories.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 23;
            this.listBoxCategories.Location = new System.Drawing.Point(0, 0);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(925, 276);
            this.listBoxCategories.TabIndex = 0;
            this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.listBoxCategories_SelectedIndexChanged_1);
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.AllowDrop = true;
            this.dataGridViewCategory.AllowUserToAddRows = false;
            this.dataGridViewCategory.AllowUserToDeleteRows = false;
            this.dataGridViewCategory.AllowUserToResizeColumns = false;
            this.dataGridViewCategory.AllowUserToResizeRows = false;
            this.dataGridViewCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCategory.ColumnHeadersHeight = 29;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCategory.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCategory.Location = new System.Drawing.Point(0, 282);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCategory.RowHeadersWidth = 51;
            this.dataGridViewCategory.RowTemplate.Height = 24;
            this.dataGridViewCategory.Size = new System.Drawing.Size(928, 309);
            this.dataGridViewCategory.TabIndex = 4;
            // 
            // tasksDbDataSetBindingSource
            // 
            this.tasksDbDataSetBindingSource.DataSource = this.tasksDbDataSet;
            this.tasksDbDataSetBindingSource.Position = 0;
            // 
            // tasksDbDataSet
            // 
            this.tasksDbDataSet.DataSetName = "TasksDbDataSet";
            this.tasksDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tasksDbDataSet1
            // 
            this.tasksDbDataSet1.DataSetName = "TasksDbDataSet1";
            this.tasksDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.tasksDbDataSet1;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.Location = new System.Drawing.Point(932, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 22);
            this.txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(851, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Location = new System.Drawing.Point(188, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 26);
            this.panel2.TabIndex = 8;
            // 
            // Todoform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1122, 710);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Todoform";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "To-Do ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabEvents.ResumeLayout(false);
            this.tabEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabCategory.ResumeLayout(false);
            this.tabCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.TabPage tabTasks;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.TabPage tabCategory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource tasksDbDataSetBindingSource;
        private TasksDbDataSet tasksDbDataSet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.PictureBox btnNext;
        private System.Windows.Forms.PictureBox btnPrev;
        private TasksDbDataSet1 tasksDbDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private TasksDbDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private System.Windows.Forms.Panel panel2;
    }
}

