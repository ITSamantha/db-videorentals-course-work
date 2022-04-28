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
    public partial class AddOrEditVideoRental : Form
    {
        public AddOrEditVideoRental()
        {
            InitializeComponent();

            clean();
            //ПРОВЕРКА НА ПУСТОЕ КОЛИЧЕСТВО
            updateDistricts();

            updateProp();

            updateOwner();

            districtCB.SelectedIndex = 0;

            propCB.SelectedIndex = 0;

            ownerCB.SelectedIndex = 0;
        }

        public void updateDistricts()
        {//ВЕЗДЕ ОБРАБОТКА ИСКЛЮЧЕНИЙ(СОВПАДЕНИЕ, ПУСТОТА)
            districtCB.Items.Clear();

            list= ControllerForDB.selectForComboBox("district", "district_name");

            for (int i = 0; i < list.Count; i++)
            {
                districtCB.Items.Add(list[i].ToString());
            }

            districtCB.Items.Add("+ Добавить ");
        }

        public void updateProp()
        {
            propCB.Items.Clear();

            prop_list = ControllerForDB.selectForComboBox("property_type", "property_type_name");

            for (int i = 0; i < prop_list.Count; i++)
            {
                propCB.Items.Add(prop_list[i].ToString());
            }

            propCB.Items.Add("+ Добавить ");
            
        }

        public void updateOwner()
        {
            ownerCB.Items.Clear();

            owner_list = ControllerForDB.selectForComboBox("owners");

            for (int i = 0; i < owner_list.Count; i++)
            {
                ownerCB.Items.Add(owner_list[i].ToString());
            }

            ownerCB.Items.Add("+ Добавить ");
        }


        List<string> list;

        List<string> prop_list;

        List<string> owner_list;

        public bool isCanceled=false;

        public bool isEnabled;

        private void button2_Click(object sender, EventArgs e)//Cancel
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

        private void districtCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (districtCB.SelectedIndex == list.Count)
            {
                Main_Menu.InsertIntoDirectTables("district");

                updateDistricts();

                districtCB.SelectedIndex = (list.Count - 1);
            }
        }

        private void propCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (propCB.SelectedIndex == prop_list.Count)
            {
                Main_Menu.InsertIntoDirectTables("property_type");

                updateProp();

                propCB.SelectedIndex = (prop_list.Count - 1);
            }
        }

        private void ownerCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ownerCB.SelectedIndex == owner_list.Count)
            {
                Main_Menu.addToPeopleTable("owners");

                updateOwner();

                ownerCB.SelectedIndex = (owner_list.Count - 1);
            }
        }
    }
}
