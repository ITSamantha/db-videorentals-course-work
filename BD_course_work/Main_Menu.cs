using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_course_work
{
    public partial class Main_Menu : Form
    {

        bool isCollapsed = true;
        
        public string connectionStringDB= "Server = localhost; Port = 5432;UserId = postgres; Password =01dr10kv; Database = Video_Rentals; ";

        public DataTable dt;

        public string strAmount = "Количество полей:";

        enum Pages
        {
            VideoRental=0,
            Orders,
            Cassettes,
            Films,
            Districts,
            Property,
            Services,
            Owners,
            Producers,
            Studios,
            Countries,
            Quality,
            Images,
            ServPrice
        }

        public Main_Menu()
        {
            InitializeComponent();

            Form_Initialization();

            ControllerForDB.Connection(connectionStringDB);//Тест соединения
            
        }

        private void Close_App_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        public void Form_Initialization()
        {
            //label1.BackColor=Color.FromArgb(30,40,79);

            Instruments.SetRoundedShape(Excel, Instruments.radius);

            Instruments.SetRoundedShape(tables, Instruments.radius);

            Instruments.SetRoundedShape(Query, Instruments.radius);

            Instruments.SetRoundedShape(Exit, Instruments.radius);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tables_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                tables.Image = Image.FromFile(Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 24) + "images\\collapse.png");

                panel1.Height += 30;

                if (panel1.Size == panel1.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                tables.Image = Image.FromFile(Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 24) + "images\\expand.png");

                panel1.Height -= 30;

                if (panel1.Size == panel1.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }
        
        //Заполнение таблиц данными SELECT-методы

        private void button36_Click(object sender, EventArgs e)//Таблица "Услуги и цены"
        {
            if (!label15.Text.Equals(strAmount)) { label15.Text = strAmount; }

            mainControl.SelectedIndex = (int)Pages.ServPrice;

            dt = ControllerForDB.selectAllFromMainTables("services_prices");
            
            if (dt != null)
            {
                servpriceTable.DataSource = dt;

                servpriceTable.Columns[0].HeaderText = "ID";

                servpriceTable.Columns[1].HeaderText = "Видеопрокат";

                servpriceTable.Columns[2].HeaderText = "Услуга";

                servpriceTable.Columns[3].HeaderText = "Цена";
            }
            
            label15.Text += ControllerForDB.amount;
        }

        private void button35_Click(object sender, EventArgs e)//Таблица "Картинки"
        {
            if (!label14.Text.Equals(strAmount)) { label14.Text = strAmount; }

            mainControl.SelectedIndex = (int)Pages.Images;

            dt = ControllerForDB.selectAllFromTablesDirectories("cassette_photo");

            if (dt != null)
            {
                imagesTable.DataSource = dt;

                imagesTable.Columns[0].HeaderText = "ID";

                imagesTable.Columns[1].HeaderText = "Фото";
            }

            label14.Text += ControllerForDB.amount;
        }

        private void button34_Click(object sender, EventArgs e)//Таблица "Качество кассеты"
        {
            if (!label13.Text.Equals(strAmount)) { label13.Text = strAmount; }

            mainControl.SelectedIndex = (int)Pages.Quality;

            dt = ControllerForDB.selectAllFromTablesDirectories("cassette_quality");

            if (dt != null)
            {
                qualityTable.DataSource = dt;

                qualityTable.Columns[0].HeaderText = "ID";

                qualityTable.Columns[1].HeaderText = "Качество";
            }

            label13.Text += ControllerForDB.amount;
        }
        
        private void countriesB_Click(object sender, EventArgs e)//Таблица "Страны"
        {
            if (!label2.Text.Equals(strAmount)) { label2.Text = strAmount; }

            mainControl.SelectedIndex = (int)Pages.Countries;

            dt= ControllerForDB.selectAllFromTablesDirectories("countries");

            if (dt != null)
            {
                countriesTable.DataSource = dt;

                countriesTable.Columns[0].HeaderText = "ID";

                countriesTable.Columns[1].HeaderText = "Страна";
            }

            label2.Text += ControllerForDB.amount;
        }

        private void studiosB_Click(object sender, EventArgs e)//Таблица "Студии"
        {
            if (!label3.Text.Equals(strAmount)) { label3.Text = strAmount; }

            mainControl.SelectedIndex = (int)Pages.Studios;

            dt = ControllerForDB.selectAllFromMainTables("studios");

            if (dt != null)
            {
                studiosTable.DataSource = dt;

                studiosTable.Columns[0].HeaderText = "ID";

                studiosTable.Columns[1].HeaderText = "Студия";

                studiosTable.Columns[2].HeaderText = "Страна";
            }

            label3.Text += ControllerForDB.amount;
        }

        private void producersB_Click(object sender, EventArgs e)//Таблица "Режиссеры"
        {
            if (!label4.Text.Equals(strAmount)) { label4.Text = strAmount; }

            mainControl.SelectedIndex = (int)Pages.Producers;

            dt = ControllerForDB.selectAllFromTablesDirectories("producers");

            if (dt != null)
            {
                producersTable.DataSource = dt;

                producersTable.Columns[0].HeaderText = "ID";

                producersTable.Columns[1].HeaderText = "Имя";

                producersTable.Columns[2].HeaderText = "Фамилия";

                producersTable.Columns[3].HeaderText = "Отчество";
            }

            label4.Text += ControllerForDB.amount;
        }

        private void ownersB_Click(object sender, EventArgs e)//Таблица"Хозяины"
        {
            if (!label5.Text.Equals(strAmount)) { label5.Text = strAmount; }

            mainControl.SelectedIndex = (int)Pages.Owners;

            dt = ControllerForDB.selectAllFromTablesDirectories("owners");

            if (dt != null)
            {
                ownersTable.DataSource = dt;

                ownersTable.Columns[0].HeaderText = "ID";

                ownersTable.Columns[1].HeaderText = "Имя";

                ownersTable.Columns[2].HeaderText = "Фамилия";

                ownersTable.Columns[3].HeaderText = "Отчество";
            }

            label5.Text += ControllerForDB.amount;
        }

        private void servicesB_Click(object sender, EventArgs e)//Таблица "Услуги"
        {
            if (!label6.Text.Equals(strAmount)) { label6.Text = strAmount; }

            mainControl.SelectedIndex = (int)Pages.Services;

            dt = ControllerForDB.selectAllFromTablesDirectories("services");

            if (dt != null)
            {
                servicesTable.DataSource = dt;

                servicesTable.Columns[0].HeaderText = "ID";

                servicesTable.Columns[1].HeaderText = "Услуга";
            }

            label6.Text += ControllerForDB.amount;
        }

        private void proptypeB_Click(object sender, EventArgs e)//Таблица "Тип_собственности"
        {
            if (!label7.Text.Equals(strAmount)) { label7.Text = strAmount; }

            mainControl.SelectedIndex = (int)Pages.Property;

            dt = ControllerForDB.selectAllFromTablesDirectories("property_type");

            if (dt != null)
            {
                propertyTable.DataSource = dt;

                propertyTable.Columns[0].HeaderText = "ID";

                propertyTable.Columns[1].HeaderText = "Тип собственности";
            }

            label7.Text += ControllerForDB.amount;
        }

        private void districtB_Click(object sender, EventArgs e)//Таблица "Район"
        {
            if (!label8.Text.Equals(strAmount)) { label8.Text = strAmount; }

            mainControl.SelectedIndex = (int)Pages.Districts;

            dt = ControllerForDB.selectAllFromTablesDirectories("district");

            if (dt != null)
            {
                districtsTable.DataSource = dt;

                districtsTable.Columns[0].HeaderText = "ID";

                districtsTable.Columns[1].HeaderText = "Район";
            }

            label8.Text += ControllerForDB.amount;
        }

        private void filmsB_Click(object sender, EventArgs e)//Таблица "Фильмы"
        {
            if (!label9.Text.Equals(strAmount)) { label9.Text = strAmount; }

            mainControl.SelectedIndex = (int)Pages.Films;

            dt = ControllerForDB.selectAllFromMainTables("films");

            if (dt != null)
            {
                filmsTable.DataSource = dt;

                filmsTable.Columns[0].HeaderText = "ID";

                filmsTable.Columns[1].HeaderText = "Название";

                filmsTable.Columns[2].HeaderText = "Фамилия режиссера";

                filmsTable.Columns[3].HeaderText = "Имя режиссера";

                filmsTable.Columns[4].HeaderText = "Отчество режиссера";

                filmsTable.Columns[5].HeaderText = "Студия";

                filmsTable.Columns[6].HeaderText = "Год выпуска";

                filmsTable.Columns[7].HeaderText = "Продолжительность";

                filmsTable.Columns[8].HeaderText = "Информация";
            }

            label9.Text += ControllerForDB.amount;
        }

        private void cassettesB_Click(object sender, EventArgs e)//Таблица "Кассеты"
        {
            if (!label10.Text.Equals(strAmount)) { label10.Text = strAmount; }

            mainControl.SelectedIndex = (int)Pages.Cassettes;

            dt = ControllerForDB.selectAllFromMainTables("cassettes");

            if (dt != null)
            {
                cassettesTable.DataSource = dt;

                cassettesTable.Columns[0].HeaderText = "ID";

                cassettesTable.Columns[1].HeaderText = "Качество кассеты";

                cassettesTable.Columns[2].HeaderText = "Фото";

                cassettesTable.Columns[3].HeaderText = "Цена кассеты";

                cassettesTable.Columns[4].HeaderText = "Спрос";

                cassettesTable.Columns[5].HeaderText = "Фильм";
            }

            label10.Text += ControllerForDB.amount;
        }

        private void videorentalB_Click(object sender, EventArgs e)//Таблица "Видеопрокаты"
        {
            if (!label12.Text.Equals(strAmount)) { label12.Text = strAmount; }

            mainControl.SelectedIndex = (int)Pages.VideoRental;

            dt = ControllerForDB.selectAllFromMainTables("video_rental");

            if (dt != null)
            {
                videoTable.DataSource = dt;

                videoTable.Columns[0].HeaderText = "ID";

                videoTable.Columns[1].HeaderText = "Название видеопроката";

                videoTable.Columns[2].HeaderText = "Район";

                videoTable.Columns[3].HeaderText = "Адрес";

                videoTable.Columns[4].HeaderText = "Тип собственности";

                videoTable.Columns[5].HeaderText = "Телефон";

                videoTable.Columns[6].HeaderText = "№ Лицензии";

                videoTable.Columns[7].HeaderText = "Начало работы";

                videoTable.Columns[8].HeaderText = "Конец работы";

                videoTable.Columns[9].HeaderText = "Количество работников";

                videoTable.Columns[10].HeaderText = "Фамилия хозяина";

                videoTable.Columns[11].HeaderText = "Имя хозяина";

                videoTable.Columns[12].HeaderText = "Отчество хозяина";
            }

            label12.Text += ControllerForDB.amount;
        }

        private void ordersB_Click(object sender, EventArgs e)//Таблица "Сделки"
        {
            if (!label11.Text.Equals(strAmount)) { label11.Text = strAmount; }

            mainControl.SelectedIndex = (int)Pages.Orders;

            dt = ControllerForDB.selectAllFromMainTables("deals");

            if (dt != null)
            {
                ordersTable.DataSource = dt;

                ordersTable.Columns[0].HeaderText = "ID";

                ordersTable.Columns[1].HeaderText = "Видеопрокат";
                
                ordersTable.Columns[2].HeaderText = "ID кассеты";

                ordersTable.Columns[3].HeaderText = "Фильм";
                
                ordersTable.Columns[4].HeaderText = "Квитанция";

                ordersTable.Columns[5].HeaderText = "Дата заказа";

                ordersTable.Columns[6].HeaderText = "Услуга";

                ordersTable.Columns[7].HeaderText = "Цена";
                
            }

            label11.Text += ControllerForDB.amount;
        }

        //Добавление в таблицу INSERT-методы
        private void addCountry_Click(object sender, EventArgs e)//Добавление страны
        {
            Main_Menu.InsertIntoDirectTables("countries");
        }

        private void button12_Click(object sender, EventArgs e)//Добавление услуги
        {
            InsertIntoDirectTables("services");
        }

        private void button15_Click(object sender, EventArgs e)//Добавить тип собственности
        {
            InsertIntoDirectTables("property_type");
        }

        private void button18_Click(object sender, EventArgs e)//Добавить район
        {
            InsertIntoDirectTables("district");
        }

        private void button33_Click(object sender, EventArgs e)//Добавление качества
        {
            InsertIntoDirectTables("cassette_quality");
        }

        private void button39_Click(object sender, EventArgs e)//Добавление картинки
        {
            insertPhotoIntoTable();
        }

        private void button9_Click(object sender, EventArgs e)//Добавление хозяина
        {
            addToPeopleTable("owners");
        }

        private void button6_Click(object sender, EventArgs e)//Добавление режиссера
        {
            addToPeopleTable("producers");
        }

        private void button30_Click(object sender, EventArgs e)//Добавление видеопроката
        {
            inserOrUpdatetIntoVideoRental(0);
        }

        private void button3_Click(object sender, EventArgs e)//Добавление студии
        {
            insertOrUpdateIntoStudios(0);
        }

        private void button21_Click(object sender, EventArgs e)//Добавление фильма
        {

        }

        public void insertPhotoIntoTable()//Добавление фото в таблицу
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.JPEG)|*.BMP;*.JPG;*.PNG;*.JPEG|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)//Фото не выбрано
            {
                return;
            }

            ControllerForDB.insertOrUpdatePhoto(openFileDialog.FileName,0);
        }
        
        public static void addToPeopleTable(string t)
        {
            AddOrEditThreeColumns add = new AddOrEditThreeColumns();

            add.mainL2.Text = t == "owners" ? "Добавить хозяина" : "Добавить режиссера";

            m1:

            add.clean();

            add.ShowDialog();

            if (add.fam.Text != String.Empty && add.name.Text != String.Empty && !add.isCanceled && add.isEnabled)
            {
                ControllerForDB.insertOrUpdateIntoPeopleTable(t, add.fam.Text, add.name.Text, add.patronymic.Text, 0);

                ControllerForDB.selectAllFromTablesDirectories(t);
            }
            else
            {
                if (add.isEnabled && (add.fam.Text == String.Empty || add.name.Text == String.Empty))
                {
                    MessageBox.Show("Вы не ввели фамилию или имя.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    goto m1;
                }
                return;
            }
        }

        public static void InsertIntoDirectTables(string t)//Метод добавления и обновления таблиц-справочников
        {
            AddOrEditOneColumn add = new AddOrEditOneColumn();

            switch (t)
            {
                case "countries":
                    {
                        add.mainL1.Text = "Добавить страну";
                        add.groupBox1.Text = "Страна";
                        break;
                    }
                case "services":
                    {
                        add.mainL1.Text = "Добавить услугу";
                        add.groupBox1.Text = "Услуга";
                        break;
                    }
                case "property_type":
                    {
                        add.mainL1.Text = "Добавить тип \nсобственности";
                        add.groupBox1.Text = "Тип собственности";
                        break;
                    }
                case "district":
                    {
                        add.mainL1.Text = "Добавить район";
                        add.groupBox1.Text = "Район";
                        break;
                    }
                case "cassette_quality":
                    {
                        add.mainL1.Text = "Добавить качество\nкассеты";
                        add.groupBox1.Text = "Качество кассеты";
                        break;
                    }
            }

            m1:

            add.clean();

            add.ShowDialog();

            if (add.countryTB.Text != String.Empty && !add.isCanceled && add.isEnabled)
            {
                ControllerForDB.insertIntoDirectTable(t, add.countryTB.Text);

                ControllerForDB.selectAllFromTablesDirectories(t);//??

                MessageBox.Show("Строка добавлена.", "Оповещение");
            }
            else
            {
                if (add.isEnabled && (add.countryTB.Text == String.Empty))
                {
                    MessageBox.Show("Вы не ввели данные.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    goto m1;
                }
                return;
            }
        }

        //Методы UPDATE
        private void button31_Click(object sender, EventArgs e)//Качество
        {
            UpdateDirectT("cassette_quality", (int)qualityTable.SelectedRows[0].Cells[0].Value, (string)qualityTable.SelectedRows[0].Cells[1].Value);
        }

        private void editCountry_Click(object sender, EventArgs e)//Страны
        {
            UpdateDirectT("countries", (int)countriesTable.SelectedRows[0].Cells[0].Value, (string)countriesTable.SelectedRows[0].Cells[1].Value);
        }

        private void button10_Click(object sender, EventArgs e)//Услуги
        {
            UpdateDirectT("services", (int)servicesTable.SelectedRows[0].Cells[0].Value, (string)servicesTable.SelectedRows[0].Cells[1].Value);
        }

        private void button13_Click(object sender, EventArgs e)//Тип собственности
        {
            UpdateDirectT("property_type", (int)propertyTable.SelectedRows[0].Cells[0].Value, (string)propertyTable.SelectedRows[0].Cells[1].Value);
        }

        private void button16_Click(object sender, EventArgs e)//Районы
        {
            UpdateDirectT("district", (int)districtsTable.SelectedRows[0].Cells[0].Value, (string)districtsTable.SelectedRows[0].Cells[1].Value);
        }

        private void button37_Click(object sender, EventArgs e)//Редактирование фото
        {
            updatePhotoIntoTable();
        }

        private void button4_Click(object sender, EventArgs e)//Режиссеры
        {

            updatePeopleTable("producers", 1, (string)producersTable.SelectedRows[0].Cells[1].Value, (string)producersTable.SelectedRows[0].Cells[2].Value, producersTable.SelectedRows[0].Cells[3].Value == DBNull.Value ? null : (string)producersTable.SelectedRows[0].Cells[3].Value);
        }

        private void button7_Click(object sender, EventArgs e)//Хозяины
        {
            updatePeopleTable("owners", 1, (string)ownersTable.SelectedRows[0].Cells[1].Value, (string)ownersTable.SelectedRows[0].Cells[2].Value, ownersTable.SelectedRows[0].Cells[3].Value == DBNull.Value ? null : (string)ownersTable.SelectedRows[0].Cells[3].Value);
        }

        private void button28_Click(object sender, EventArgs e)//Видеопрокаты
        {
            inserOrUpdatetIntoVideoRental(1);
        }

        private void button1_Click(object sender, EventArgs e)//Студии
        {
            insertOrUpdateIntoStudios(1);
        }

        public void updatePhotoIntoTable()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.JPEG)|*.BMP;*.JPG;*.PNG;*.JPEG|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)//Фото не выбрано
            {
                return;
            }

            if (ControllerForDB.insertOrUpdatePhoto(openFileDialog.FileName, 1, (int)imagesTable.SelectedRows[0].Cells[0].Value))
            {
                MessageBox.Show("Фото обновлено.", "Оповещение");
            }
            else
            {
                if (ControllerForDB.isCanceledDelete)
                {
                    return;
                }

                MessageBox.Show("По каким-то причинам строка не добавлена.", "Оповещение");
            }
        }

        public void UpdateDirectT(string t, int i, string val)
        {
            AddOrEditOneColumn add = new AddOrEditOneColumn();

            switch (t)
            {
                case "countries":
                    {
                        add.mainL1.Text = "Редактировать страну";
                        add.groupBox1.Text = "Страна";
                        break;
                    }
                case "services":
                    {
                        add.mainL1.Text = "Редактировать услугу";
                        add.groupBox1.Text = "Услуга";
                        break;
                    }
                case "property_type":
                    {
                        add.mainL1.Text = "Редактировать тип \nсобственности";
                        add.groupBox1.Text = "Тип собственности";
                        break;
                    }
                case "district":
                    {
                        add.mainL1.Text = "Редактировать район";
                        add.groupBox1.Text = "Район";
                        break;
                    }
                case "cassette_quality":
                    {
                        add.mainL1.Text = "Редактировать качество\nкассеты";
                        add.groupBox1.Text = "Качество кассеты";
                        break;
                    }
            }
            add.clean();

            m1:

            add.countryTB.Text = val;

            add.ShowDialog();

            if (add.countryTB.Text != String.Empty && !add.isCanceled && add.isEnabled)
            {
                if (ControllerForDB.updateDirectTables(t, i, add.countryTB.Text))
                {
                    MessageBox.Show("Строка обновлена.", "Оповещение");
                }
                else
                {
                    if (ControllerForDB.isCanceledDelete)
                    {
                        return;
                    }

                    MessageBox.Show("По каким-то причинам строка не добавлена.", "Оповещение");
                }
            }
            else
            {
                if (add.isEnabled && (add.countryTB.Text == String.Empty))
                {
                    MessageBox.Show("Нельзя ввести пустую строку!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto m1;
                }
                return;
            }
        }

        public void updatePeopleTable(string t, int id, string l, string f, string patr)
        {
            AddOrEditThreeColumns add = new AddOrEditThreeColumns();

            add.mainL2.Text = t == "owners" ? "Редактировать хозяина" : "Редактировать режиссера";

            add.clean();

            m1:

            add.fam.Text = l;

            add.name.Text = f;

            add.patronymic.Text = patr;

            add.ShowDialog();

            if (add.fam.Text != String.Empty && add.name.Text != String.Empty && !add.isCanceled && add.isEnabled)
            {
                if (ControllerForDB.insertOrUpdateIntoPeopleTable(t, add.name.Text, add.fam.Text, add.patronymic.Text, 1, t.Equals("owners") ? (int)ownersTable.SelectedRows[0].Cells[0].Value : (int)producersTable.SelectedRows[0].Cells[0].Value))
                {
                    MessageBox.Show("Строка обновлена.", "Оповещение");
                }
                else
                {
                    if (ControllerForDB.isCanceledDelete)
                    {
                        return;
                    }

                    MessageBox.Show("По каким-то причинам строка не добавлена.", "Оповещение");
                }
            }
            else
            {
                if (add.isEnabled && (add.fam.Text == String.Empty || add.name.Text == String.Empty))
                {
                    MessageBox.Show("Вы не ввели фамилию или имя.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    goto m1;
                }
                return;
            }
        }

        //Совмещенные методы INSERT и UPDATE
        public void insertOrUpdateIntoStudios(int val)
        {
            addOrEditTwoColumns add = new addOrEditTwoColumns();

            if (val == 0)
            {
                add.mainL1.Text = "Добавить студию";

                add.button1.Text = "Добавить";
            }
            else
            {
                add.mainL1.Text = "Редактировать студию";

                add.button1.Text = "Сохранить";
            }

            if (val == 1)
            {
                add.title.Text = (string)studiosTable.SelectedRows[0].Cells[1].Value;

                add.countryCB.Text = (string)studiosTable.SelectedRows[0].Cells[2].Value;
            }

            m1:

            add.clean();

            add.ShowDialog();

            if (!add.isCanceled && add.isEnabled && add.title.Text != String.Empty)
            {
                if (val == 0)
                {
                    if (ControllerForDB.insertIntoStudios(add.title.Text, add.list[add.countryCB.Text]))
                    {
                        MessageBox.Show("Строка добавлена.", "Оповещение");
                    }
                    else
                    {
                        if (ControllerForDB.isCanceledDelete)
                        {
                            return;
                        }

                        MessageBox.Show("По каким-то причинам строка не добавлена.", "Оповещение");

                    }
                }
                else
                {
                    if (ControllerForDB.updateStudios(add.title.Text, add.list[add.countryCB.Text], (int)studiosTable.SelectedRows[0].Cells[0].Value))
                    {
                        MessageBox.Show("Строка обновлена.", "Оповещение");
                    }
                    else
                    {
                        if (ControllerForDB.isCanceledDelete)
                        {
                            return;
                        }

                        MessageBox.Show("По каким-то причинам строка не добавлена.", "Оповещение");
                    }
                }
            }
            else
            {
                if (add.isEnabled)
                {
                    if (add.title.Text == String.Empty)
                    {
                        MessageBox.Show("Вы не ввели название.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        goto m1;
                    }
                }
                return;
            }
        }

        public void insertOrUpdateIntoFilms(int val)
        {
            addOrEditFilm add = new addOrEditFilm();

            if (val == 0)
            {
                add.mainL1.Text = "Добавить фильм";

                add.button1.Text = "Добавить";
            }
            else
            {
                add.mainL1.Text = "Редактировать фильм";

                add.button1.Text = "Сохранить";
            }

            if (val == 1)
            {
                add.title.Text = (string)studiosTable.SelectedRows[0].Cells[1].Value;

                add.producerCB.Text = (string)studiosTable.SelectedRows[0].Cells[2].Value;

                add.studioCB.Text = (string)studiosTable.SelectedRows[0].Cells[3].Value;

                add.year.Text = (string)studiosTable.SelectedRows[0].Cells[4].Value;

                add.duration.Text = (string)studiosTable.SelectedRows[0].Cells[5].Value;

                add.info.Text = (string)studiosTable.SelectedRows[0].Cells[6].Value;
            }

        m1:

            add.clean();

            add.ShowDialog();

            if (!add.isCanceled && add.isEnabled && add.title.Text != String.Empty&&add.year.MaskCompleted&&add.duration.Text!=String.Empty&&add.info.Text!=String.Empty)
            {
                if (val == 0)//Доделать добавление и update фильма
                {
                    if (ControllerForDB.insertIntoStudios(add.title.Text, add.list[add.countryCB.Text]))
                    {
                        MessageBox.Show("Строка добавлена.", "Оповещение");
                    }
                    else
                    {
                        if (ControllerForDB.isCanceledDelete)
                        {
                            return;
                        }

                        MessageBox.Show("По каким-то причинам строка не добавлена.", "Оповещение");

                    }
                }
                else
                {
                    if (ControllerForDB.updateStudios(add.title.Text, add.list[add.countryCB.Text], (int)studiosTable.SelectedRows[0].Cells[0].Value))
                    {
                        MessageBox.Show("Строка обновлена.", "Оповещение");
                    }
                    else
                    {
                        if (ControllerForDB.isCanceledDelete)
                        {
                            return;
                        }

                        MessageBox.Show("По каким-то причинам строка не добавлена.", "Оповещение");
                    }
                }
            }
            else
            {
                if (add.isEnabled)
                {
                    if (add.title.Text == String.Empty)
                    {
                        MessageBox.Show("Вы не ввели название.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        goto m1;
                    }
                }
                return;
            }

        }

        public void inserOrUpdatetIntoVideoRental(int val)//Добавление и редактирование "Видеопрокатов"
        {
            AddOrEditVideoRental add = new AddOrEditVideoRental();

            if (val == 0)
            {
                add.mainL1.Text = "Добавить видеопрокат";

                add.button1.Text = "Добавить";
            }
            else
            {
                add.mainL1.Text = "Редактировать видеопрокат";

                add.button1.Text = "Сохранить";
            }

            if (val == 1)
            {
                add.title.Text = (string)videoTable.SelectedRows[0].Cells[1].Value;

                add.districtCB.Text = (string)videoTable.SelectedRows[0].Cells[2].Value;

                add.adress.Text = (string)videoTable.SelectedRows[0].Cells[3].Value;

                add.propCB.Text = (string)videoTable.SelectedRows[0].Cells[4].Value;

                add.license.Text = (string)videoTable.SelectedRows[0].Cells[6].Value;

                add.number.Text = (string)videoTable.SelectedRows[0].Cells[5].Value;

                add.timeEnd.Text = videoTable.SelectedRows[0].Cells[8].Value.ToString();

                add.timeStart.Text = videoTable.SelectedRows[0].Cells[7].Value.ToString();

                add.amountEmpl.Text = (string)videoTable.SelectedRows[0].Cells[9].Value.ToString();

                add.ownerCB.Text = (string)videoTable.SelectedRows[0].Cells[10].Value + " " + (string)(videoTable.SelectedRows[0].Cells[11].Value) + " " + (string)(videoTable.SelectedRows[0].Cells[12].Value);
            }

            m1:

            add.clean();

            add.ShowDialog();

            if (!add.isCanceled && add.isEnabled && add.title.Text != String.Empty && add.adress.Text != String.Empty)
            {
                try//Проверка времени
                {
                    int t1 = int.Parse(add.timeStart.Text);

                    int t2 = int.Parse(add.timeEnd.Text);

                    if (t1 < 6 || t2 > 23)
                    {
                        MessageBox.Show("Время открытия не ранее 6. Время закрытия не позднее 23.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        goto m1;
                    }
                    if (t2 - t1 <= 0)
                    {
                        MessageBox.Show("Время закрытия должно быть позднее времени открытия.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        goto m1;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Время открытия или закрытия введено неверно или не введено.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    goto m1;
                }

                if (!add.number.MaskFull)
                {
                    MessageBox.Show("Номер телефона введен некорректно.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    goto m1;
                }

                if (!add.license.MaskFull)
                {
                    MessageBox.Show("Номер № лицензии введен некорректно.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    goto m1;
                }

                try
                {
                    int n = int.Parse(add.amountEmpl.Text);

                    if (n <= 0)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Количество работников введено некорректно.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    goto m1;
                }

                if (val == 0)
                {
                    if (ControllerForDB.insertIntoVideoRental(add.title.Text, add.list[add.districtCB.Text], add.adress.Text, add.prop_list[add.propCB.Text], add.number.Text, add.license.Text, add.timeStart.Text, add.timeEnd.Text, int.Parse(add.amountEmpl.Text), add.owner_list[add.ownerCB.Text]))
                    {
                        MessageBox.Show("Строка добавлена.", "Оповещение");
                    }
                    else
                    {
                        if (ControllerForDB.isCanceledDelete)
                        {
                            return;
                        }

                        MessageBox.Show("По каким-то причинам строка не добавлена.", "Оповещение");
                    }
                }
                if (val == 1)
                {
                    if (ControllerForDB.updateIntoVideoRental((int)videoTable.SelectedRows[0].Cells[0].Value, add.title.Text, add.list[add.districtCB.Text], add.adress.Text, add.prop_list[add.propCB.Text], add.number.Text, add.license.Text, add.timeStart.Text, add.timeEnd.Text, int.Parse(add.amountEmpl.Text), add.owner_list[add.ownerCB.Text]))
                    {
                        MessageBox.Show("Строка обновлена.", "Оповещение");
                    }
                    else
                    {
                        if (ControllerForDB.isCanceledDelete)
                        {
                            return;
                        }

                        MessageBox.Show("По каким-то причинам строка не добавлена.", "Оповещение");
                    }
                }
            }
            else
            {
                if (add.isEnabled)
                {
                    if (add.title.Text == String.Empty)
                    {
                        MessageBox.Show("Вы не ввели название.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        goto m1;
                    }
                    if (add.adress.Text == String.Empty)
                    {
                        MessageBox.Show("Вы не ввели адрес.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        goto m1;
                    }
                }
                return;
            }
        }
        
        //Методы удаления из таблиц DELETE-методы

        private void button32_Click(object sender, EventArgs e)//Удаление "Качество кассеты"
        {
            deleteRowById((int)qualityTable.SelectedRows[0].Cells[0].Value, "cassette_quality", "pk_quality_id");
        }

        private void button41_Click(object sender, EventArgs e)//Удаление "Услуги и цены"
        {
            deleteRowById((int)servpriceTable.SelectedRows[0].Cells[0].Value, "services_prices", "pk_service_price_id");
        }

        private void deleteCountry_Click(object sender, EventArgs e)//Удаление "Страны"  
        {
            deleteRowById((int)countriesTable.SelectedRows[0].Cells[0].Value, "countries", "pk_country_id");
        }

        private void button2_Click(object sender, EventArgs e)//Удаление "Студии"
        {
            deleteRowById((int)studiosTable.SelectedRows[0].Cells[0].Value, "studios", "pk_studio_id");
        }

        private void button5_Click(object sender, EventArgs e)//Удаление "Режиссеры"
        {
            deleteRowById((int)producersTable.SelectedRows[0].Cells[0].Value, "producers", "pk_producer_id");
        }

        private void button8_Click(object sender, EventArgs e)//Удаление "Хозяины"
        {
            deleteRowById((int)ownersTable.SelectedRows[0].Cells[0].Value, "owners", "pk_owner_id");
        }

        private void button11_Click(object sender, EventArgs e)//Удаление "Услуги"
        {
            deleteRowById((int)servicesTable.SelectedRows[0].Cells[0].Value, "services", "pk_service_id");
        }

        private void button14_Click(object sender, EventArgs e)//Удаление"Тип собственности"
        {
            deleteRowById((int)propertyTable.SelectedRows[0].Cells[0].Value, "property_type", "pk_property_type_id");
        }

        private void button17_Click(object sender, EventArgs e)//Удаление "Районы"
        {
            deleteRowById((int)districtsTable.SelectedRows[0].Cells[0].Value, "district", "pk_district_id");
        }

        private void button20_Click(object sender, EventArgs e)//Удаление "Фильмы"
        {
            deleteRowById((int)filmsTable.SelectedRows[0].Cells[0].Value, "films", "pk_film_id");
        }

        private void button23_Click(object sender, EventArgs e)//Удаление "Кассеты"
        {
            deleteRowById(int.Parse(cassettesTable.SelectedRows[0].Cells[0].Value.ToString()), "cassettes", "pk_cassette_id");
        }

        private void button26_Click(object sender, EventArgs e)//Удаление "Сделки"
        {
            deleteRowById((int)ordersTable.SelectedRows[0].Cells[0].Value, "deals", "pk_deal_id");
        }

        private void button29_Click(object sender, EventArgs e)//Удаление "Видеопрокаты"
        {
            deleteRowById((int)videoTable.SelectedRows[0].Cells[0].Value, "video_rental", "pk_video_rental_id");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            deleteRowById((int)imagesTable.SelectedRows[0].Cells[0].Value, "cassette_photo", "pk_photo_id");
        }

        public void deleteRowById(int index,string table,string id_value)//Функция удаления с выводом информации
        {
            if (ControllerForDB.deleteById(index, table, id_value))
            {
                MessageBox.Show("Строка удалена.", "Оповещение");
            }
            else
            {
                if (ControllerForDB.isCanceledDelete)
                {
                    return;
                }

                MessageBox.Show("По каким-то причинам строка не добавлена.", "Оповещение");
            }
        }

        
    }
}
