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
    public partial class addOrEditFilm : Form
    {
        public SortedDictionary<string, int> producer_list;

        public SortedDictionary<string, int> studio_list;

        public bool isCanceled = false;

        public bool isEnabled;

        public addOrEditFilm()
        {
            InitializeComponent();

            updateProducer();

            updateStudio();

            producerCB.SelectedIndex = 0;

            studioCB.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)//Cancel
        {
            isCanceled = true;

            Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            isEnabled = true;

            Close();
        }

        private void studioCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studioCB.SelectedIndex == studio_list.Count)
            {
                Main_Menu.insertOrUpdateIntoStudios(0);

                updateStudio();

                studioCB.SelectedIndex = (studio_list.Count - 1);
            }
        }

        private void producerCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (producerCB.SelectedIndex == producer_list.Count)
            {
                Main_Menu.addToPeopleTable("producers");

                updateProducer();

                producerCB.SelectedIndex = (producer_list.Count - 1);
            }
        }

        public void updateProducer()
        {
             producerCB.Items.Clear();

             producer_list = ControllerForDB.selectForComboBox("producers");

             foreach (var it in producer_list)
             {
                    producerCB.Items.Add(it.Key);
             }

             producerCB.Items.Add("+ Добавить ");
        }

        public void updateStudio()
        {
            studioCB.Items.Clear();

            studio_list = ControllerForDB.selectForComboBox("studios", "studio_name", "pk_studio_id");

            foreach (var it in studio_list)
            {
                studioCB.Items.Add(it.Key);
            }

            studioCB.Items.Add("+ Добавить ");
        }

        public void clean()
        {
            isEnabled = false;

            isCanceled = false;
        }

    }
}
