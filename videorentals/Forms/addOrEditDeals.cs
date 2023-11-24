using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_course_work
{
    public partial class addOrEditDeals : Form
    {
        public bool isCanceled = false;

        public bool isEnabled;

        public SortedDictionary<string, int> id_list;

        public SortedDictionary<string, int> rental_list;

        public SortedDictionary<string, int> services_list;

        public SortedDictionary<string, int> films_list;

        public addOrEditDeals()
        {
            InitializeComponent();
            
            updateCassettes();

            updateRental();

            clean();

            rentalCB.SelectedIndex = 0;

            updateService();

            clean();
            
            serviceCB.SelectedIndex = 0;

            clean();

            idCB.SelectedIndex = 0;
            
            dateCB.MaxDate =date1.MaxDate=date2.MaxDate= DateTime.Today;
           
            updatePriceAndRecipe();

            updateFilms();

            filmCB.SelectedIndex = 0;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isCanceled = true;
            
            Close();
        }

        public void clean()
        {
            isEnabled = false;

            isCanceled = false;

            isRen = false;

            isServ = false;

            isId = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isEnabled = true;

            Close();
        }

        public static bool isId=false;

        public static bool isRen= false;

        public static bool isServ = false;

        private void idCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idCB.SelectedIndex ==id_list.Count)
            {
                Main_Menu.insertOrUpdateIntoCassettes(0);

                updateCassettes();

                idCB.SelectedIndex = (id_list.Count - 1);
            }
            if (isId)
            {
                updatePriceAndRecipe();
            }
            isId = true;
        }
        private void rentalCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rentalCB.SelectedIndex == rental_list.Count)
            {
                Main_Menu.inserOrUpdatetIntoVideoRental(0);

                updateRental();

                rentalCB.SelectedIndex = (rental_list.Count - 1);
            }
            if (isRen)
            {
                updateService();

                updatePriceAndRecipe();
            }
            isRen = true;
        }

        private void serviceCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isServ)
            {
                updatePriceAndRecipe();
            }
            isServ = true;
        }

        public void updateFilms()
        {
            filmCB.Items.Clear();

            films_list = ControllerForDB.selectForComboBox("films", "film_name", "pk_film_id");

            foreach (var it in films_list)
            {
                filmCB.Items.Add(it.Key);
            }
            
        }

        public void updateCassettes()
        {
            idCB.Items.Clear();

            id_list = ControllerForDB.selectForComboBox("cassettes", "cassette_price", "pk_cassette_id");

            foreach (var it in id_list)
            {
                idCB.Items.Add(it.Value);
            }

            idCB.Items.Add("+ Добавить ");
        }
        
        public void updateRental()
        {
            rentalCB.Items.Clear();

            rental_list = ControllerForDB.selectForComboBox("video_rental", "video_caption", "pk_video_rental_id");

            foreach (var it in rental_list)
            {
                rentalCB.Items.Add(it.Key);
            }

            rentalCB.Items.Add("+ Добавить ");
            
        }

        public void updateService()
        {
            serviceCB.Items.Clear();

            services_list = ControllerForDB.selectForComboBoxDeals(rental_list[rentalCB.Text]);

            foreach (var it in services_list)
            {
                serviceCB.Items.Add(it.Key);
            }

            serviceCB.SelectedIndex = 0;
            
        }
        public static int service_id;

        public void updatePriceAndRecipe()
        {
            if (idCB.Text != "")
            {
                service_id = ControllerForDB.getServicePriceID(rental_list[rentalCB.Text], services_list[serviceCB.Text]);

                priceTB.Text = ((double)ControllerForDB.selectSmthById(service_id, "services_prices", "service_price", "pk_service_price_id") + double.Parse((ControllerForDB.selectSmthById(int.Parse(idCB.Text), "cassettes", "cassette_price", "pk_cassette_id").ToString()))).ToString();

                recipeTB.Text = $"Квитанция выдана {dateCB.Value.ToShortDateString()}.\n Цена: {priceTB.Text}.\n Услуга: {serviceCB.Text}.\n Спасибо за посещение видеопроката {rentalCB.Text}!";

            }
        }

        private void dateCB_ValueChanged(object sender, EventArgs e)
        {
            updatePriceAndRecipe();
        }


        //command.Append($"( null, {cassette_id} , ");

        // command.Append($"'Квитанция выдана {date}. . Цена: {price}.Спасибо за посещение! '" + $",  '{d}'::date " + $", '{service_id}', {price.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))} ); ");
    }
}
