using BD_course_work.Properties;
using System;
using System.Collections;
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

        public string connectionStringDB = "Server = localhost; Port = 5432;UserId = postgres; Password =01dr10kv; Database = Video_Rentals; ";

        public DataTable dt;

        public string strAmount = "Количество полей:";

        enum Pages
        {
            VideoRental = 0,
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

            mainControl.SelectedIndex = (int)Pages.ServPrice;

            servpriceTable.DataSource = ControllerForDB.selectAllFromMainTables("services_prices");

            if (servpriceTable.RowCount != 0)
            {
                servpriceTable.Columns[0].HeaderText = "ID";

                servpriceTable.Columns[1].HeaderText = "Видеопрокат";

                servpriceTable.Columns[2].HeaderText = "Услуга";

                servpriceTable.Columns[3].HeaderText = "Цена";
            }

            label15.Text = strAmount + servpriceTable.RowCount;
        }

        private void button35_Click(object sender, EventArgs e)//Таблица "Картинки"
        {
            mainControl.SelectedIndex = (int)Pages.Images;

            imagesTable.DataSource = ControllerForDB.selectAllFromMainTables("cassette_photo");

            if (imagesTable.RowCount != 0)
            {
                imagesTable.Columns[0].HeaderText = "ID";

                imagesTable.Columns[1].HeaderText = "Фото";
            }

            label14.Text = strAmount + imagesTable.RowCount;
        }

        private void button34_Click(object sender, EventArgs e)//Таблица "Качество кассеты"
        {

            mainControl.SelectedIndex = (int)Pages.Quality;

            qualityTable.DataSource = ControllerForDB.selectAllFromMainTables("cassette_quality");

            if (qualityTable.RowCount != 0)
            {
                qualityTable.Columns[0].HeaderText = "ID";

                qualityTable.Columns[1].HeaderText = "Качество";
            }

            label13.Text =strAmount+ qualityTable.RowCount;
        }

        private void countriesB_Click(object sender, EventArgs e)//Таблица "Страны"
        {
            mainControl.SelectedIndex = (int)Pages.Countries;

            countriesTable.DataSource = ControllerForDB.selectAllFromMainTables("countries");

            if (countriesTable.RowCount != 0)
            {
                countriesTable.Columns[0].HeaderText = "ID";

                countriesTable.Columns[1].HeaderText = "Страна";
            }

            label2.Text = strAmount + countriesTable.RowCount;
        }

        private void studiosB_Click(object sender, EventArgs e)//Таблица "Студии"
        {
            mainControl.SelectedIndex = (int)Pages.Studios;

            studiosTable.DataSource = ControllerForDB.selectAllFromMainTables("studios");

            if (studiosTable.RowCount != 0)
            {
                studiosTable.Columns[0].HeaderText = "ID";

                studiosTable.Columns[1].HeaderText = "Студия";

                studiosTable.Columns[2].HeaderText = "Страна";
            }
            label3.Text = strAmount + studiosTable.RowCount;
        }

        private void producersB_Click(object sender, EventArgs e)//Таблица "Режиссеры"
        {
            mainControl.SelectedIndex = (int)Pages.Producers;

            producersTable.DataSource = ControllerForDB.selectAllFromMainTables("producers");

            if (producersTable.RowCount != 0)
            {
                producersTable.Columns[0].HeaderText = "ID";

                producersTable.Columns[1].HeaderText = "Имя";

                producersTable.Columns[2].HeaderText = "Фамилия";

                producersTable.Columns[3].HeaderText = "Отчество";
            }

            label4.Text = strAmount + producersTable.RowCount;
        }

        private void ownersB_Click(object sender, EventArgs e)//Таблица"Хозяины"
        {
            mainControl.SelectedIndex = (int)Pages.Owners;

            ownersTable.DataSource = ControllerForDB.selectAllFromMainTables("owners");

            if (ownersTable.RowCount != 0)
            {
                ownersTable.Columns[0].HeaderText = "ID";

                ownersTable.Columns[1].HeaderText = "Имя";

                ownersTable.Columns[2].HeaderText = "Фамилия";

                ownersTable.Columns[3].HeaderText = "Отчество";
            }

            label5.Text = strAmount + ownersTable.RowCount;
        }

        private void servicesB_Click(object sender, EventArgs e)//Таблица "Услуги"
        {
            mainControl.SelectedIndex = (int)Pages.Services;

            servicesTable.DataSource = ControllerForDB.selectAllFromMainTables("services");

            if (servicesTable.RowCount != 0)
            {
                servicesTable.Columns[0].HeaderText = "ID";

                servicesTable.Columns[1].HeaderText = "Услуга";
            }

            label6.Text = strAmount + servicesTable.RowCount;
        }

        private void proptypeB_Click(object sender, EventArgs e)//Таблица "Тип_собственности"
        {
            mainControl.SelectedIndex = (int)Pages.Property;

            propertyTable.DataSource = ControllerForDB.selectAllFromMainTables("property_type");

            if (propertyTable.RowCount != 0)
            {
                propertyTable.Columns[0].HeaderText = "ID";

                propertyTable.Columns[1].HeaderText = "Тип собственности";
            }

            label7.Text = strAmount + propertyTable.RowCount;
        }

        private void districtB_Click(object sender, EventArgs e)//Таблица "Район"
        {
            mainControl.SelectedIndex = (int)Pages.Districts;

            districtsTable.DataSource = ControllerForDB.selectAllFromMainTables("district");

            if (districtsTable.RowCount != 0)
            {
                districtsTable.Columns[0].HeaderText = "ID";

                districtsTable.Columns[1].HeaderText = "Район";
            }

            label8.Text = strAmount + districtsTable.RowCount;
        }

        private void filmsB_Click(object sender, EventArgs e)//Таблица "Фильмы"
        {
            mainControl.SelectedIndex = (int)Pages.Films;

            filmsTable.DataSource = ControllerForDB.selectAllFromMainTables("films");

            if (filmsTable.RowCount != 0)
            {
                filmsTable.Columns[0].HeaderText = "ID";

                filmsTable.Columns[1].HeaderText = "Название";

                filmsTable.Columns[2].HeaderText = "Фамилия режиссера";

                filmsTable.Columns[3].HeaderText = "Имя режиссера";

                filmsTable.Columns[4].HeaderText = "Отчество режиссера";

                filmsTable.Columns[5].HeaderText = "Студия";

                filmsTable.Columns[6].HeaderText = "Страна студии";

                filmsTable.Columns[7].HeaderText = "Год выпуска";

                filmsTable.Columns[8].HeaderText = "Продолжительность";

                filmsTable.Columns[9].HeaderText = "Информация";
            }

            label9.Text = strAmount + filmsTable.RowCount;
        }

        private void cassettesB_Click(object sender, EventArgs e)//Таблица "Кассеты"
        {
            mainControl.SelectedIndex = (int)Pages.Cassettes;

            cassettesTable.DataSource = ControllerForDB.selectAllFromMainTables("cassettes");

            if (cassettesTable.RowCount != 0)
            {
                cassettesTable.Columns[0].HeaderText = "ID";

                cassettesTable.Columns[1].HeaderText = "Качество кассеты";

                cassettesTable.Columns[2].HeaderText = "Фото";

                cassettesTable.Columns[3].HeaderText = "Цена кассеты";

                cassettesTable.Columns[4].HeaderText = "Спрос";

                cassettesTable.Columns[5].HeaderText = "Фильм";
            }

            label10.Text = strAmount + cassettesTable.RowCount;
        }

        private void videorentalB_Click(object sender, EventArgs e)//Таблица "Видеопрокаты"
        {
            mainControl.SelectedIndex = (int)Pages.VideoRental;

            videoTable.DataSource = ControllerForDB.selectAllFromMainTables("video_rental");

            if (videoTable.RowCount != 0)
            {
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

            label12.Text = strAmount + videoTable.RowCount;
        }

        private void ordersB_Click(object sender, EventArgs e)//Таблица "Сделки"
        {
            mainControl.SelectedIndex = (int)Pages.Orders;

            ordersTable.DataSource = ControllerForDB.selectAllFromMainTables("deals");

            if (ordersTable.RowCount !=0)
            {
                ordersTable.Columns[0].HeaderText = "ID";

                ordersTable.Columns[1].HeaderText = "Видеопрокат";

                ordersTable.Columns[2].HeaderText = "ID кассеты";

                ordersTable.Columns[3].HeaderText = "Фильм";

                ordersTable.Columns[4].HeaderText = "Квитанция";

                ordersTable.Columns[5].HeaderText = "Дата заказа";

                ordersTable.Columns[6].HeaderText = "Услуга";

                ordersTable.Columns[7].HeaderText = "Цена";
            }

            label11.Text = strAmount + ordersTable.RowCount;
        }

        //Добавление в таблицу INSERT-методы
        private void addCountry_Click(object sender, EventArgs e)//Добавление страны
        {
            Main_Menu.InsertIntoDirectTables("countries");

            countriesTable.DataSource = ControllerForDB.selectAllFromMainTables("countries");

            if (countriesTable.RowCount == 1)
            {
                countriesTable.Columns[0].HeaderText = "ID";

                countriesTable.Columns[1].HeaderText = "Страна";
            }

            label2.Text = strAmount + countriesTable.RowCount;
        }

        private void button12_Click(object sender, EventArgs e)//Добавление услуги
        {
            InsertIntoDirectTables("services_view");

            servicesTable.DataSource = ControllerForDB.selectAllFromMainTables("services");

            if (servicesTable.RowCount == 1)
            {
                servicesTable.Columns[0].HeaderText = "ID";

                servicesTable.Columns[1].HeaderText = "Услуга";
            }

            label6.Text = strAmount + servicesTable.RowCount;
        }

        private void button15_Click(object sender, EventArgs e)//Добавить тип собственности
        {
            InsertIntoDirectTables("property_type");

            propertyTable.DataSource = ControllerForDB.selectAllFromMainTables("property_type");

            if (propertyTable.RowCount == 1)
            {
                propertyTable.Columns[0].HeaderText = "ID";

                propertyTable.Columns[1].HeaderText = "Тип собственности";
            }

            label7.Text = strAmount + propertyTable.RowCount;
        }

        private void button18_Click(object sender, EventArgs e)//Добавить район
        {
            InsertIntoDirectTables("district");

            districtsTable.DataSource = ControllerForDB.selectAllFromMainTables("district");

            if (districtsTable.RowCount == 1)
            {
                districtsTable.Columns[0].HeaderText = "ID";

                districtsTable.Columns[1].HeaderText = "Район";
            }

            label8.Text = strAmount + districtsTable.RowCount;
        }

        private void button33_Click(object sender, EventArgs e)//Добавление качества
        {
            InsertIntoDirectTables("cassette_quality");

            qualityTable.DataSource = ControllerForDB.selectAllFromMainTables("cassette_quality");

            if (qualityTable.RowCount ==1)
            {
                qualityTable.Columns[0].HeaderText = "ID";

                qualityTable.Columns[1].HeaderText = "Качество";
            }

            label13.Text = strAmount + qualityTable.RowCount;
        }

        private void button39_Click(object sender, EventArgs e)//Добавление картинки
        {
            if (insertPhotoIntoTable())
            {
                imagesTable.DataSource = ControllerForDB.selectAllFromMainTables("cassette_photo");

                if (imagesTable.RowCount == 1)
                {
                    imagesTable.Columns[0].HeaderText = "ID";

                    imagesTable.Columns[1].HeaderText = "Фото";
                }

                label14.Text = strAmount + imagesTable.RowCount;
            }
        }

        private void button9_Click(object sender, EventArgs e)//Добавление хозяина
        {
            addToPeopleTable("owners");

            ownersTable.DataSource = ControllerForDB.selectAllFromMainTables("owners");

            if (ownersTable.RowCount == 1)
            {
                ownersTable.Columns[0].HeaderText = "ID";

                ownersTable.Columns[1].HeaderText = "Имя";

                ownersTable.Columns[2].HeaderText = "Фамилия";

                ownersTable.Columns[3].HeaderText = "Отчество";
            }

            label5.Text = strAmount + ownersTable.RowCount;
        }

        private void button6_Click(object sender, EventArgs e)//Добавление режиссера
        {
            addToPeopleTable("producers");

            producersTable.DataSource = ControllerForDB.selectAllFromMainTables("producers");

            if (producersTable.RowCount == 1)
            {
                producersTable.Columns[0].HeaderText = "ID";

                producersTable.Columns[1].HeaderText = "Имя";

                producersTable.Columns[2].HeaderText = "Фамилия";

                producersTable.Columns[3].HeaderText = "Отчество";
            }

            label4.Text = strAmount + producersTable.RowCount;
        }

        private void button30_Click(object sender, EventArgs e)//Добавление видеопроката
        {
            inserOrUpdatetIntoVideoRental(0);

            videoTable.DataSource = ControllerForDB.selectAllFromMainTables("video_rental");

            if (videoTable.RowCount == 1)
            {
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

            label12.Text = strAmount + videoTable.RowCount;
        }

        private void button3_Click(object sender, EventArgs e)//Добавление студии
        {
            insertOrUpdateIntoStudios(0);

            studiosTable.DataSource = ControllerForDB.selectAllFromMainTables("studios");

            if (studiosTable.RowCount == 1)
            {
                studiosTable.Columns[0].HeaderText = "ID";

                studiosTable.Columns[1].HeaderText = "Студия";

                studiosTable.Columns[2].HeaderText = "Страна";
            }
            label3.Text = strAmount + studiosTable.RowCount;
        }

        private void button21_Click(object sender, EventArgs e)//Добавление фильма
        {
            insertOrUpdateIntoFilms(0);

            filmsTable.DataSource = ControllerForDB.selectAllFromMainTables("films");

            if (filmsTable.RowCount == 1)
            {
                filmsTable.Columns[0].HeaderText = "ID";

                filmsTable.Columns[1].HeaderText = "Название";

                filmsTable.Columns[2].HeaderText = "Фамилия режиссера";

                filmsTable.Columns[3].HeaderText = "Имя режиссера";

                filmsTable.Columns[4].HeaderText = "Отчество режиссера";

                filmsTable.Columns[5].HeaderText = "Студия";

                filmsTable.Columns[6].HeaderText = "Страна студии";

                filmsTable.Columns[7].HeaderText = "Год выпуска";

                filmsTable.Columns[8].HeaderText = "Продолжительность";

                filmsTable.Columns[9].HeaderText = "Информация";
            }

            label9.Text = strAmount + filmsTable.RowCount;
        }

        private void button24_Click(object sender, EventArgs e)//Добавление кассеты
        {
            insertOrUpdateIntoCassettes(0);

            cassettesTable.DataSource = ControllerForDB.selectAllFromMainTables("cassettes");

            if (cassettesTable.RowCount == 1)
            {
                cassettesTable.Columns[0].HeaderText = "ID";

                cassettesTable.Columns[1].HeaderText = "Качество кассеты";

                cassettesTable.Columns[2].HeaderText = "Фото";

                cassettesTable.Columns[3].HeaderText = "Цена кассеты";

                cassettesTable.Columns[4].HeaderText = "Спрос";

                cassettesTable.Columns[5].HeaderText = "Фильм";
            }

            label10.Text = strAmount + cassettesTable.RowCount;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            insertIntoServicesPrices(0);

            servpriceTable.DataSource = ControllerForDB.selectAllFromMainTables("services_prices");

            if (servpriceTable.RowCount ==1)
            {
                servpriceTable.Columns[0].HeaderText = "ID";

                servpriceTable.Columns[1].HeaderText = "Видеопрокат";

                servpriceTable.Columns[2].HeaderText = "Услуга";

                servpriceTable.Columns[3].HeaderText = "Цена";
            }

            label15.Text = "Количество полей:" + servpriceTable.RowCount;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            insertOrUpdateIntoDeals(0);

            ordersTable.DataSource = ControllerForDB.selectAllFromMainTables("deals");

            if (ordersTable.RowCount ==1)
            {
                ordersTable.Columns[0].HeaderText = "ID";

                ordersTable.Columns[1].HeaderText = "Видеопрокат";

                ordersTable.Columns[2].HeaderText = "ID кассеты";

                ordersTable.Columns[3].HeaderText = "Фильм";

                ordersTable.Columns[4].HeaderText = "Квитанция";

                ordersTable.Columns[5].HeaderText = "Дата заказа";

                ordersTable.Columns[6].HeaderText = "Услуга";

                ordersTable.Columns[7].HeaderText = "Цена";
            }

            label11.Text = strAmount + ordersTable.RowCount;
        }

        public static string path;

        public static int pic_id = 0;

        public static bool insertPhotoIntoTable()//Добавление фото в таблицу
        {
            pic_id = 0;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.JPEG)|*.BMP;*.JPG;*.PNG;*.JPEG|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)//Фото не выбрано
            {
                return false;
            }

            path = openFileDialog.FileName;

            pic_id = ControllerForDB.insertOrUpdatePhoto(openFileDialog.FileName, 0);

            MessageBox.Show("Фото добавлено.", "Оповещение");

            return true;
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
                if(ControllerForDB.insertOrUpdateIntoPeopleTable(t, add.fam.Text, add.name.Text, add.patronymic.Text, 0))
                {
                    ControllerForDB.selectAllFromMainTables(t);

                    MessageBox.Show("Строка успешно добавлена.", "Оповещение");
                }
                else
                {
                    MessageBox.Show("Такая строка уже существует.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                case "services_view":
                    {
                        add.mainL1.Text = "Добавить услугу";
                        add.groupBox1.Text = "Услуга";
                        break;
                    }
                case "property_type":
                    {
                        add.mainL1.Text = "Добавить тип собственности";
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
                if (ControllerForDB.insertIntoDirectTable(t, add.countryTB.Text))
                {
                    MessageBox.Show("Строка добавлена.", "Оповещение");
                }
                else
                {
                    MessageBox.Show("Запись с таким значением существует.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    goto m1;
                }

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
            if (qualityTable.RowCount != 0)
            {
                UpdateDirectT("cassette_quality", (int)qualityTable.SelectedRows[0].Cells[0].Value, (string)qualityTable.SelectedRows[0].Cells[1].Value);

                qualityTable.DataSource = ControllerForDB.selectAllFromMainTables("cassette_quality");

                label13.Text = strAmount + qualityTable.RowCount;
            }
            else
            {
                MessageBox.Show("Таблица пуста.", "Оповещение");
            }
        }

        private void button40_Click(object sender, EventArgs e)//Услуги и цены
        {
            if (servpriceTable.RowCount != 0)
            {
                insertIntoServicesPrices(1, (int)servpriceTable.SelectedRows[0].Cells[0].Value, servpriceTable.SelectedRows[0].Cells[2].Value.ToString(),
                servpriceTable.SelectedRows[0].Cells[1].Value.ToString(), servpriceTable.SelectedRows[0].Cells[3].Value.ToString());

                servpriceTable.DataSource = ControllerForDB.selectAllFromMainTables("services_prices");

                label15.Text = "Количество полей:" + servpriceTable.RowCount;
            }
            else
            {
                MessageBox.Show("Таблица пуста.", "Оповещение");
            }
        }

        private void editCountry_Click(object sender, EventArgs e)//Страны
        {
            if (countriesTable.RowCount != 0)
            {
                UpdateDirectT("countries", (int)countriesTable.SelectedRows[0].Cells[0].Value, (string)countriesTable.SelectedRows[0].Cells[1].Value);

                countriesTable.DataSource = ControllerForDB.selectAllFromMainTables("countries");

                label2.Text = strAmount + countriesTable.RowCount;
            }
            else
            {
                MessageBox.Show("Таблица пуста.", "Оповещение");
            }
        }

        private void button10_Click(object sender, EventArgs e)//Услуги
        {
            if (servicesTable.RowCount != 0)
            {
                UpdateDirectT("services", (int)servicesTable.SelectedRows[0].Cells[0].Value, (string)servicesTable.SelectedRows[0].Cells[1].Value);

                servicesTable.DataSource = ControllerForDB.selectAllFromMainTables("services");

                label6.Text = strAmount + servicesTable.RowCount;
            }
            else
            {
                MessageBox.Show("Таблица пуста.", "Оповещение");
            }
        }

        private void button13_Click(object sender, EventArgs e)//Тип собственности
        {
            if (propertyTable.RowCount != 0)
            {
                UpdateDirectT("property_type", (int)propertyTable.SelectedRows[0].Cells[0].Value, (string)propertyTable.SelectedRows[0].Cells[1].Value);

                propertyTable.DataSource = ControllerForDB.selectAllFromMainTables("property_type");

                label7.Text = strAmount + propertyTable.RowCount;
            }
            else
            {
                MessageBox.Show("Таблица пуста.", "Оповещение");
            }

        }

        private void button16_Click(object sender, EventArgs e)//Районы
        {
            if (districtsTable.RowCount != 0)
            {
                UpdateDirectT("district", (int)districtsTable.SelectedRows[0].Cells[0].Value, (string)districtsTable.SelectedRows[0].Cells[1].Value);

                districtsTable.DataSource = ControllerForDB.selectAllFromMainTables("district");

                label8.Text = strAmount + districtsTable.RowCount;
            }
            else
            {
                MessageBox.Show("Таблица пуста.", "Оповещение");
            }
        }

        private void button37_Click(object sender, EventArgs e)//Редактирование фото
        {
            if (imagesTable.RowCount != 0)
            {
                updatePhotoIntoTable();

                imagesTable.DataSource = ControllerForDB.selectAllFromMainTables("cassette_photo");

                label14.Text = strAmount + imagesTable.RowCount;
            }
            else
            {
                MessageBox.Show("Таблица пуста.", "Оповещение");
            }
        }

        private void button4_Click(object sender, EventArgs e)//Режиссеры
        {
            if (producersTable.RowCount != 0)
            {
                updatePeopleTable("producers", 1, (string)producersTable.SelectedRows[0].Cells[1].Value, (string)producersTable.SelectedRows[0].Cells[2].Value, producersTable.SelectedRows[0].Cells[3].Value == DBNull.Value ? null :
                (string)producersTable.SelectedRows[0].Cells[3].Value);

                producersTable.DataSource = ControllerForDB.selectAllFromMainTables("producers");
                
                label4.Text = strAmount + producersTable.RowCount;
            }
            else
            {
                MessageBox.Show("Таблица пуста.", "Оповещение");
            }
        }

        private void button7_Click(object sender, EventArgs e)//Хозяины
        {
            if (ownersTable.RowCount != 0)
            {
                updatePeopleTable("owners", 1, (string)ownersTable.SelectedRows[0].Cells[1].Value, (string)ownersTable.SelectedRows[0].Cells[2].Value,
                ownersTable.SelectedRows[0].Cells[3].Value == DBNull.Value ? null : (string)ownersTable.SelectedRows[0].Cells[3].Value);

                ownersTable.DataSource = ControllerForDB.selectAllFromMainTables("owners");

                label5.Text = strAmount + ownersTable.RowCount;
            }
            else
            {
                MessageBox.Show("Таблица пуста.", "Оповещение");
            }
        }

        private void button28_Click(object sender, EventArgs e)//Видеопрокаты
        {
            if (videoTable.RowCount != 0)
            {
                inserOrUpdatetIntoVideoRental(1, (int)videoTable.SelectedRows[0].Cells[0].Value, (string)videoTable.SelectedRows[0].Cells[1].Value, (string)videoTable.SelectedRows[0].Cells[2].Value, (string)videoTable.SelectedRows[0].Cells[3].Value, (string)videoTable.SelectedRows[0].Cells[4].Value,
                (string)videoTable.SelectedRows[0].Cells[6].Value, (string)videoTable.SelectedRows[0].Cells[5].Value, videoTable.SelectedRows[0].Cells[8].Value.ToString(),
                videoTable.SelectedRows[0].Cells[7].Value.ToString(), (string)videoTable.SelectedRows[0].Cells[9].Value.ToString(), ((string)videoTable.SelectedRows[0].Cells[10].Value + " " + (string)(videoTable.SelectedRows[0].Cells[11].Value) + " " + (string)(videoTable.SelectedRows[0].Cells[12].Value)));

                videoTable.DataSource = ControllerForDB.selectAllFromMainTables("video_rental");

                label12.Text = strAmount + videoTable.RowCount;
            }
            else
            {
                MessageBox.Show("Таблица пуста.", "Оповещение");
            }
        }

        private void button1_Click(object sender, EventArgs e)//Студии
        {
            if (studiosTable.RowCount != 0)
            {
                insertOrUpdateIntoStudios(1, studiosTable.SelectedRows[0].Cells[1].Value.ToString(), (string)studiosTable.SelectedRows[0].Cells[2].Value,
                (int)studiosTable.SelectedRows[0].Cells[0].Value);

                studiosTable.DataSource = ControllerForDB.selectAllFromMainTables("studios");

                label3.Text = strAmount + studiosTable.RowCount;
            }
            else
            {
                MessageBox.Show("Таблица пуста.", "Оповещение");
            }
        }

        private void button19_Click(object sender, EventArgs e)//Фильмы
        {
            if (filmsTable.RowCount != 0)
            {
                insertOrUpdateIntoFilms(1, filmsTable.SelectedRows[0].Cells[0].Value.ToString(), filmsTable.SelectedRows[0].Cells[1].Value.ToString(), (filmsTable.SelectedRows[0].Cells[2].Value.ToString() + " " + filmsTable.SelectedRows[0].Cells[3].Value.ToString() + " " + filmsTable.SelectedRows[0].Cells[4].Value.ToString()),
                filmsTable.SelectedRows[0].Cells[5].Value.ToString()+","+ filmsTable.SelectedRows[0].Cells[6].Value.ToString(), filmsTable.SelectedRows[0].Cells[7].Value.ToString(), filmsTable.SelectedRows[0].Cells[8].Value.ToString(), filmsTable.SelectedRows[0].Cells[9].Value.ToString());

                filmsTable.DataSource = ControllerForDB.selectAllFromMainTables("films");

                label9.Text = strAmount + filmsTable.RowCount;
            }
            else
            {
                MessageBox.Show("Таблица пуста.", "Оповещение");
            }

        }

        private void button22_Click(object sender, EventArgs e)//Кассеты
        {
            if (cassettesTable.RowCount != 0)
            {
                insertOrUpdateIntoCassettes(1, cassettesTable.SelectedRows[0].Cells[1].Value.ToString(),
                                               cassettesTable.SelectedRows[0].Cells[2].Value == DBNull.Value ? null : (byte[])cassettesTable.SelectedRows[0].Cells[2].Value,
                                               cassettesTable.SelectedRows[0].Cells[3].Value.ToString(), cassettesTable.SelectedRows[0].Cells[4].Value.ToString(),
                                               cassettesTable.SelectedRows[0].Cells[5].Value.ToString(), int.Parse(cassettesTable.SelectedRows[0].Cells[0].Value.ToString()));

                cassettesTable.DataSource = ControllerForDB.selectAllFromMainTables("cassettes");

                label10.Text = strAmount + cassettesTable.RowCount;
            }
            else
            {
                MessageBox.Show("Таблица пуста.", "Оповещение");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (ordersTable.RowCount != 0)
            {
                insertOrUpdateIntoDeals(1, int.Parse(ordersTable.SelectedRows[0].Cells[2].Value.ToString()), ordersTable.SelectedRows[0].Cells[4].Value.ToString(),
                   ordersTable.SelectedRows[0].Cells[5].Value.ToString(), ordersTable.SelectedRows[0].Cells[1].Value.ToString(), ordersTable.SelectedRows[0].Cells[6].Value.ToString(),
                   float.Parse(ordersTable.SelectedRows[0].Cells[7].Value.ToString()), int.Parse(ordersTable.SelectedRows[0].Cells[0].Value.ToString()));

                ordersTable.DataSource = ControllerForDB.selectAllFromMainTables("deals");

                label11.Text = strAmount + ordersTable.RowCount;
            }
            else
            {
                MessageBox.Show("Таблица пуста.", "Оповещение");
            }
        }

        public void updatePhotoIntoTable()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.JPEG)|*.BMP;*.JPG;*.PNG;*.JPEG|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)//Фото не выбрано
            {
                return;
            }

            if (ControllerForDB.insertOrUpdatePhoto(openFileDialog.FileName, 1, (int)imagesTable.SelectedRows[0].Cells[0].Value) != 0)
            {
                MessageBox.Show("Фото обновлено.", "Оповещение");
            }
            else
            {
                if (ControllerForDB.isCanceledDelete)
                {
                    return;
                }

                MessageBox.Show("Такая строка уже существует.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    MessageBox.Show("Такая строка уже существует.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            add.fam.Text = f;

            add.name.Text = l;

            add.patronymic.Text = patr;

            add.ShowDialog();

            if (add.fam.Text != String.Empty && add.name.Text != String.Empty && !add.isCanceled && add.isEnabled)
            {
                if (ControllerForDB.insertOrUpdateIntoPeopleTable(t,  add.fam.Text, add.name.Text, add.patronymic.Text, 1, t.Equals("owners") ? (int)ownersTable.SelectedRows[0].Cells[0].Value : (int)producersTable.SelectedRows[0].Cells[0].Value))
                {
                    MessageBox.Show("Строка обновлена.", "Оповещение");
                }
                else
                {
                    if (ControllerForDB.isCanceledDelete)
                    {
                        return;
                    }
                    MessageBox.Show("Такая строка уже существует.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public static void insertIntoServicesPrices(int val, int id = 0, string service = "", string video = "", string price = "")
        {
            addOrEditServicesPrices add = new addOrEditServicesPrices();

            if (val == 0)
            {
                add.mainL1.Text = "Добавить услугу и цену";

                add.button1.Text = "Добавить";
            }
            else
            {
                add.mainL1.Text = "Редактировать услугу и цену";

                add.button1.Text = "Сохранить";
            }

            if (val == 1)
            {
                add.serviceCB.Text = service;

                add.rentalCB.Text = video;

                add.price.Text = price;
            }

        m1:

            add.clean();

            add.ShowDialog();

            if (!add.isCanceled && add.isEnabled && add.price.Text != String.Empty)
            {
                if (val == 0)
                {
                    try
                    {
                        double.Parse(add.price.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Вы ввели цену неверно. Возможно, вы ввели цену через '.'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        goto m1;
                    }

                    if (ControllerForDB.insertIntoServicesPrices(add.services_list[add.serviceCB.Text], add.video_list[add.rentalCB.Text], double.Parse(add.price.Text)))
                    {
                        MessageBox.Show("Строка добавлена.", "Оповещение");
                    }
                    else
                    {
                        MessageBox.Show("Такая строка уже существует.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (ControllerForDB.updateServicesPrices(id, add.services_list[add.serviceCB.Text], add.video_list[add.rentalCB.Text], double.Parse(add.price.Text)))
                    {
                        MessageBox.Show("Строка обновлена.", "Оповещение");
                    }
                    else
                    {
                        if (ControllerForDB.isCanceledDelete)
                        {
                            return;
                        }
                    }
                }
            }
            else
            {
                if (add.isEnabled)
                {
                    if (add.price.Text == String.Empty)
                    {
                        MessageBox.Show("Вы не ввели цену.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        goto m1;
                    }
                }
                return;
            }
        }

        public static void insertOrUpdateIntoDeals(int val, int cassette_id = 0, string recipe_deal = "", string deal_date = "", string video = "", string service = "", float price = 0, int id = 0)
        {
            addOrEditDeals add = new addOrEditDeals();

            if (val == 0)
            {
                add.mainL1.Text = "Добавить сделку";

                add.button1.Text = "Добавить";
            }
            else
            {
                add.mainL1.Text = "Редактировать сделку";

                add.button1.Text = "Сохранить";
            }

            if (val == 1)
            {
                add.idCB.Text = cassette_id.ToString();

                add.recipeTB.Text = recipe_deal;

                add.dateCB.Text = deal_date;

                add.rentalCB.Text = video;

                add.serviceCB.Text = service;

                add.priceTB.Text = price.ToString();
            }

        m1:

            add.clean();

            add.ShowDialog();

            if (!add.isCanceled && add.isEnabled && add.priceTB.Text != String.Empty && add.recipeTB.Text != String.Empty)
            {
                if (val == 0)
                {
                    if (ControllerForDB.insertOrUpdateIntoDeals(0, int.Parse(add.idCB.Text), add.dateCB.Text, add.services_list[add.serviceCB.Text], double.Parse(add.priceTB.Text)))
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
                    if (ControllerForDB.insertOrUpdateIntoDeals(1, int.Parse(add.idCB.Text), add.dateCB.Text, add.services_list[add.serviceCB.Text], double.Parse(add.priceTB.Text), id))
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
                return;
            }

        }

        public static void insertOrUpdateIntoStudios(int val, string title = "", string country = "", int id = 0)
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
                add.title.Text = title;

                add.countryCB.Text = country;
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

                        MessageBox.Show("Такая строка уже существует.", "Оповещение",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    }
                }
                else
                {
                    if (ControllerForDB.updateStudios(add.title.Text, add.list[add.countryCB.Text], id))
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

        public static void insertOrUpdateIntoCassettes(int val, string quality = "", byte[] b = null, string price = "", string demand = "", string film = "", int id = 0)
        {
            addOrEditCassettes add = new addOrEditCassettes();

            if (val == 0)
            {
                add.mainL1.Text = "Добавить кассету";

                add.button1.Text = "Добавить";

            }
            else
            {
                add.mainL1.Text = "Редактировать кассету";

                add.button1.Text = "Сохранить";

            }

            if (val == 1)
            {
                add.qualityCB.Text = quality;

                add.filmCB.Text = film;

                add.demandCB.Text = demand;

                add.priceTB.Text = price;

                add.photoPB.Image = b == null ? Resources.add_photo : Instruments.convertBIntoImage(b);

                //if()
            }

        m1:

            add.clean();

            add.ShowDialog();

            if (!add.isCanceled && add.isEnabled && add.priceTB.Text != String.Empty)
            {
                try
                {
                    double.Parse(add.priceTB.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Вы не ввели цену или ввели некорректно.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    goto m1;
                }

                if (val == 0)
                {

                    if (ControllerForDB.insertIntoCassette(add.quality_list[add.qualityCB.Text], pic_id, double.Parse(add.priceTB.Text), bool.Parse(add.demandCB.Text == "Да" ? "true" : "false"), add.film_list[add.filmCB.Text]))
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
                    if (ControllerForDB.updateCassette(id, add.quality_list[add.qualityCB.Text], pic_id, double.Parse(add.priceTB.Text), bool.Parse(add.demandCB.Text == "Да" ? "true" : "false"), add.film_list[add.filmCB.Text]))
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
                    if (add.priceTB.Text == String.Empty)
                    {
                        MessageBox.Show("Вы не ввели цену.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        goto m1;
                    }
                }
                return;
            }
        }

        public static void insertOrUpdateIntoFilms(int val, string id = "", string title = "", string producer = "", string studio = "", string year = "", string duration = "", string info = "")
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
                add.title.Text = title;

                add.producerCB.Text = producer;

                add.studioCB.Text = studio;

                add.year.Text = year;

                add.duration.Text = duration;

                add.info.Text = info;
            }

        m1:

            add.clean();

            add.ShowDialog();

            if (!add.isCanceled && add.isEnabled && add.title.Text != String.Empty && add.info.Text != String.Empty)
            {
                if (!add.year.MaskCompleted || int.Parse(add.year.Text) < 1888 || int.Parse(add.year.Text) > 2022)
                {
                    MessageBox.Show("Вы не ввели год выпуска или ввели некорректно. Год должен быть не менее 1888 и не более 2022.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    goto m1;
                }
                try
                {
                    if (add.duration.Text == String.Empty || int.Parse(add.duration.Text) < 15 || int.Parse(add.duration.Text) > 1000)
                    {
                        MessageBox.Show("Вы не ввели продолжительность фильма или ввели некорректно. Продолжительность должна быть не менее 15 и не более 1000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        goto m1;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректный ввод продолжительности.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    goto m1;
                }

                if (val == 0)
                {
                    if (ControllerForDB.insertIntoFilms(add.title.Text, add.producer_list[(string)add.producerCB.Text], add.studio_list[(string)add.studioCB.Text], int.Parse(add.year.Text), int.Parse(add.duration.Text), add.info.Text))
                    {
                        MessageBox.Show("Строка добавлена.", "Оповещение");
                    }
                    else
                    {
                        if (ControllerForDB.isCanceledDelete)
                        {
                            return;
                        }

                        MessageBox.Show("Такая строка уже существует.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    if (ControllerForDB.updateFilms(int.Parse(id), add.title.Text, add.producer_list[(string)add.producerCB.Text], add.studio_list[(string)add.studioCB.Text], int.Parse(add.year.Text), int.Parse(add.duration.Text), add.info.Text))
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

                    if (add.info.Text == String.Empty)
                    {
                        MessageBox.Show("Вы не ввели информацию о фильме.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        goto m1;
                    }
                }
                return;
            }

        }

        public static void inserOrUpdatetIntoVideoRental(int val, int id = 0, string title = "", string district = "", string adress = "", string prop = "", string license = "", string number = "", string timeE = "", string timeS = "", string amount = "", string owner = "")//Добавление и редактирование "Видеопрокатов"
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
                add.title.Text = title;

                add.districtCB.Text = district;

                add.adress.Text = adress;

                add.propCB.Text = prop;

                add.license.Text = license;

                add.number.Text = number;

                add.timeEnd.Text = timeE;

                add.timeStart.Text = timeS;

                add.amountEmpl.Text = amount;

                add.ownerCB.Text = owner;
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
                    if (ControllerForDB.updateIntoVideoRental(id, add.title.Text, add.list[add.districtCB.Text], add.adress.Text, add.prop_list[add.propCB.Text], add.number.Text, add.license.Text, add.timeStart.Text, add.timeEnd.Text, int.Parse(add.amountEmpl.Text), add.owner_list[add.ownerCB.Text]))
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
            deleteMenu del = new deleteMenu();

            del.clean();

            del.ShowDialog();

            if (!del.isCanceled)
            {
                if (qualityTable.RowCount != 0)
                {
                    if (del.isDeleteStr)
                    {
                        if(deleteRowById((int)qualityTable.SelectedRows[0].Cells[0].Value, "cassette_quality", "pk_quality_id"))
                        {
                            qualityTable.Rows.Remove(qualityTable.SelectedRows[0]);
                        }
                    }
                    if (del.isDeleteManyStr)
                    {
                            int i = qualityTable.RowCount;

                            int N = qualityTable.RowCount;

                            int count = 0;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)qualityTable.Rows[(i - 1)].Cells[0].Value, "cassette_quality", "pk_quality_id", i == N ? true : false))
                                {
                                    if (count == 0)
                                    {
                                        MessageBox.Show("Удаление начинается.", "Оповещение");
                                    }
                                    count++;
                                }
                                i--;
                            }
                            if (count == N)
                            {
                                ArrayList empty = new ArrayList();

                                qualityTable.DataSource = empty;
                            }

                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                    }
                    if (del.isDeleteValue)
                    {
                        deleteByValue("cassette_quality", "quality_name");
                    }
                    if (del.isDeleteSelectedRows)
                    {
                        if (qualityTable.SelectedRows.Count > 1)
                        {
                            int i = qualityTable.SelectedRows.Count;

                            int N = qualityTable.SelectedRows.Count;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)qualityTable.SelectedRows[0].Cells[0].Value, "cassette_quality", "pk_quality_id", i == N ? true : false))
                                {
                                    qualityTable.Rows.Remove(qualityTable.SelectedRows[0]);
                                }
                                i--;
                            }
                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Строки не выделены.", "Оповещение");
                            return;
                        }
                    }
                    qualityTable.DataSource = ControllerForDB.selectAllFromMainTables("cassette_quality");
                }
                else
                {
                    MessageBox.Show("Таблица пуста.", "Оповещение");
                }
                if (qualityTable.RowCount !=0)
                {
                    qualityTable.Columns[0].HeaderText = "ID";

                    qualityTable.Columns[1].HeaderText = "Качество";
                }
                label13.Text = "Количество полей:" + qualityTable.RowCount;
            }

        }

        private void button41_Click(object sender, EventArgs e)//Удаление "Услуги и цены"
        {
            deleteMenu del = new deleteMenu();

            del.clean();

            del.ShowDialog();

            if (!del.isCanceled)
            {
                if (servpriceTable.RowCount != 0)
                {
                    if (del.isDeleteStr)
                    {
                        deleteRowById((int)servpriceTable.SelectedRows[0].Cells[0].Value, "services_prices", "pk_service_price_id");
                    }
                    if (del.isDeleteManyStr)
                    {
                            int i = servpriceTable.RowCount;

                            int N = servpriceTable.RowCount;

                            int count = 0;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)servpriceTable.Rows[(i - 1)].Cells[0].Value, "services_prices", "pk_service_price_id", i == N ? true : false))
                                {
                                    if (count == 0)
                                    {
                                        MessageBox.Show("Удаление начинается.", "Оповещение");
                                    }
                                    count++;
                                }
                                i--;
                            }
                            if (count == N)
                            {
                                ArrayList empty = new ArrayList();

                                servpriceTable.DataSource = empty;
                            }

                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                        }
                    if (del.isDeleteValue)
                    {
                        deleteByValue("services_prices", "pk_service_price_id");
                    }
                    if (del.isDeleteSelectedRows)
                    {
                        if (servpriceTable.SelectedRows.Count > 1)
                        {
                            int i = servpriceTable.SelectedRows.Count;

                            int N = servpriceTable.SelectedRows.Count;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)servpriceTable.SelectedRows[0].Cells[0].Value, "services_prices", "pk_service_price_id", i == N ? true : false))
                                {
                                    servpriceTable.Rows.Remove(servpriceTable.SelectedRows[0]);
                                }
                                i--;
                            }
                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Строки не выделены.", "Оповещение");
                            return;
                        }
                    }
                    servpriceTable.DataSource = ControllerForDB.selectAllFromMainTables("services_prices");
                }
                else
                {
                    MessageBox.Show("Таблица пуста.Нечего удалять.", "Оповещение");
                }
                if (servpriceTable.RowCount !=0)
                {
                    servpriceTable.Columns[0].HeaderText = "ID";

                    servpriceTable.Columns[1].HeaderText = "Видеопрокат";

                    servpriceTable.Columns[2].HeaderText = "Услуга";

                    servpriceTable.Columns[3].HeaderText = "Цена";
                }
                label15.Text = "Количество полей:" + servpriceTable.RowCount;
            }
        }

        private void deleteCountry_Click(object sender, EventArgs e)//Удаление "Страны"  
        {
            deleteMenu del = new deleteMenu();

            del.clean();

            del.ShowDialog();

            if (!del.isCanceled)
            {
                if (countriesTable.RowCount != 0)
                {
                    if (del.isDeleteStr)
                    {
                        deleteRowById((int)countriesTable.SelectedRows[0].Cells[0].Value, "countries", "pk_country_id");
                    }
                    if (del.isDeleteManyStr)
                    {
                            int i = countriesTable.RowCount;

                            int N = countriesTable.RowCount;

                            int count = 0;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)countriesTable.Rows[(i - 1)].Cells[0].Value, "countries", "pk_country_id", i == N ? true : false))
                                {
                                    if (count == 0)
                                    {
                                        MessageBox.Show("Удаление начинается.", "Оповещение");
                                    }
                                    count++;
                                    //ordersTable.Rows.Remove(ordersTable.SelectedRows[0]);
                                }
                                i--;
                            }
                            if (count == N)
                            {
                                ArrayList empty = new ArrayList();

                                countriesTable.DataSource = empty;
                            }

                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                    }
                    if (del.isDeleteValue)
                    {
                        deleteByValue("countries", "country_name");
                    }
                    if (del.isDeleteSelectedRows)
                    {
                        if (countriesTable.SelectedRows.Count > 1)
                        {
                            int i = countriesTable.SelectedRows.Count;

                            int N = countriesTable.SelectedRows.Count;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)countriesTable.SelectedRows[0].Cells[0].Value, "countries", "pk_country_id", i == N ? true : false))
                                {
                                    countriesTable.Rows.Remove(countriesTable.SelectedRows[0]);
                                }
                                i--;
                            }
                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Строки не выделены.", "Оповещение");
                            return;
                        }
                    }
                    countriesTable.DataSource = ControllerForDB.selectAllFromMainTables("countries");
                }
                else
                {
                    MessageBox.Show("Таблица пуста.Нечего удалять.", "Оповещение");
                }
                if (countriesTable.RowCount!=0)
                {
                    countriesTable.Columns[0].HeaderText = "ID";

                    countriesTable.Columns[1].HeaderText = "Страна";
                }
                label2.Text = "Количество полей:" + countriesTable.RowCount;
            }
        }

        private void button2_Click(object sender, EventArgs e)//Удаление "Студии"
        {
            deleteMenu del = new deleteMenu();

            del.clean();

            del.ShowDialog();

            if (!del.isCanceled)
            {
                if (studiosTable.RowCount != 0)
                {
                    if (del.isDeleteStr)
                    {
                        deleteRowById((int)studiosTable.SelectedRows[0].Cells[0].Value, "studios", "pk_studio_id");
                    }
                    if (del.isDeleteManyStr)
                    {
                            int i = studiosTable.RowCount;

                            int N = studiosTable.RowCount;

                            int count = 0;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)studiosTable.Rows[(i - 1)].Cells[0].Value, "studios", "pk_studio_id", i == N ? true : false))
                                {
                                    if (count == 0)
                                    {
                                        MessageBox.Show("Удаление начинается.", "Оповещение");
                                    }
                                    count++;
                                    //ordersTable.Rows.Remove(ordersTable.SelectedRows[0]);
                                }
                                i--;
                            }
                            if (count == N)
                            {
                                ArrayList empty = new ArrayList();

                                studiosTable.DataSource = empty;
                            }

                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                    }
                    if (del.isDeleteValue)
                    {
                        deleteByValue("studios", "studio_name");
                    }
                    if (del.isDeleteSelectedRows)
                    {
                        if (studiosTable.SelectedRows.Count > 1)
                        {
                            int i = studiosTable.SelectedRows.Count;

                            int N = studiosTable.SelectedRows.Count;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)studiosTable.SelectedRows[0].Cells[0].Value, "studios", "pk_studio_id", i == N ? true : false))
                                {
                                    studiosTable.Rows.Remove(studiosTable.SelectedRows[0]);
                                }
                                i--;
                            }
                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Строки не выделены.", "Оповещение");
                            return;
                        }
                    }
                    studiosTable.DataSource = ControllerForDB.selectAllFromMainTables("studios");
                }
                else
                {
                    MessageBox.Show("Таблица пуста.Нечего удалять.", "Оповещение");
                }
                if (studiosTable.RowCount !=0)
                {
                    studiosTable.Columns[0].HeaderText = "ID";

                    studiosTable.Columns[1].HeaderText = "Студия";

                    studiosTable.Columns[2].HeaderText = "Страна";
                }
                label3.Text = "Количество полей:" + studiosTable.RowCount;
            }
        }

        private void button5_Click(object sender, EventArgs e)//Удаление "Режиссеры"
        {
            deleteMenu del = new deleteMenu();

            del.clean();

            del.ShowDialog();

            if (!del.isCanceled)
            {
                if (producersTable.RowCount != 0)
                {
                    if (del.isDeleteStr)
                    {
                        deleteRowById((int)producersTable.SelectedRows[0].Cells[0].Value, "producers", "pk_producer_id");
                    }
                    if (del.isDeleteManyStr)
                    {
                            int i = producersTable.RowCount;

                            int N = producersTable.RowCount;

                            int count = 0;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)producersTable.Rows[(i - 1)].Cells[0].Value, "producers", "pk_producer_id", i == N ? true : false))
                                {
                                    if (count == 0)
                                    {
                                        MessageBox.Show("Удаление начинается.", "Оповещение");
                                    }
                                    count++;
                                }
                                i--;
                            }
                            if (count == N)
                            {
                                ArrayList empty = new ArrayList();

                                producersTable.DataSource = empty;
                            }

                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                    }
                    if (del.isDeleteValue)
                    {
                        deleteByValue("producers", "studio_name");//ДОДУМАТЬ КАК!
                    }
                    if (del.isDeleteSelectedRows)
                    {
                        if (producersTable.SelectedRows.Count > 1)
                        {
                            int i = producersTable.SelectedRows.Count;

                            int N = producersTable.SelectedRows.Count;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)producersTable.SelectedRows[0].Cells[0].Value, "producers", "pk_producer_id", i == N ? true : false))
                                {
                                    producersTable.Rows.Remove(producersTable.SelectedRows[0]);
                                }
                                i--;
                            }
                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Строки не выделены.", "Оповещение");
                            return;
                        }
                    }
                    producersTable.DataSource = ControllerForDB.selectAllFromMainTables("producers");
                }
                else
                {
                    MessageBox.Show("Таблица пуста.Нечего удалять.", "Оповещение");
                }
                if (producersTable.RowCount !=0)
                {
                    producersTable.Columns[0].HeaderText = "ID";

                    producersTable.Columns[1].HeaderText = "Имя";

                    producersTable.Columns[2].HeaderText = "Фамилия";

                    producersTable.Columns[3].HeaderText = "Отчество";
                }
                label4.Text = "Количество полей:" + producersTable.RowCount;
            }
        }

        private void button8_Click(object sender, EventArgs e)//Удаление "Хозяины"
        {
            deleteMenu del = new deleteMenu();

            del.clean();

            del.ShowDialog();

            if (!del.isCanceled)
            {
                if (ownersTable.RowCount != 0)
                {
                    if (del.isDeleteStr)
                    {
                        deleteRowById((int)ownersTable.SelectedRows[0].Cells[0].Value, "owners", "pk_owner_id");
                    }
                    if (del.isDeleteManyStr)
                    {
                            int i = ownersTable.RowCount;

                            int N = ownersTable.RowCount;

                            int count = 0;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)ownersTable.Rows[(i - 1)].Cells[0].Value, "owners", "pk_owner_id", i == N ? true : false))
                                {
                                    if (count == 0)
                                    {
                                        MessageBox.Show("Удаление начинается.", "Оповещение");
                                    }
                                    count++;
                                }
                                i--;
                            }
                            if (count == N)
                            {
                                ArrayList empty = new ArrayList();

                                ownersTable.DataSource = empty;
                            }

                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                    }
                    if (del.isDeleteValue)
                    {
                        deleteByValue("owners", "studio_name");//ДОДУМАТЬ КАК!
                    }
                    if (del.isDeleteSelectedRows)
                    {
                        if (ownersTable.SelectedRows.Count > 1)
                        {
                            int i = ownersTable.SelectedRows.Count;

                            int N = ownersTable.SelectedRows.Count;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)ownersTable.SelectedRows[0].Cells[0].Value, "owners", "pk_owner_id", i == N ? true : false))
                                {
                                    ownersTable.Rows.Remove(ownersTable.SelectedRows[0]);
                                }
                                i--;
                            }
                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Строки не выделены.", "Оповещение");
                            return;
                        }
                    }
                    ownersTable.DataSource = ControllerForDB.selectAllFromMainTables("owners");
                }
                else
                {
                    MessageBox.Show("Таблица пуста.Нечего удалять.", "Оповещение");
                }
                if (ownersTable.RowCount !=0)
                {
                    ownersTable.Columns[0].HeaderText = "ID";

                    ownersTable.Columns[1].HeaderText = "Имя";

                    ownersTable.Columns[2].HeaderText = "Фамилия";

                    ownersTable.Columns[3].HeaderText = "Отчество";
                }
                label5.Text = "Количество полей:" + ownersTable.RowCount;
            }
        }

        private void button11_Click(object sender, EventArgs e)//Удаление "Услуги"
        {
            deleteMenu del = new deleteMenu();

            del.clean();

            del.ShowDialog();

            if (!del.isCanceled)
            {
                if (servicesTable.RowCount != 0)
                {
                    if (del.isDeleteStr)
                    {
                        deleteRowById((int)servicesTable.SelectedRows[0].Cells[0].Value, "services_view", "pk_service_id");
                    }
                    if (del.isDeleteManyStr)
                    {
                            int i = servicesTable.RowCount;

                            int N = servicesTable.RowCount;

                            int count = 0;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)servicesTable.Rows[(i-1)].Cells[0].Value, "services_view", "pk_service_id", i == N ? true : false))
                                {
                                    if (count == 0)
                                    {
                                        MessageBox.Show("Удаление начинается.", "Оповещение");
                                    }
                                    count++;
                                }
                                i--;
                            }
                            if (count == N)
                            {
                                ArrayList empty = new ArrayList();

                                servicesTable.DataSource = empty;
                            }

                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                    }
                    if (del.isDeleteValue)
                    {
                        deleteByValue("services", "service_name");
                    }
                    if (del.isDeleteSelectedRows)
                    {
                        if (servicesTable.SelectedRows.Count > 1)
                        {
                            int i = servicesTable.SelectedRows.Count;

                            int N = servicesTable.SelectedRows.Count;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)servicesTable.SelectedRows[0].Cells[0].Value, "services_view", "pk_service_id", i == N ? true : false))
                                {
                                    servicesTable.Rows.Remove(servicesTable.SelectedRows[0]);
                                }
                                i--;
                            }
                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Строки не выделены.", "Оповещение");
                            return;
                        }
                    }
                    servicesTable.DataSource = ControllerForDB.selectAllFromMainTables("services");
                }
                else
                {
                    MessageBox.Show("Таблица пуста.Нечего удалять.", "Оповещение");
                }
                if (servicesTable.RowCount !=0)
                {
                    servicesTable.Columns[0].HeaderText = "ID";

                    servicesTable.Columns[1].HeaderText = "Услуга";
                }
                label6.Text = "Количество полей:" + servicesTable.RowCount;
            }
        }

        private void button14_Click(object sender, EventArgs e)//Удаление"Тип собственности"
        {
            deleteMenu del = new deleteMenu();

            del.clean();

            del.ShowDialog();

            if (!del.isCanceled)
            {
                if (propertyTable.RowCount != 0)
                {
                    if (del.isDeleteStr)
                    {
                        deleteRowById((int)propertyTable.SelectedRows[0].Cells[0].Value, "property_type", "pk_property_type_id");
                    }
                    if (del.isDeleteManyStr)
                    {
                            int i = propertyTable.RowCount;

                            int N = propertyTable.RowCount;

                            int count = 0;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)propertyTable.Rows[(i - 1)].Cells[0].Value, "property_type", "pk_property_type_id", i == N ? true : false))
                                {
                                    if (count == 0)
                                    {
                                        MessageBox.Show("Удаление начинается.", "Оповещение");
                                    }
                                    count++;
                                }
                                i--;
                            }
                            if (count == N)
                            {
                                ArrayList empty = new ArrayList();

                                propertyTable.DataSource = empty;
                            }

                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                    }
                    if (del.isDeleteValue)
                    {
                        deleteByValue("property_type", "property_type_name");
                    }
                    if (del.isDeleteSelectedRows)
                    {
                        if (propertyTable.SelectedRows.Count > 1)
                        {
                            int i = propertyTable.SelectedRows.Count;

                            int N = propertyTable.SelectedRows.Count;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)propertyTable.SelectedRows[0].Cells[0].Value, "property_type", "pk_property_type_id", i == N ? true : false))
                                {
                                    propertyTable.Rows.Remove(propertyTable.SelectedRows[0]);
                                }
                                i--;
                            }
                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Строки не выделены.", "Оповещение");
                            return;
                        }
                    }
                    propertyTable.DataSource = ControllerForDB.selectAllFromMainTables("property_type");
                }
                else
                {
                    MessageBox.Show("Таблица пуста.Нечего удалять.", "Оповещение");
                }
                if (propertyTable.RowCount !=0)
                {
                    propertyTable.Columns[0].HeaderText = "ID";

                    propertyTable.Columns[1].HeaderText = "Тип собственности";
                }
                label7.Text = "Количество полей:" + propertyTable.RowCount;
            }
        }

        private void button17_Click(object sender, EventArgs e)//Удаление "Районы"
        {
            deleteMenu del = new deleteMenu();

            del.clean();

            del.ShowDialog();

            if (!del.isCanceled)
            {
                if (districtsTable.RowCount != 0)
                {
                    if (del.isDeleteStr)
                    {
                        deleteRowById((int)districtsTable.SelectedRows[0].Cells[0].Value, "district", "pk_district_id");
                    }
                    if (del.isDeleteManyStr)
                    {
                            int i = districtsTable.RowCount;

                            int N = districtsTable.RowCount;

                            int count = 0;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)districtsTable.Rows[(i - 1)].Cells[0].Value, "district", "pk_district_id", i == N ? true : false))
                                {
                                    if (count == 0)
                                    {
                                        MessageBox.Show("Удаление начинается.", "Оповещение");
                                    }
                                    count++;
                                }
                                i--;
                            }
                            if (count == N)
                            {
                                ArrayList empty = new ArrayList();

                                districtsTable.DataSource = empty;
                            }

                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                    }
                    if (del.isDeleteValue)
                    {
                        deleteByValue("district", "district_name");
                    }
                    if (del.isDeleteSelectedRows)
                    {
                        if (districtsTable.SelectedRows.Count > 1)
                        {
                            int i = districtsTable.SelectedRows.Count;

                            int N = districtsTable.SelectedRows.Count;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)districtsTable.SelectedRows[0].Cells[0].Value, "district", "pk_district_id", i == N ? true : false))
                                {
                                    districtsTable.Rows.Remove(districtsTable.SelectedRows[0]);
                                }
                                i--;
                            }
                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Строки не выделены.", "Оповещение");
                            return;
                        }
                    }
                    districtsTable.DataSource = ControllerForDB.selectAllFromMainTables("district");
                }
                else
                {
                    MessageBox.Show("Таблица пуста.Нечего удалять.", "Оповещение");
                }
                if (districtsTable.RowCount !=0)
                {
                    districtsTable.Columns[0].HeaderText = "ID";

                    districtsTable.Columns[1].HeaderText = "Район";
                }
                label8.Text = "Количество полей:" + districtsTable.RowCount;
            }
        }

        private void button20_Click(object sender, EventArgs e)//Удаление "Фильмы"
        {
            deleteMenu del = new deleteMenu();

            del.clean();

            del.ShowDialog();

            if (!del.isCanceled)
            {
                if (filmsTable.RowCount != 0)
                {
                    if (del.isDeleteStr)
                    {
                        deleteRowById((int)filmsTable.SelectedRows[0].Cells[0].Value, "films", "pk_film_id");
                    }
                    if (del.isDeleteManyStr)
                    {
                            int i = filmsTable.RowCount;

                            int N = filmsTable.RowCount;

                            int count = 0;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)filmsTable.Rows[(i - 1)].Cells[0].Value, "films", "pk_film_id", i == N ? true : false))
                                {
                                    if (count == 0)
                                    {
                                        MessageBox.Show("Удаление начинается.", "Оповещение");
                                    }
                                    count++;
                                }
                                i--;
                            }
                            if (count == N)
                            {
                                ArrayList empty = new ArrayList();

                                filmsTable.DataSource = empty;
                            }

                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                    }
                    if (del.isDeleteValue)
                    {
                        deleteByValue("films", "film_name");
                    }
                    if (del.isDeleteSelectedRows)
                    {
                        if (filmsTable.SelectedRows.Count > 1)
                        {
                            int i = filmsTable.SelectedRows.Count;

                            int N = filmsTable.SelectedRows.Count;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)filmsTable.SelectedRows[0].Cells[0].Value, "films", "pk_film_id", i == N ? true : false))
                                {
                                    filmsTable.Rows.Remove(filmsTable.SelectedRows[0]);
                                }
                                i--;
                            }
                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Строки не выделены.", "Оповещение");
                            return;
                        }
                    }
                    filmsTable.DataSource = ControllerForDB.selectAllFromMainTables("films");
                }
                else
                {
                    MessageBox.Show("Таблица пуста.Нечего удалять.", "Оповещение");
                }
                if (filmsTable.RowCount !=0)
                {
                    filmsTable.Columns[0].HeaderText = "ID";

                    filmsTable.Columns[1].HeaderText = "Название";

                    filmsTable.Columns[2].HeaderText = "Фамилия режиссера";

                    filmsTable.Columns[3].HeaderText = "Имя режиссера";

                    filmsTable.Columns[4].HeaderText = "Отчество режиссера";

                    filmsTable.Columns[5].HeaderText = "Студия";

                    filmsTable.Columns[6].HeaderText = "Страна студии";

                    filmsTable.Columns[7].HeaderText = "Год выпуска";

                    filmsTable.Columns[8].HeaderText = "Продолжительность";

                    filmsTable.Columns[9].HeaderText = "Информация";
                }
                label9.Text = "Количество полей:" + filmsTable.RowCount;
            }
        }

        private void button23_Click(object sender, EventArgs e)//Удаление "Кассеты"
        {
            deleteMenu del = new deleteMenu();

            del.clean();

            del.ShowDialog();

            if (!del.isCanceled)
            {
                if (cassettesTable.RowCount != 0)
                {
                    if (del.isDeleteStr)
                    {
                        deleteRowById(int.Parse(cassettesTable.SelectedRows[0].Cells[0].Value.ToString()), "cassettes", "pk_cassette_id");//ПЕРЕДЕЛАТЬ!
                    }
                    if (del.isDeleteManyStr)
                    {
                            int i = cassettesTable.RowCount;

                            int N = cassettesTable.RowCount;

                            int count = 0;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)cassettesTable.Rows[(i - 1)].Cells[0].Value, "cassettes", "pk_cassette_id", i == N ? true : false))
                                {
                                    if (count == 0)
                                    {
                                        MessageBox.Show("Удаление начинается.", "Оповещение");
                                    }
                                    count++;
                                }
                                i--;
                            }
                            if (count == N)
                            {
                                ArrayList empty = new ArrayList();

                                cassettesTable.DataSource = empty;
                            }
                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                    }
                    if (del.isDeleteValue)
                    {
                        deleteByValue("cassettes", "pk_cassette_id");
                    }
                    if (del.isDeleteSelectedRows)
                    {
                        if (cassettesTable.SelectedRows.Count > 1)
                        {
                            int i = cassettesTable.SelectedRows.Count;

                            int N = cassettesTable.SelectedRows.Count;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)cassettesTable.SelectedRows[0].Cells[0].Value, "cassettes", "pk_cassette_id", i == N ? true : false))
                                {
                                    cassettesTable.Rows.Remove(cassettesTable.SelectedRows[0]);
                                }
                                i--;
                            }
                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Строки не выделены.", "Оповещение");
                            return;
                        }
                    }
                    cassettesTable.DataSource = ControllerForDB.selectAllFromMainTables("cassettes");
                }
                else
                {
                    MessageBox.Show("Таблица пуста.Нечего удалять.", "Оповещение");
                }
                if (cassettesTable.RowCount!=0)
                {
                    cassettesTable.Columns[0].HeaderText = "ID";

                    cassettesTable.Columns[1].HeaderText = "Качество кассеты";

                    cassettesTable.Columns[2].HeaderText = "Фото";

                    cassettesTable.Columns[3].HeaderText = "Цена кассеты";

                    cassettesTable.Columns[4].HeaderText = "Спрос";

                    cassettesTable.Columns[5].HeaderText = "Фильм";
                }
                label10.Text = "Количество полей:" + cassettesTable.RowCount;
            }
        }

        private void button26_Click(object sender, EventArgs e)//Удаление "Сделки"
        {
            deleteMenu del = new deleteMenu();

            del.clean();

            del.ShowDialog();

            if (!del.isCanceled)
            {
                if (ordersTable.RowCount != 0)
                {
                    if (del.isDeleteStr)
                    {
                        deleteRowById((int)ordersTable.SelectedRows[0].Cells[0].Value, "deals", "pk_deal_id");
                    }
                    if (del.isDeleteManyStr)
                    {
                            int i = ordersTable.RowCount;

                            int N = ordersTable.RowCount;

                            int count = 0;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)ordersTable.Rows[(i - 1)].Cells[0].Value, "deals", "pk_deal_id", i == N ? true : false))
                                {
                                    if (count == 0)
                                    {
                                        MessageBox.Show("Удаление начинается.", "Оповещение");
                                    }
                                    count++;
                                }
                                i--;
                            }
                            if (count == N)
                            {
                                ArrayList empty = new ArrayList();

                                ordersTable.DataSource = empty;
                            }

                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                    }
                    if (del.isDeleteValue)
                    {
                        deleteByValue("deals", "pk_deal_id");
                    }
                    if (del.isDeleteSelectedRows)
                    {
                        if (ordersTable.SelectedRows.Count > 1)
                        {
                            int i = ordersTable.SelectedRows.Count;

                            int N = ordersTable.SelectedRows.Count;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)ordersTable.SelectedRows[0].Cells[0].Value, "deals", "pk_deal_id", i == N ? true : false))
                                {
                                    ordersTable.Rows.Remove(ordersTable.SelectedRows[0]);
                                }
                                i--;
                            }
                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Строки не выделены.", "Оповещение");
                            return;
                        }
                    }
                    ordersTable.DataSource = ControllerForDB.selectAllFromMainTables("deals");
                }
                else
                {
                    MessageBox.Show("Таблица пуста.Нечего удалять.", "Оповещение");
                }
                if (ordersTable.RowCount !=0)
                {
                    ordersTable.Columns[0].HeaderText = "ID";

                    ordersTable.Columns[1].HeaderText = "Видеопрокат";

                    ordersTable.Columns[2].HeaderText = "ID кассеты";

                    ordersTable.Columns[3].HeaderText = "Фильм";

                    ordersTable.Columns[4].HeaderText = "Квитанция";

                    ordersTable.Columns[5].HeaderText = "Дата заказа";

                    ordersTable.Columns[6].HeaderText = "Услуга";

                    ordersTable.Columns[7].HeaderText = "Цена";
                }
                label11.Text = "Количество полей:" + ordersTable.RowCount;
            }
        }

        private void button29_Click(object sender, EventArgs e)//Удаление "Видеопрокаты"
        {
            deleteMenu del = new deleteMenu();

            del.clean();

            del.ShowDialog();

            if (!del.isCanceled)
            {
                if (videoTable.RowCount != 0)
                {
                    if (del.isDeleteStr)
                    {
                        deleteRowById((int)videoTable.SelectedRows[0].Cells[0].Value, "video_rental", "pk_video_rental_id");
                    }
                    if (del.isDeleteManyStr)
                    {
                            int i = videoTable.RowCount;

                            int N = videoTable.RowCount;

                            int count = 0;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)videoTable.Rows[(i - 1)].Cells[0].Value, "video_rental", "pk_video_rental_id", i == N ? true : false))
                                {
                                    if (count == 0)
                                    {
                                        MessageBox.Show("Удаление начинается.", "Оповещение");
                                    }
                                    count++;
                                }
                                i--;
                            }
                            if (count == N)
                            {
                                ArrayList empty = new ArrayList();

                                videoTable.DataSource = empty;
                            }
                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                    }
                    if (del.isDeleteValue)
                    {
                        deleteByValue("video_rental", "video_caption");
                    }
                    if (del.isDeleteSelectedRows)
                    {
                        if (videoTable.SelectedRows.Count > 1)
                        {
                            int i = videoTable.SelectedRows.Count;

                            int N = videoTable.SelectedRows.Count;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)videoTable.SelectedRows[0].Cells[0].Value, "video_rental", "pk_video_rental_id", i == N ? true : false))
                                {
                                    videoTable.Rows.Remove(videoTable.SelectedRows[0]);
                                }
                                i--;
                            }
                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Строки не выделены.", "Оповещение");
                            return;
                        }
                    }
                    videoTable.DataSource = ControllerForDB.selectAllFromMainTables("video_rental");
                }
                else
                {
                    MessageBox.Show("Таблица пуста.Нечего удалять.", "Оповещение");
                }
                if (videoTable.RowCount!=0)
                {
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
                label12.Text = "Количество полей:" + videoTable.RowCount;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            deleteMenu del = new deleteMenu();

            del.clean();

            del.ShowDialog();

            if (!del.isCanceled)
            {
                if (imagesTable.RowCount != 0)
                {
                    if (del.isDeleteStr)
                    {
                        deleteRowById((int)imagesTable.SelectedRows[0].Cells[0].Value, "cassette_photo", "pk_photo_id");
                    }
                    if (del.isDeleteManyStr)
                    {
                            int i = imagesTable.RowCount;

                            int N = imagesTable.RowCount;

                            int count = 0;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)imagesTable.Rows[(i - 1)].Cells[0].Value, "cassette_photo", "pk_photo_id", i == N ? true : false))
                                {
                                    if (count == 0)
                                    {
                                        MessageBox.Show("Удаление начинается.", "Оповещение");
                                    }
                                    count++;
                                }
                                i--;
                            }
                            if (count == N)
                            {
                                ArrayList empty = new ArrayList();

                                imagesTable.DataSource = empty;
                            }

                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                    }
                    if (del.isDeleteValue)
                    {
                        deleteByValue("cassette_photo", "pk_photo_id");
                    }
                    if (del.isDeleteSelectedRows)
                    {
                        if (imagesTable.SelectedRows.Count > 1)//Может !=0? Но всегда будет минимум одна выделенная
                        {
                            int i = imagesTable.SelectedRows.Count;

                            int N = imagesTable.SelectedRows.Count;

                            while (i != 0)
                            {
                                if (deleteRowsById((int)imagesTable.SelectedRows[0].Cells[0].Value, "cassette_photo", "pk_photo_id", i == N ? true : false))
                                {
                                    imagesTable.Rows.Remove(imagesTable.SelectedRows[0]);
                                }
                                i--;
                            }
                            if (!ControllerForDB.isCanceledDelete)
                            {
                                MessageBox.Show($"Строки успешно удалены.", "Оповещение");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Строки не выделены.", "Оповещение");

                            return;
                        }
                    }
                    imagesTable.DataSource = ControllerForDB.selectAllFromMainTables("cassette_photo");
                }
                else
                {
                    MessageBox.Show("Таблица пуста.", "Оповещение");
                }
                if (imagesTable.RowCount !=0)
                {
                    imagesTable.Columns[0].HeaderText = "ID";

                    imagesTable.Columns[1].HeaderText = "Фото";
                }
                label14.Text = "Количество полей:" + imagesTable.RowCount;
            }

        }

        public void deleteByValue(string table, string what_change)
        {
            deleteByValue del = new deleteByValue();

            AddOrEditThreeColumns add = new AddOrEditThreeColumns();

            switch (table)
            {
                case "cassette_photo":
                    {
                        del.GB.Text = "Введите ID фото";
                        del.mainL1.Text = "ID фото";
                        break;
                    }
                case "cassette_quality":
                    {
                        del.GB.Text = "Введите качество";
                        del.mainL1.Text = "Качество";
                        break;
                    }
                case "cassettes":
                    {
                        del.GB.Text = "Введите ID кассеты";
                        del.mainL1.Text = "ID кассеты";
                        break;
                    }
                case "countries":
                    {
                        del.GB.Text = "Введите страну";
                        del.mainL1.Text = "ID страны";
                        break;
                    }
                case "deals":
                    {
                        del.GB.Text = "Введите ID сделки";
                        del.mainL1.Text = "ID сделки";
                        break;
                    }
                case "district":
                    {
                        del.GB.Text = "Введите район";
                        del.mainL1.Text = "Район";
                        break;
                    }
                case "films":
                    {
                        del.GB.Text = "Введите фильм";//Подумать над годом!
                        del.mainL1.Text = "Фильм";
                        break;
                    }
                case "owners":
                case "producers":
                    {
                        add.mainL2.Text = "Удаление по значению";
                        add.button1.Text = "Удалить";
                        break;
                    }
                case "property_type":
                    {
                        del.GB.Text = "Введите тип собственности";
                        del.mainL1.Text = "Тип собственности";
                        break;
                    }
                case "services":
                    {
                        del.GB.Text = "Введите услугу";
                        del.mainL1.Text = "Услуга";
                        break;
                    }
                case "services_prices":
                    {
                        del.GB.Text = "Введите ID услуги и цены";//Спросить!
                        del.mainL1.Text = "ID услуги и цены";
                        break;
                    }
                case "studios":
                    {
                        del.GB.Text = "Введите студию";//Спросить!
                        del.mainL1.Text = "Студия";
                        break;
                    }
                case "video_rental":
                    {
                        del.GB.Text = "Введите название видеопроката";//Спросить!
                        del.mainL1.Text = "Название";
                        break;
                    }
            }
        del:
            if(table.Equals("producers")|| table.Equals("owners"))
            {
                add.ShowDialog();

                if (!add.isCanceled && add.isEnabled && add.fam.Text != String.Empty&& add.name.Text != String.Empty)
                {
                    if (ControllerForDB.deleteByValue(add.name.Text, table, what_change,add.fam.Text,add.patronymic.Text))
                    {
                            MessageBox.Show($"Строка удалена из таблицы.", "Оповещение");
                    }
                }
                else
                {
                    if (del.isEnabled)
                    {
                        MessageBox.Show("Вы не ввели фамилию или имя.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        goto del;
                    }
                    return;
                }
            }
            else
            {
                del.ShowDialog();

                if (!del.isCanceled && del.isEnabled && del.valueTB.Text != String.Empty)
                {
                    if (ControllerForDB.deleteByValue(del.valueTB.Text, table, what_change))
                    {
                        if (table != "films")
                        {
                            MessageBox.Show($"Строка со значением \"{del.valueTB.Text}\" удалена из таблицы.", "Оповещение");
                        }
                    }
                }
                else
                {
                    if (del.isEnabled)
                    {
                        MessageBox.Show("Вы не ввели значение.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        goto del;
                    }
                    return;
                }
            }
            
        }

        public bool deleteRowById(int index, string table, string id_value)//Функция удаления с выводом информации
        {
            if (ControllerForDB.deleteById(index, table, id_value, true))
            {
                MessageBox.Show("Строка удалена.", "Оповещение");

                return true;
            }
            else
            {
                if (ControllerForDB.isCanceledDelete)
                {
                    return false;
                }

                MessageBox.Show("По каким-то причинам строка не добавлена.", "Оповещение");
            }
            return false;
        }

        public bool deleteRowsById(int index, string table, string id_value, bool isM)//Функция удаления без вывода информации
        {
            if (ControllerForDB.deleteById(index, table, id_value, isM))
            {
                return true;
            }
            else
            {
                if (ControllerForDB.isCanceledDelete)
                {
                    return false;
                }
            }
            return false;
        }
        //Поиск и фильтр
        private void button43_Click(object sender, EventArgs e)//Студии
        {
            SearchAndFilterStudio d = new SearchAndFilterStudio();

            d.ShowDialog();

            if (!d.isCanceled && d.isEnabled)
            {
                studiosTable.DataSource = ControllerForDB.searchStudio(d.search.Text, d.countryCB.Text);

                if (studiosTable.RowCount != 0)
                {
                    studiosTable.Columns[0].HeaderText = "ID";

                    studiosTable.Columns[1].HeaderText = "Студия";

                    studiosTable.Columns[2].HeaderText = "Страна";
                }

                MessageBox.Show("Результаты поиска в таблице.", "Оповещение");

                if (!label3.Text.Equals(strAmount)) { label3.Text = strAmount; }

                label3.Text += studiosTable.RowCount;
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            ControllerForDB.generateOrders(10001);

            if (!label11.Text.Equals(strAmount)) { label11.Text = strAmount; }

            ordersTable.DataSource = ControllerForDB.selectAllFromMainTables("deals");

            if (ordersTable.RowCount != 0)
            {
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

        private void button58_Click(object sender, EventArgs e)
        {
            ControllerForDB.generateServicesPrices();

            servpriceTable.DataSource = ControllerForDB.selectAllFromMainTables("services_prices");

            if (servpriceTable.RowCount != 0)
            {
                servpriceTable.Columns[0].HeaderText = "ID";

                servpriceTable.Columns[1].HeaderText = "Видеопрокат";

                servpriceTable.Columns[2].HeaderText = "Услуга";

                servpriceTable.Columns[3].HeaderText = "Цена";
            }

            label15.Text = "Количество полей: " + servpriceTable.RowCount;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            ControllerForDB.generatePropType();

            if (!label7.Text.Equals(strAmount)) { label7.Text = strAmount; }

            propertyTable.DataSource = ControllerForDB.selectAllFromMainTables("property_type");

            if (propertyTable.RowCount != 0)
            {
                propertyTable.Columns[0].HeaderText = "ID";

                propertyTable.Columns[1].HeaderText = "Тип собственности";
            }
            label7.Text += ControllerForDB.amount;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            ControllerForDB.generateCountries();

            if (!label2.Text.Equals(strAmount)) { label2.Text = strAmount; }

            countriesTable.DataSource = ControllerForDB.selectAllFromMainTables("countries");

            if (countriesTable.RowCount != 0)
            {
                countriesTable.Columns[0].HeaderText = "ID";

                countriesTable.Columns[1].HeaderText = "Страна";
            }

            label2.Text += ControllerForDB.amount;
        }

        private void button61_Click(object sender, EventArgs e)
        {
            ControllerForDB.generateDistricts();//СДЕЛАТЬ BOOL!

            if (!label8.Text.Equals(strAmount)) { label8.Text = strAmount; }

            districtsTable.DataSource = ControllerForDB.selectAllFromMainTables("district");

            if (districtsTable.RowCount != 0)
            {
                districtsTable.Columns[0].HeaderText = "ID";

                districtsTable.Columns[1].HeaderText = "Район";
            }

            label8.Text += ControllerForDB.amount;
        }

        private void button62_Click(object sender, EventArgs e)
        {
            ControllerForDB.generateServices();

            if (!label6.Text.Equals(strAmount)) { label6.Text = strAmount; }

            servicesTable.DataSource = ControllerForDB.selectAllFromMainTables("services");

            if (servicesTable.RowCount != 0)
            {
                servicesTable.Columns[0].HeaderText = "ID";

                servicesTable.Columns[1].HeaderText = "Услуга";
            }

            label6.Text += ControllerForDB.amount;
        }

        private void button63_Click(object sender, EventArgs e)
        {

            ControllerForDB.generateQuality();

            qualityTable.DataSource = ControllerForDB.selectAllFromMainTables("cassette_quality");

            if (qualityTable.RowCount != 0)
            {
                qualityTable.Columns[0].HeaderText = "ID";

                qualityTable.Columns[1].HeaderText = "Качество";
            }

            label13.Text =strAmount+ qualityTable.RowCount;
        }

        private void button45_Click(object sender, EventArgs e)//Поиск "Видеопрокаты"
        {
            AddOrEditVideoRental add = new AddOrEditVideoRental();

            add.mainL1.Text = "Поиск видеопроката";

            add.button1.Text = "Поиск";

            add.districtCB.SelectedIndex = add.propCB.SelectedIndex = -1;

            add.timeStart.Hide();

            add.timeEnd.Hide();

            add.groupBox9.Hide();

            add.adress1.Hide();

            add.amountEmpl.Hide();

            add.timeStart1.Visible = add.timeStart2.Visible = add.fam.Visible = add.nam.Visible = add.groupBox10.Visible=add.amountEmpl1.Visible=add.amountEmpl2.Visible = true;

            add.timeEnd1.Visible = add.timeEnd2.Visible = true;

        m1:

            add.clean();

            add.ShowDialog();

            int? n1 = null, n2 = null;

            if (!add.isCanceled && add.isEnabled)
            {

                if (add.timeStart1.Text != String.Empty)
                {
                    try
                    {
                        n1 = int.Parse(add.timeStart1.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Время начала работы видеопроката введено некорректно.");

                        goto m1;
                    }
                }
                if (add.timeStart2.Text != String.Empty)
                {
                    try
                    {
                        n2 = int.Parse(add.timeStart2.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Время начала работы видеопроката введено некорректно.");
                        goto m1;
                    }
                }

                int? m1 = null, m2 = null;

                if (add.timeEnd2.Text != String.Empty)
                {
                    try
                    {
                        m2 = int.Parse(add.timeEnd2.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Время окончания работы видеопроката введено некорректно.");
                        goto m1;
                    }
                }

                if (add.timeEnd1.Text != String.Empty)
                {
                    try
                    {
                        m1 = int.Parse(add.timeEnd1.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Время окончания работы видеопроката введено некорректно.");
                        goto m1;
                    }
                }
                if (n1 != null && n2 != null)
                {
                    if ((n2 - n1) < 0)
                    {
                        MessageBox.Show("Время открытия 2 должно быть больше времени открытия 1.", "Error");

                        goto m1;
                    }
                }
                if (m1 != null && m2 != null)
                {
                    if (m2 - m1 < 0)
                    {
                        MessageBox.Show("Время открытия 2 должно быть больше времени открытия 1.", "Error");

                        goto m1;
                    }
                }

                if (add.amountEmpl1.Text != String.Empty)
                {
                    try
                    {
                        m1 = int.Parse(add.amountEmpl1.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Количество работников введено некорректно.");
                        goto m1;
                    }
                }

                if (add.amountEmpl2.Text != String.Empty)
                {
                    try
                    {
                        m1 = int.Parse(add.amountEmpl2.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Количество работников введено некорректно.");
                        goto m1;
                    }
                }

                if (m1 != null && m2 != null)
                {
                    if ((m2 - m1) < 0)
                    {
                        MessageBox.Show("Количество работников 2 должно быть больше количества работников 1.", "Error");

                        goto m1;
                    }
                }

                videoTable.DataSource = ControllerForDB.searchVideoRental(add.title.Text, add.timeStart1.Text, add.timeStart2.Text, add.timeEnd1.Text, add.timeEnd2.Text, add.name.Text, add.family.Text, add.patron.Text,
                    add.districtCB.Text, add.propCB.Text, add.number.Text, add.license.Text, add.amountEmpl1.Text, add.amountEmpl2.Text);

                if (videoTable.RowCount != 0)
                {
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
            }
            else
            {
                return;
            }

            label12.Text = strAmount + videoTable.RowCount;
        }


        private void button56_Click(object sender, EventArgs e)//Поиск "Услуги и цены"
        {
            addOrEditServicesPrices add = new addOrEditServicesPrices();

            add.mainL1.Text = "Поиск услуг и цен";

            add.button1.Text = "Поиск";

            add.groupBox1.Hide();

            add.priceS.Visible = true;

            add.rentalCB.SelectedIndex = add.serviceCB.SelectedIndex = -1;

        m1:

            add.clean();

            add.ShowDialog();

            if (!add.isCanceled && add.isEnabled)
            {
                if (add.more.Text != String.Empty)
                {
                    try
                    {
                        double.Parse(add.more.Text);

                        double.Parse(add.more.Text);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Вы ввели цену неверно. Возможно, вы ввели цену через '.'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        goto m1;
                    }
                }
                servpriceTable.DataSource = ControllerForDB.searchServicesPrices(add.rentalCB.Text, add.serviceCB.Text, add.more.Text, add.less.Text);

                if (servpriceTable.RowCount != 0)
                {
                    servpriceTable.Columns[0].HeaderText = "ID";

                    servpriceTable.Columns[1].HeaderText = "Видеопрокат";

                    servpriceTable.Columns[2].HeaderText = "Услуга";

                    servpriceTable.Columns[3].HeaderText = "Цена";
                }
            }
            else
            {
                return;
            }
            label15.Text = "Количество полей: " + servpriceTable.RowCount;
        }

        private void button54_Click(object sender, EventArgs e)//Поиск "Качество"
        {
            AddOrEditOneColumn add = new AddOrEditOneColumn();

            add.mainL1.Text = "Поиск качества";

            add.button1.Text = "Поиск";

            add.groupBox1.Text = "Качество";

            add.clean();

            add.ShowDialog();

            if (!add.isCanceled && add.isEnabled)
            {
                qualityTable.DataSource = ControllerForDB.searchDictionary(add.countryTB.Text, "quality_view", "quality_name");

                if (qualityTable.RowCount != 0)
                {
                    qualityTable.Columns[0].HeaderText = "ID";

                    qualityTable.Columns[1].HeaderText = "Качество";
                }
            }
            else
            {
                return;
            }

            label13.Text = "Количество полей:" + qualityTable.RowCount;
        }

        private void button53_Click(object sender, EventArgs e)//Поиск "Страны"
        {
            AddOrEditOneColumn add = new AddOrEditOneColumn();

            add.mainL1.Text = "Поиск страны";

            add.button1.Text = "Поиск";

            add.groupBox1.Text = "Страна";

            add.clean();

            add.ShowDialog();

            if (!add.isCanceled && add.isEnabled)
            {
                countriesTable.DataSource = ControllerForDB.searchDictionary(add.countryTB.Text, "countries_view", "country_name");

                if (countriesTable.RowCount != 0)
                {
                    countriesTable.Columns[0].HeaderText = "ID";

                    countriesTable.Columns[1].HeaderText = "Страна";
                }
            }
            else
            {
                return;
            }

            label2.Text = "Количество полей:" + countriesTable.RowCount;
        }

        private void button51_Click(object sender, EventArgs e)//Поиск "Услуги"
        {
            AddOrEditOneColumn add = new AddOrEditOneColumn();

            add.mainL1.Text = "Поиск услуги";

            add.button1.Text = "Поиск";

            add.groupBox1.Text = "Услуга";

            add.clean();

            add.ShowDialog();

            if (!add.isCanceled && add.isEnabled)
            {
                servicesTable.DataSource = ControllerForDB.searchDictionary(add.countryTB.Text, "services_view", "service_name");

                if (servicesTable.RowCount != 0)
                {
                    servicesTable.Columns[0].HeaderText = "ID";

                    servicesTable.Columns[1].HeaderText = "Услуга";
                }
            }
            else
            {
                return;
            }

            label6.Text = "Количество полей:" + servicesTable.RowCount;
        }

        private void button50_Click(object sender, EventArgs e)//Поиск "Тип собственности"
        {
            AddOrEditOneColumn add = new AddOrEditOneColumn();

            add.mainL1.Text = "Поиск типа собственности";

            add.button1.Text = "Поиск";

            add.groupBox1.Text = "Тип собственности";

            add.clean();

            add.ShowDialog();

            if (!add.isCanceled && add.isEnabled)
            {
                propertyTable.DataSource = ControllerForDB.searchDictionary(add.countryTB.Text, "property_view", "property_type_name");

                if (propertyTable.RowCount != 0)
                {
                    propertyTable.Columns[0].HeaderText = "ID";

                    propertyTable.Columns[1].HeaderText = "Тип собственности";
                }
            }
            else
            {
                return;
            }

            label7.Text = "Количество полей:" + propertyTable.RowCount;
        }

        private void button49_Click(object sender, EventArgs e)//Поиск "Районы"
        {
            AddOrEditOneColumn add = new AddOrEditOneColumn();

            add.mainL1.Text = "Поиск района";

            add.button1.Text = "Поиск";

            add.groupBox1.Text = "Район";

            add.clean();

            add.ShowDialog();

            if (!add.isCanceled && add.isEnabled)
            {
                districtsTable.DataSource = ControllerForDB.searchDictionary(add.countryTB.Text, "district_view", "district_name");

                if (districtsTable.RowCount != 0)
                {
                    districtsTable.Columns[0].HeaderText = "ID";

                    districtsTable.Columns[1].HeaderText = "Район";
                }
            }
            else
            {
                return;
            }

            label8.Text = "Количество полей:" + districtsTable.RowCount;
        }

        private void button55_Click(object sender, EventArgs e)//Поиск "Фото"
        {
            AddOrEditOneColumn add = new AddOrEditOneColumn();

            add.mainL1.Text = "Поиск фото по ID";

            add.button1.Text = "Поиск";

            add.groupBox1.Text = "ID";

            add.clean();

            add.ShowDialog();

            if (!add.isCanceled && add.isEnabled)
            {
                imagesTable.DataSource = ControllerForDB.searchDictionary(add.countryTB.Text, "images_view", "pk_photo_id");

                if (imagesTable.RowCount != 0)
                {
                    imagesTable.Columns[0].HeaderText = "ID";

                    imagesTable.Columns[1].HeaderText = "Фото";
                }

            }
            else
            {
                return;
            }

            label14.Text = "Количество полей:" + imagesTable.RowCount;
        }

        private void button44_Click(object sender, EventArgs e)//Поиск "Режиссеры"
        {
            AddOrEditThreeColumns add = new AddOrEditThreeColumns();

            add.mainL2.Text = "Поиск режиссера";

            add.button1.Text = "Поиск";

            add.clean();

            add.ShowDialog();

            if (!add.isCanceled && add.isEnabled)
            {
                producersTable.DataSource = ControllerForDB.searchPeopleTable("producers", add.fam.Text, add.name.Text, add.patronymic.Text);

                if (producersTable.RowCount != 0)
                {
                    producersTable.Columns[0].HeaderText = "ID";

                    producersTable.Columns[1].HeaderText = "Имя";

                    producersTable.Columns[2].HeaderText = "Фамилия";

                    producersTable.Columns[3].HeaderText = "Отчество";
                }
            }
            else
            {
                return;
            }

            label4.Text = "Количество полей:" + producersTable.RowCount;
        }

        private void button52_Click(object sender, EventArgs e)//Поиск "Хоязева"
        {
            AddOrEditThreeColumns add = new AddOrEditThreeColumns();

            add.mainL2.Text = "Поиск хозяина";

            add.button1.Text = "Поиск";

            add.clean();

            add.ShowDialog();

            if (!add.isCanceled && add.isEnabled)
            {
                ownersTable.DataSource = ControllerForDB.searchPeopleTable("owners", add.fam.Text, add.name.Text, add.patronymic.Text);

                if (ownersTable.RowCount != 0)
                {
                    ownersTable.Columns[0].HeaderText = "ID";

                    ownersTable.Columns[1].HeaderText = "Имя";

                    ownersTable.Columns[2].HeaderText = "Фамилия";

                    ownersTable.Columns[3].HeaderText = "Отчество";
                }
            }
            else
            {
                return;
            }

            label5.Text = "Количество полей:" + ownersTable.RowCount;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            addOrEditFilm add = new addOrEditFilm();

            add.button1.Text = "Поиск";

            add.mainL1.Text = "Поиск фильма";

            add.duration.Hide();

            add.year.Hide();

            add.adress1.Hide();

            add.year1.Visible = add.year2.Visible = add.dur1.Visible = add.dur2.Visible = true;

            add.groupBox5.Visible = add.groupBox6.Visible = add.groupBox7.Visible = true;

            add.groupBox2.Hide();

            add.studioCB.SelectedIndex = -1;

        m1:

            add.clean();

            add.ShowDialog();

            int? n1 = null, n2 = null;

            if (add.dur1.Text != String.Empty)
            {
                try
                {
                    n1 = int.Parse(add.dur1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Продолжительность фильма введена некорректно.");

                    goto m1;
                }
            }
            if (add.dur2.Text != String.Empty)
            {
                try
                {
                    n2 = int.Parse(add.dur2.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Продолжительность фильма введена некорректно.");
                    goto m1;
                }
            }
            if ((add.year1.Text.Length > 0 && add.year1.Text.Length < 4) || (add.year2.Text.Length > 0 && add.year2.Text.Length < 4))
            {
                MessageBox.Show("Некорректный ввод года.", "Error");

                goto m1;
            }

            int? m1 = null, m2 = null;

            if (add.year2.Text != String.Empty)
            {
                try
                {
                    m2 = int.Parse(add.year2.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Год введен некорректно.");
                    goto m1;
                }
            }

            if (add.year1.Text != String.Empty)
            {
                try
                {
                    m1 = int.Parse(add.year1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Год введен некорректно.");
                    goto m1;
                }
            }

            if (n1 != null && n2 != null)
            {
                if ((n2 - n1) < 0)
                {
                    MessageBox.Show("Длительность 2 должна быть больше длительности 1.", "Error");

                    goto m1;
                }
            }
            if (m1 != null && m2 != null)
            {
                if (m2 - m1 < 0)
                {
                    MessageBox.Show("Год 2 должен быть больше года 1.", "Error");

                    goto m1;
                }
            }

            if (!add.isCanceled && add.isEnabled)
            {
                try
                {
                    filmsTable.DataSource = ControllerForDB.searchFilms(add.title.Text, add.studioCB.Text == "" ? "" : add.studio_list[add.studioCB.Text].ToString(), add.fam.Text, add.name.Text, add.patron.Text, add.year1.Text, add.year2.Text, add.info.Text, add.dur1.Text, add.dur2.Text);

                    if (filmsTable.RowCount != 0)
                    {
                        filmsTable.Columns[0].HeaderText = "ID";

                        filmsTable.Columns[1].HeaderText = "Название";

                        filmsTable.Columns[2].HeaderText = "Фамилия режиссера";

                        filmsTable.Columns[3].HeaderText = "Имя режиссера";

                        filmsTable.Columns[4].HeaderText = "Отчество режиссера";

                        filmsTable.Columns[5].HeaderText = "Студия";

                        filmsTable.Columns[6].HeaderText = "Страна студии";

                        filmsTable.Columns[7].HeaderText = "Год выпуска";

                        filmsTable.Columns[8].HeaderText = "Продолжительность";

                        filmsTable.Columns[9].HeaderText = "Информация";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Такой студии не существует!","Error");

                    return;
                }
            }
            else
            {
                return;
            }

            label9.Text = "Количество полей:" + filmsTable.RowCount;
        }

        private void button64_Click(object sender, EventArgs e)//Генерация "Фото"
        {
            if (imagesTable.RowCount == 0)
            {
                ControllerForDB.generatePics(100);

                imagesTable.DataSource = ControllerForDB.selectAllFromMainTables("cassette_photo");

                if (imagesTable.RowCount != 0)
                {
                    imagesTable.Columns[0].HeaderText = "ID";

                    imagesTable.Columns[1].HeaderText = "Фото";
                }
            }
            label14.Text = strAmount + imagesTable.RowCount;
        }

        private void button65_Click(object sender, EventArgs e)//Генерация "Студия"
        {
            if (studiosTable.RowCount == 0)
            {
                ControllerForDB.generateStudios();

                studiosTable.DataSource = ControllerForDB.selectAllFromMainTables("studios");

                if (studiosTable.RowCount !=0)
                {
                    studiosTable.Columns[0].HeaderText = "ID";

                    studiosTable.Columns[1].HeaderText = "Студия";

                    studiosTable.Columns[2].HeaderText = "Страна";
                }
            }
            label3.Text = strAmount + studiosTable.RowCount;
        }

        private void button66_Click(object sender, EventArgs e)//Генерация "Режиссеры"
        {
            if (producersTable.RowCount==0)
            {
                ControllerForDB.generatePeople(0, 20);

                producersTable.DataSource = ControllerForDB.selectAllFromMainTables("producers");

                if (producersTable.RowCount != 0)
                {
                    producersTable.Columns[0].HeaderText = "ID";

                    producersTable.Columns[1].HeaderText = "Имя";

                    producersTable.Columns[2].HeaderText = "Фамилия";

                    producersTable.Columns[3].HeaderText = "Отчество";
                }
            }
            label4.Text = strAmount + producersTable.RowCount;
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (ownersTable.RowCount == 0)
            {
                ControllerForDB.generatePeople(1, 20);

                ownersTable.DataSource = ControllerForDB.selectAllFromMainTables("owners");

                if (ownersTable.RowCount !=0)
                {
                    ownersTable.Columns[0].HeaderText = "ID";

                    ownersTable.Columns[1].HeaderText = "Имя";

                    ownersTable.Columns[2].HeaderText = "Фамилия";

                    ownersTable.Columns[3].HeaderText = "Отчество";
                }
            }
            label5.Text = strAmount + ownersTable.RowCount;
        }

        private void button68_Click(object sender, EventArgs e)//Генерация "Фильмы"
        {
            if (filmsTable.RowCount == 0)
            {
                ControllerForDB.filmGeneration(40);

                filmsTable.DataSource= ControllerForDB.selectAllFromMainTables("films");

                if (filmsTable.RowCount !=0)
                {
                    filmsTable.Columns[0].HeaderText = "ID";

                    filmsTable.Columns[1].HeaderText = "Название";

                    filmsTable.Columns[2].HeaderText = "Фамилия режиссера";

                    filmsTable.Columns[3].HeaderText = "Имя режиссера";

                    filmsTable.Columns[4].HeaderText = "Отчество режиссера";

                    filmsTable.Columns[5].HeaderText = "Студия";

                    filmsTable.Columns[6].HeaderText = "Страна студии";

                    filmsTable.Columns[7].HeaderText = "Год выпуска";

                    filmsTable.Columns[8].HeaderText = "Продолжительность";

                    filmsTable.Columns[9].HeaderText = "Информация";
                }
            }
            label9.Text = strAmount + filmsTable.RowCount;
        }
    }
}
