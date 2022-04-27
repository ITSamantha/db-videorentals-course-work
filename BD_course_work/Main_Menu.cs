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

        bool isEntered = false;

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

            ControllerForDB.Connection(connectionStringDB);
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
        
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button36_Click(object sender, EventArgs e)//Таблица "Услуги и цены"
        {
            if (!label15.Text.Equals(strAmount)) { label15.Text = strAmount; }

            mainControl.SelectedIndex = (int)Pages.Images;
            /*
            //dt = ControllerForDB.selectAllFromTablesDirectories("services_prices");
            //Другой метод!
            if (dt != null)
            {
                qualityTable.DataSource = dt;

                qualityTable.Columns[0].HeaderText = "ID";//ДОДЕЛАТЬ!кАКОЕ ОБЬЪЕДИНЕНИЕ БУДЕТ!?

                qualityTable.Columns[1].HeaderText = "Фото";
            }
            */
            label15.Text += ControllerForDB.amount;//Доделать очистку lable  и добавить else с количеством 0
        }

        private void button35_Click(object sender, EventArgs e)//Таблица "Картинки"
        {
            if (!label14.Text.Equals(strAmount)) { label14.Text = strAmount; }

            mainControl.SelectedIndex = (int)Pages.Images;

            dt = ControllerForDB.selectAllFromTablesDirectories("cassette_photo");

            if (dt != null)
            {
                qualityTable.DataSource = dt;

                qualityTable.Columns[0].HeaderText = "ID";

                qualityTable.Columns[1].HeaderText = "Фото";
            }

            label14.Text += ControllerForDB.amount;//Доделать очистку lable  и добавить else с количеством 0

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

            label13.Text += ControllerForDB.amount;//Доделать очистку lable  и добавить else с количеством 0

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

            label2.Text += ControllerForDB.amount;//Доделать очистку lable  и добавить else с количеством 0
            
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

        private void servicesB_Click(object sender, EventArgs e)//Услуги
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

        private void proptypeB_Click(object sender, EventArgs e)//Тип_собственности
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

        private void districtB_Click(object sender, EventArgs e)//Район
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

        private void filmsB_Click(object sender, EventArgs e)//Фильмы
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

        private void cassettesB_Click(object sender, EventArgs e)
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

        private void videorentalB_Click(object sender, EventArgs e)
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

        private void ordersB_Click(object sender, EventArgs e)//Сделки
        {
            mainControl.SelectedIndex = (int)Pages.Orders;//ДОДЕЛАТЬ!
        }

        //Методы добавления
        private void button33_Click(object sender, EventArgs e)
        {
            insertIntoDirectTables("cassette_quality");
        }

        private void button9_Click(object sender, EventArgs e)//Добавление хозяина
        {
            addToPeopleTable("owners");
        }

        private void button6_Click(object sender, EventArgs e)//Добавление режиссера
        {
            addToPeopleTable("producers");
        }

        public void addToPeopleTable(string t)
        {
            AddOrEditThreeColumns add = new AddOrEditThreeColumns();

            add.mainL2.Text = t=="owners"?"Добавить хозяина":"Добавить режиссера";

            m1:

            add.clean();

            add.ShowDialog();

            if (add.fam.Text != String.Empty && add.name.Text != String.Empty&&!add.isCanceled&&add.isEnabled)
            {
                ControllerForDB.insertIntoPeopleTable(t, add.fam.Text, add.name.Text, add.patronymic.Text);

                ControllerForDB.selectAllFromTablesDirectories(t);
            }
            else
            {
                if ( add.isEnabled && (add.fam.Text == String.Empty || add.name.Text == String.Empty))
                {
                    MessageBox.Show("Вы не ввели фамилию или имя.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    goto m1;

                }
                return;
            }

            add.fam.Text = "";

            add.name.Text = "";

            add.patronymic.Text = "";
        }

        public void insertIntoDirectTables(string t)
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

            if (add.countryTB.Text != String.Empty&&!add.isCanceled&&add.isEnabled)
            {
                ControllerForDB.insertIntoDirectTable(t, add.countryTB.Text);

                ControllerForDB.selectAllFromTablesDirectories(t);//??
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
            addCountry.Text = "";
        }
        
        private void addCountry_Click(object sender, EventArgs e)//Добавление страны
        {
            insertIntoDirectTables("countries");
        }
        
        private void button12_Click(object sender, EventArgs e)//Добавление услуги
        {
            insertIntoDirectTables("services");
        }

        private void button15_Click(object sender, EventArgs e)//Добавить тип собственности
        {
            insertIntoDirectTables("property_type");
        }

        private void button18_Click(object sender, EventArgs e)//Добавить район
        {
            insertIntoDirectTables("district");
        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)//Удаление "Качетсво кассеты"
        {
            deleteRowById((int)qualityTable.SelectedRows[0].Cells[0].Value, "cassette_quality", "pk_quality_id");
        }


        private void deleteCountry_Click(object sender, EventArgs e)//Удаление "Страны"    Доделать еще 2 вида!
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
            deleteRowById((int)cassettesTable.SelectedRows[0].Cells[0].Value, "cassettes", "pk_cassette_id");
        }

        private void button26_Click(object sender, EventArgs e)//Удаление "Сделки"
        {
            deleteRowById((int)ordersTable.SelectedRows[0].Cells[0].Value, "deals", "pk_deal_id");
        }

        private void button29_Click(object sender, EventArgs e)//Удаление "Видеопрокаты"
        {
            deleteRowById((int)videoTable.SelectedRows[0].Cells[0].Value, "video_rental", "pk_video_rental_id");
        }
        
        public void deleteRowById(int index,string table,string id_value)//Функция удаления с выводом информации
        {
            if (ControllerForDB.deleteById(index, table, id_value))
            {
                MessageBox.Show("Строка удалена.", "Оповещение");
            }
            else
            {
                if (ControllerForDB.isCanceledDelete) { return; }
                MessageBox.Show("По каким-то причинам строка не удалена.", "Оповещение");
            }
        }












        //ДОДЕЛАТЬ ОСТАЛЬНЫЕ ТАБЛИЦЫ
    }
}
