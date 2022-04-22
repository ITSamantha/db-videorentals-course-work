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
            Countries
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

        private void countriesB_Click(object sender, EventArgs e)
        {
            mainControl.SelectedIndex = (int)Pages.Countries;

            dt= ControllerForDB.selectAllFromTablesDirectories("countries");

            if (dt != null)
            {
                countriesTable.DataSource = dt;

                countriesTable.Columns[0].HeaderText = "ID";

                countriesTable.Columns[1].HeaderText = "Страна";
            }
            
        }

        private void studiosB_Click(object sender, EventArgs e)//Таблица "Студии"
        {
            mainControl.SelectedIndex = (int)Pages.Studios;

            dt = ControllerForDB.selectAllFromMainTables("studios");

            if (dt != null)
            {
                studiosTable.DataSource = dt;

                studiosTable.Columns[0].HeaderText = "ID";

                studiosTable.Columns[1].HeaderText = "Студия";

                studiosTable.Columns[2].HeaderText = "Страна";
            }
        }

        private void producersB_Click(object sender, EventArgs e)//Таблица "Режиссеры"
        {
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

        }

        private void ownersB_Click(object sender, EventArgs e)//Таблица"Хозяины"
        {
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
        }

        private void servicesB_Click(object sender, EventArgs e)
        {
            mainControl.SelectedIndex = (int)Pages.Services;

            dt = ControllerForDB.selectAllFromTablesDirectories("services");

            if (dt != null)
            {
                servicesTable.DataSource = dt;

                servicesTable.Columns[0].HeaderText = "ID";

                servicesTable.Columns[1].HeaderText = "Услуга";
            }
        }

        private void proptypeB_Click(object sender, EventArgs e)
        {
            mainControl.SelectedIndex = (int)Pages.Property;

            dt = ControllerForDB.selectAllFromTablesDirectories("property_type");

            if (dt != null)
            {
                propertyTable.DataSource = dt;

                propertyTable.Columns[0].HeaderText = "ID";

                propertyTable.Columns[1].HeaderText = "Тип собственности";
            }
        }

        private void districtB_Click(object sender, EventArgs e)
        {
            mainControl.SelectedIndex = (int)Pages.Districts;

            dt = ControllerForDB.selectAllFromTablesDirectories("district");

            if (dt != null)
            {
                districtsTable.DataSource = dt;

                districtsTable.Columns[0].HeaderText = "ID";

                districtsTable.Columns[1].HeaderText = "Район";
            }
        }

        private void filmsB_Click(object sender, EventArgs e)
        {
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
        }

        private void cassettesB_Click(object sender, EventArgs e)
        {
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

        }

        private void videorentalB_Click(object sender, EventArgs e)
        {
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
        }

        private void ordersB_Click(object sender, EventArgs e)
        {
            mainControl.SelectedIndex = (int)Pages.Orders;
        }

        //Методы добавления

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

            if (add.fam.Text != String.Empty && add.name.Text != String.Empty)
            {
                ControllerForDB.insertIntoPeopleTable(t, add.fam.Text, add.name.Text, add.patronymic.Text);

                ControllerForDB.selectAllFromTablesDirectories(t);
            }
            else
            {
                if (add.isCanceled && add.isEnabled && (add.fam.Text == String.Empty || add.name.Text == String.Empty))
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
                        break;
                    }
                case "services":
                    {
                        add.mainL1.Text = "Добавить услугу";
                        break;
                    }
                case "property_type":
                    {
                        add.mainL1.Text = "Добавить тип \nсобственности";
                        break;
                    }
                case "district":
                    {
                        add.mainL1.Text = "Добавить район";
                        break;
                    }
            }
            
            add.ShowDialog();

            ControllerForDB.insertIntoDirectTable(t, add.countryTB.Text);

            ControllerForDB.selectAllFromTablesDirectories(t);//??

            //проверка ТБ на пустоту, проверка на повторение имени!ОБРАБОТАТЬ ИСКЛЮЧЕНИЕ!

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
        
    }
}
