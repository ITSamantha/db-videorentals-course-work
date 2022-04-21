namespace BD_course_work
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mainControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ordersPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.ownersTable = new System.Windows.Forms.DataGridView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.producersTable = new System.Windows.Forms.DataGridView();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.studiosTable = new System.Windows.Forms.DataGridView();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.countriesTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.Query = new System.Windows.Forms.Button();
            this.Excel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.countriesB = new System.Windows.Forms.Button();
            this.studiosB = new System.Windows.Forms.Button();
            this.producersB = new System.Windows.Forms.Button();
            this.ownersB = new System.Windows.Forms.Button();
            this.servicesB = new System.Windows.Forms.Button();
            this.proptypeB = new System.Windows.Forms.Button();
            this.districtB = new System.Windows.Forms.Button();
            this.filmsB = new System.Windows.Forms.Button();
            this.cassettesB = new System.Windows.Forms.Button();
            this.ordersB = new System.Windows.Forms.Button();
            this.videorentalB = new System.Windows.Forms.Button();
            this.tables = new System.Windows.Forms.Button();
            this.servicesTable = new System.Windows.Forms.DataGridView();
            this.propertyTable = new System.Windows.Forms.DataGridView();
            this.districtsTable = new System.Windows.Forms.DataGridView();
            this.filmsTable = new System.Windows.Forms.DataGridView();
            this.cassettesTable = new System.Windows.Forms.DataGridView();
            this.videoTable = new System.Windows.Forms.DataGridView();
            this.addCountry = new System.Windows.Forms.Button();
            this.deleteCountry = new System.Windows.Forms.Button();
            this.mainControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownersTable)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producersTable)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studiosTable)).BeginInit();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countriesTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cassettesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainControl
            // 
            this.mainControl.Controls.Add(this.tabPage1);
            this.mainControl.Controls.Add(this.ordersPage);
            this.mainControl.Controls.Add(this.tabPage2);
            this.mainControl.Controls.Add(this.tabPage3);
            this.mainControl.Controls.Add(this.tabPage4);
            this.mainControl.Controls.Add(this.tabPage5);
            this.mainControl.Controls.Add(this.tabPage6);
            this.mainControl.Controls.Add(this.tabPage7);
            this.mainControl.Controls.Add(this.tabPage8);
            this.mainControl.Controls.Add(this.tabPage9);
            this.mainControl.Controls.Add(this.tabPage10);
            this.mainControl.Location = new System.Drawing.Point(269, 70);
            this.mainControl.Name = "mainControl";
            this.mainControl.SelectedIndex = 0;
            this.mainControl.Size = new System.Drawing.Size(931, 610);
            this.mainControl.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.videoTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(923, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Видеопрокат";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ordersPage
            // 
            this.ordersPage.Location = new System.Drawing.Point(4, 22);
            this.ordersPage.Name = "ordersPage";
            this.ordersPage.Padding = new System.Windows.Forms.Padding(3);
            this.ordersPage.Size = new System.Drawing.Size(923, 523);
            this.ordersPage.TabIndex = 1;
            this.ordersPage.Text = "Сделки";
            this.ordersPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cassettesTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(923, 523);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Кассеты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.filmsTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(923, 523);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Фильмы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.districtsTable);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(923, 523);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Районы";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.propertyTable);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(923, 523);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Тип собств.";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.servicesTable);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(923, 523);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Услуги";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.ownersTable);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(923, 523);
            this.tabPage7.TabIndex = 7;
            this.tabPage7.Text = "Хозяины";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // ownersTable
            // 
            this.ownersTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ownersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownersTable.Location = new System.Drawing.Point(21, 55);
            this.ownersTable.Name = "ownersTable";
            this.ownersTable.Size = new System.Drawing.Size(880, 475);
            this.ownersTable.TabIndex = 3;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.producersTable);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(923, 523);
            this.tabPage8.TabIndex = 8;
            this.tabPage8.Text = "Режиссеры";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // producersTable
            // 
            this.producersTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.producersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.producersTable.Location = new System.Drawing.Point(21, 55);
            this.producersTable.Name = "producersTable";
            this.producersTable.Size = new System.Drawing.Size(880, 475);
            this.producersTable.TabIndex = 2;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.studiosTable);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(923, 584);
            this.tabPage9.TabIndex = 9;
            this.tabPage9.Text = "Студии";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // studiosTable
            // 
            this.studiosTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studiosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studiosTable.Location = new System.Drawing.Point(21, 55);
            this.studiosTable.Name = "studiosTable";
            this.studiosTable.Size = new System.Drawing.Size(880, 475);
            this.studiosTable.TabIndex = 1;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.deleteCountry);
            this.tabPage10.Controls.Add(this.addCountry);
            this.tabPage10.Controls.Add(this.countriesTable);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(923, 584);
            this.tabPage10.TabIndex = 10;
            this.tabPage10.Text = "Страны";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // countriesTable
            // 
            this.countriesTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countriesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countriesTable.Location = new System.Drawing.Point(21, 47);
            this.countriesTable.Name = "countriesTable";
            this.countriesTable.Size = new System.Drawing.Size(883, 519);
            this.countriesTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("AnastasiaScript", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1200, 70);
            this.label1.TabIndex = 19;
            this.label1.Text = "Видеопрокаты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.Query);
            this.panel2.Controls.Add(this.Excel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 610);
            this.panel2.TabIndex = 20;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.Location = new System.Drawing.Point(0, 555);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(270, 55);
            this.Exit.TabIndex = 21;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Query
            // 
            this.Query.BackColor = System.Drawing.Color.Transparent;
            this.Query.Dock = System.Windows.Forms.DockStyle.Top;
            this.Query.FlatAppearance.BorderSize = 0;
            this.Query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Query.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Query.Location = new System.Drawing.Point(0, 491);
            this.Query.Name = "Query";
            this.Query.Size = new System.Drawing.Size(270, 55);
            this.Query.TabIndex = 19;
            this.Query.Text = "Запросы";
            this.Query.UseVisualStyleBackColor = false;
            // 
            // Excel
            // 
            this.Excel.BackColor = System.Drawing.Color.Transparent;
            this.Excel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Excel.FlatAppearance.BorderSize = 0;
            this.Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Excel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Excel.Location = new System.Drawing.Point(0, 436);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(270, 55);
            this.Excel.TabIndex = 18;
            this.Excel.Text = "Отчеты";
            this.Excel.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.countriesB);
            this.panel1.Controls.Add(this.studiosB);
            this.panel1.Controls.Add(this.producersB);
            this.panel1.Controls.Add(this.ownersB);
            this.panel1.Controls.Add(this.servicesB);
            this.panel1.Controls.Add(this.proptypeB);
            this.panel1.Controls.Add(this.districtB);
            this.panel1.Controls.Add(this.filmsB);
            this.panel1.Controls.Add(this.cassettesB);
            this.panel1.Controls.Add(this.ordersB);
            this.panel1.Controls.Add(this.videorentalB);
            this.panel1.Controls.Add(this.tables);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(270, 436);
            this.panel1.MinimumSize = new System.Drawing.Size(270, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 436);
            this.panel1.TabIndex = 17;
            // 
            // countriesB
            // 
            this.countriesB.BackColor = System.Drawing.Color.Transparent;
            this.countriesB.Dock = System.Windows.Forms.DockStyle.Top;
            this.countriesB.FlatAppearance.BorderSize = 0;
            this.countriesB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countriesB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countriesB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.countriesB.Location = new System.Drawing.Point(0, 393);
            this.countriesB.Name = "countriesB";
            this.countriesB.Size = new System.Drawing.Size(270, 38);
            this.countriesB.TabIndex = 23;
            this.countriesB.Text = "Страны";
            this.countriesB.UseVisualStyleBackColor = false;
            this.countriesB.Click += new System.EventHandler(this.countriesB_Click);
            // 
            // studiosB
            // 
            this.studiosB.BackColor = System.Drawing.Color.Transparent;
            this.studiosB.Dock = System.Windows.Forms.DockStyle.Top;
            this.studiosB.FlatAppearance.BorderSize = 0;
            this.studiosB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studiosB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studiosB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studiosB.Location = new System.Drawing.Point(0, 359);
            this.studiosB.Name = "studiosB";
            this.studiosB.Size = new System.Drawing.Size(270, 34);
            this.studiosB.TabIndex = 22;
            this.studiosB.Text = "Студии";
            this.studiosB.UseVisualStyleBackColor = false;
            this.studiosB.Click += new System.EventHandler(this.studiosB_Click);
            // 
            // producersB
            // 
            this.producersB.BackColor = System.Drawing.Color.Transparent;
            this.producersB.Dock = System.Windows.Forms.DockStyle.Top;
            this.producersB.FlatAppearance.BorderSize = 0;
            this.producersB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.producersB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.producersB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.producersB.Location = new System.Drawing.Point(0, 327);
            this.producersB.Name = "producersB";
            this.producersB.Size = new System.Drawing.Size(270, 32);
            this.producersB.TabIndex = 21;
            this.producersB.Text = "Режиссеры";
            this.producersB.UseVisualStyleBackColor = false;
            this.producersB.Click += new System.EventHandler(this.producersB_Click);
            // 
            // ownersB
            // 
            this.ownersB.BackColor = System.Drawing.Color.Transparent;
            this.ownersB.Dock = System.Windows.Forms.DockStyle.Top;
            this.ownersB.FlatAppearance.BorderSize = 0;
            this.ownersB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ownersB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownersB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ownersB.Location = new System.Drawing.Point(0, 293);
            this.ownersB.Name = "ownersB";
            this.ownersB.Size = new System.Drawing.Size(270, 34);
            this.ownersB.TabIndex = 20;
            this.ownersB.Text = "Хозяины видеопрокатов";
            this.ownersB.UseVisualStyleBackColor = false;
            this.ownersB.Click += new System.EventHandler(this.ownersB_Click);
            // 
            // servicesB
            // 
            this.servicesB.BackColor = System.Drawing.Color.Transparent;
            this.servicesB.Dock = System.Windows.Forms.DockStyle.Top;
            this.servicesB.FlatAppearance.BorderSize = 0;
            this.servicesB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicesB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.servicesB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.servicesB.Location = new System.Drawing.Point(0, 259);
            this.servicesB.Name = "servicesB";
            this.servicesB.Size = new System.Drawing.Size(270, 34);
            this.servicesB.TabIndex = 19;
            this.servicesB.Text = "Услуги";
            this.servicesB.UseVisualStyleBackColor = false;
            this.servicesB.Click += new System.EventHandler(this.servicesB_Click);
            // 
            // proptypeB
            // 
            this.proptypeB.BackColor = System.Drawing.Color.Transparent;
            this.proptypeB.Dock = System.Windows.Forms.DockStyle.Top;
            this.proptypeB.FlatAppearance.BorderSize = 0;
            this.proptypeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proptypeB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proptypeB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.proptypeB.Location = new System.Drawing.Point(0, 225);
            this.proptypeB.Name = "proptypeB";
            this.proptypeB.Size = new System.Drawing.Size(270, 34);
            this.proptypeB.TabIndex = 18;
            this.proptypeB.Text = "Типы собственности";
            this.proptypeB.UseVisualStyleBackColor = false;
            this.proptypeB.Click += new System.EventHandler(this.proptypeB_Click);
            // 
            // districtB
            // 
            this.districtB.BackColor = System.Drawing.Color.Transparent;
            this.districtB.Dock = System.Windows.Forms.DockStyle.Top;
            this.districtB.FlatAppearance.BorderSize = 0;
            this.districtB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.districtB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.districtB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.districtB.Location = new System.Drawing.Point(0, 191);
            this.districtB.Name = "districtB";
            this.districtB.Size = new System.Drawing.Size(270, 34);
            this.districtB.TabIndex = 17;
            this.districtB.Text = "Районы";
            this.districtB.UseVisualStyleBackColor = false;
            this.districtB.Click += new System.EventHandler(this.districtB_Click);
            // 
            // filmsB
            // 
            this.filmsB.BackColor = System.Drawing.Color.Transparent;
            this.filmsB.Dock = System.Windows.Forms.DockStyle.Top;
            this.filmsB.FlatAppearance.BorderSize = 0;
            this.filmsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filmsB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filmsB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filmsB.Location = new System.Drawing.Point(0, 157);
            this.filmsB.Name = "filmsB";
            this.filmsB.Size = new System.Drawing.Size(270, 34);
            this.filmsB.TabIndex = 16;
            this.filmsB.Text = "Фильмы";
            this.filmsB.UseVisualStyleBackColor = false;
            this.filmsB.Click += new System.EventHandler(this.filmsB_Click);
            // 
            // cassettesB
            // 
            this.cassettesB.BackColor = System.Drawing.Color.Transparent;
            this.cassettesB.Dock = System.Windows.Forms.DockStyle.Top;
            this.cassettesB.FlatAppearance.BorderSize = 0;
            this.cassettesB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cassettesB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cassettesB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cassettesB.Location = new System.Drawing.Point(0, 123);
            this.cassettesB.Name = "cassettesB";
            this.cassettesB.Size = new System.Drawing.Size(270, 34);
            this.cassettesB.TabIndex = 15;
            this.cassettesB.Text = "Кассеты";
            this.cassettesB.UseVisualStyleBackColor = false;
            this.cassettesB.Click += new System.EventHandler(this.cassettesB_Click);
            // 
            // ordersB
            // 
            this.ordersB.BackColor = System.Drawing.Color.Transparent;
            this.ordersB.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordersB.FlatAppearance.BorderSize = 0;
            this.ordersB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ordersB.Location = new System.Drawing.Point(0, 89);
            this.ordersB.Name = "ordersB";
            this.ordersB.Size = new System.Drawing.Size(270, 34);
            this.ordersB.TabIndex = 14;
            this.ordersB.Text = "Сделки";
            this.ordersB.UseVisualStyleBackColor = false;
            // 
            // videorentalB
            // 
            this.videorentalB.BackColor = System.Drawing.Color.Transparent;
            this.videorentalB.Dock = System.Windows.Forms.DockStyle.Top;
            this.videorentalB.FlatAppearance.BorderSize = 0;
            this.videorentalB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videorentalB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.videorentalB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.videorentalB.Location = new System.Drawing.Point(0, 55);
            this.videorentalB.Name = "videorentalB";
            this.videorentalB.Size = new System.Drawing.Size(270, 34);
            this.videorentalB.TabIndex = 13;
            this.videorentalB.Text = "Видеопрокаты";
            this.videorentalB.UseVisualStyleBackColor = false;
            this.videorentalB.Click += new System.EventHandler(this.videorentalB_Click);
            // 
            // tables
            // 
            this.tables.BackColor = System.Drawing.Color.Transparent;
            this.tables.Dock = System.Windows.Forms.DockStyle.Top;
            this.tables.FlatAppearance.BorderSize = 0;
            this.tables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tables.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tables.Image = global::BD_course_work.Properties.Resources.expand;
            this.tables.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tables.Location = new System.Drawing.Point(0, 0);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(270, 55);
            this.tables.TabIndex = 12;
            this.tables.Text = "Таблицы";
            this.tables.UseVisualStyleBackColor = false;
            this.tables.Click += new System.EventHandler(this.tables_Click);
            // 
            // servicesTable
            // 
            this.servicesTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.servicesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesTable.Location = new System.Drawing.Point(21, 55);
            this.servicesTable.Name = "servicesTable";
            this.servicesTable.Size = new System.Drawing.Size(880, 475);
            this.servicesTable.TabIndex = 4;
            // 
            // propertyTable
            // 
            this.propertyTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.propertyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertyTable.Location = new System.Drawing.Point(21, 55);
            this.propertyTable.Name = "propertyTable";
            this.propertyTable.Size = new System.Drawing.Size(880, 475);
            this.propertyTable.TabIndex = 5;
            // 
            // districtsTable
            // 
            this.districtsTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.districtsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.districtsTable.Location = new System.Drawing.Point(21, 55);
            this.districtsTable.Name = "districtsTable";
            this.districtsTable.Size = new System.Drawing.Size(880, 475);
            this.districtsTable.TabIndex = 6;
            // 
            // filmsTable
            // 
            this.filmsTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filmsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmsTable.Location = new System.Drawing.Point(21, 55);
            this.filmsTable.Name = "filmsTable";
            this.filmsTable.Size = new System.Drawing.Size(880, 475);
            this.filmsTable.TabIndex = 7;
            // 
            // cassettesTable
            // 
            this.cassettesTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cassettesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cassettesTable.Location = new System.Drawing.Point(21, 55);
            this.cassettesTable.Name = "cassettesTable";
            this.cassettesTable.Size = new System.Drawing.Size(880, 475);
            this.cassettesTable.TabIndex = 8;
            // 
            // videoTable
            // 
            this.videoTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.videoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.videoTable.Location = new System.Drawing.Point(18, 33);
            this.videoTable.Name = "videoTable";
            this.videoTable.Size = new System.Drawing.Size(880, 475);
            this.videoTable.TabIndex = 9;
            // 
            // addCountry
            // 
            this.addCountry.BackColor = System.Drawing.Color.White;
            this.addCountry.FlatAppearance.BorderSize = 0;
            this.addCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCountry.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCountry.Image = ((System.Drawing.Image)(resources.GetObject("addCountry.Image")));
            this.addCountry.Location = new System.Drawing.Point(860, 3);
            this.addCountry.Name = "addCountry";
            this.addCountry.Size = new System.Drawing.Size(44, 38);
            this.addCountry.TabIndex = 2;
            this.addCountry.UseVisualStyleBackColor = false;
            // 
            // deleteCountry
            // 
            this.deleteCountry.BackColor = System.Drawing.Color.White;
            this.deleteCountry.FlatAppearance.BorderSize = 0;
            this.deleteCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCountry.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteCountry.Image = ((System.Drawing.Image)(resources.GetObject("deleteCountry.Image")));
            this.deleteCountry.Location = new System.Drawing.Point(810, 3);
            this.deleteCountry.Name = "deleteCountry";
            this.deleteCountry.Size = new System.Drawing.Size(44, 38);
            this.deleteCountry.TabIndex = 3;
            this.deleteCountry.UseVisualStyleBackColor = false;
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1200, 680);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1200, 680);
            this.MinimumSize = new System.Drawing.Size(1200, 680);
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учета деятельности видеопрокатов";
            this.mainControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ownersTable)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.producersTable)).EndInit();
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studiosTable)).EndInit();
            this.tabPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countriesTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.servicesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.districtsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cassettesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl mainControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage ordersPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Query;
        private System.Windows.Forms.Button Excel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button countriesB;
        private System.Windows.Forms.Button studiosB;
        private System.Windows.Forms.Button producersB;
        private System.Windows.Forms.Button ownersB;
        private System.Windows.Forms.Button servicesB;
        private System.Windows.Forms.Button proptypeB;
        private System.Windows.Forms.Button districtB;
        private System.Windows.Forms.Button filmsB;
        private System.Windows.Forms.Button cassettesB;
        private System.Windows.Forms.Button ordersB;
        private System.Windows.Forms.Button videorentalB;
        private System.Windows.Forms.Button tables;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        public System.Windows.Forms.DataGridView countriesTable;
        public System.Windows.Forms.DataGridView studiosTable;
        public System.Windows.Forms.DataGridView producersTable;
        public System.Windows.Forms.DataGridView ownersTable;
        public System.Windows.Forms.DataGridView servicesTable;
        public System.Windows.Forms.DataGridView propertyTable;
        public System.Windows.Forms.DataGridView districtsTable;
        public System.Windows.Forms.DataGridView filmsTable;
        public System.Windows.Forms.DataGridView cassettesTable;
        public System.Windows.Forms.DataGridView videoTable;
        private System.Windows.Forms.Button addCountry;
        private System.Windows.Forms.Button deleteCountry;
    }
}

