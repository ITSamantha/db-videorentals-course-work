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
        
        public addOrEditDeals()
        {
            InitializeComponent();

            updateCassettes();

            idCB.SelectedIndex = 0;
            
            updateRental();

            rentalCB.SelectedIndex = 0;
            
            updateService();

            serviceCB.SelectedIndex = 0;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isEnabled = true;

            Close();
        }

        private void idCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idCB.SelectedIndex ==id_list.Count)
            {
                Main_Menu.insertOrUpdateIntoCassettes(0);

                updateCassettes();

                idCB.SelectedIndex = (id_list.Count - 1);
            }
        }

        private void rentalCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rentalCB.SelectedIndex == rental_list.Count)
            {
                Main_Menu.inserOrUpdatetIntoVideoRental(0);

                updateRental();

                rentalCB.SelectedIndex = (rental_list.Count - 1);
            }

            updateService();

            serviceCB.SelectedIndex = 0;
        }

        private void serviceCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serviceCB.SelectedIndex == services_list.Count)
            {
                Main_Menu.InsertIntoDirectTables("services_view");

                updateService();

                serviceCB.SelectedIndex = (services_list.Count - 1);
            }
        }

        public void updateCassettes()
        {
            idCB.Items.Clear();

            id_list = ControllerForDB.selectForComboBox("cassettes", "pk_cassette_id", "pk_cassette_id");

            foreach (var it in id_list)
            {
                idCB.Items.Add(it.Key);
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

            serviceCB.Items.Add("+ Добавить ");
        }

       
    }
}
