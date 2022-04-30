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
    public partial class addOrEditServicesPrices : Form
    {
        public bool isCanceled = false;

        public bool isEnabled;

        public SortedDictionary<string, int> services_list;

        public SortedDictionary<string, int> video_list;

        public addOrEditServicesPrices()
        {
            InitializeComponent();

            updateService();

            updateVideo();

            rentalCB.SelectedIndex = 0;

            serviceCB.SelectedIndex = 0;
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

        private void button2_Click(object sender, EventArgs e)
        {
            isCanceled = true;

            Close();
        }

        private void serviceCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serviceCB.SelectedIndex == services_list.Count)
            {
                Main_Menu.InsertIntoDirectTables("services");

                updateService();

                serviceCB.SelectedIndex = (services_list.Count - 1);
            }
        }

        private void rentalCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rentalCB.SelectedIndex == video_list.Count)
            {
                Main_Menu.inserOrUpdatetIntoVideoRental(0);

                updateVideo();

                rentalCB.SelectedIndex = (video_list.Count - 1);
            }
        }

        public void updateService()
        {
            serviceCB.Items.Clear();

            services_list = ControllerForDB.selectForComboBox("services", "service_name", "pk_service_id");

            foreach (var it in services_list)
            {
                serviceCB.Items.Add(it.Key);
            }

            serviceCB.Items.Add("+ Добавить ");
        }

        public void updateVideo()
        {
            rentalCB.Items.Clear();

            video_list = ControllerForDB.selectForComboBox("video_rental", "video_caption", "pk_video_rental_id");

            foreach (var it in video_list)
            {
                rentalCB.Items.Add(it.Key);
            }

            rentalCB.Items.Add("+ Добавить ");
        }
    }
}
