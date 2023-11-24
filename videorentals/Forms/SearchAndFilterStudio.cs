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
    public partial class SearchAndFilterStudio : Form
    {
        public bool isCanceled = false;

        public bool isEnabled;

        public SortedDictionary<string, int> list;

        public SearchAndFilterStudio()
        {
            InitializeComponent();

            updateCountry();
            
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

        public void updateCountry()
        {
            countryCB.Items.Clear();

            list = ControllerForDB.selectForComboBox("countries", "country_name", "pk_country_id");

            foreach (var it in list)
            {
                countryCB.Items.Add(it.Key);
            }

            countryCB.Items.Add("+ Добавить ");

        }
    }
}
