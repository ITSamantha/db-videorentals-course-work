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

        public addOrEditDeals()
        {
            InitializeComponent();
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

        }

        private void rentalCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void serviceCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void updateCassettes()
        {

        }

        public void updateRentalFirst()
        {


        }

        public void updateRental()
        {

        }

        public void updateService()
        {

        }
    }
}
