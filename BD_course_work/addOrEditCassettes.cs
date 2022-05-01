using BD_course_work.Properties;
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
    public partial class addOrEditCassettes : Form
    {
        public SortedDictionary<string, int> quality_list;

        public SortedDictionary<string, int> film_list;

        public List<int> added_photo;
        
        public bool isCanceled = false;

        public bool isEnabled;

        public addOrEditCassettes()
        {
            InitializeComponent();

            updateFilms();

            updateQuality();

            added_photo = new List<int>();

            filmCB.SelectedIndex = 0;

            qualityCB.SelectedIndex = 0;

            demandCB.SelectedIndex = 0;

            photoPB.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            isCanceled = true;

            /*if (added_photo.Count!=0)
            {
                foreach (var i in added_photo)
                {
                    ControllerForDB.deleteById(i, "cassette_photo", "pk_photo_id");
                }
            }*/

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

        private void qualityCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (qualityCB.SelectedIndex == quality_list.Count)
            {
                Main_Menu.InsertIntoDirectTables("cassette_quality");

                updateQuality();

                qualityCB.SelectedIndex = (quality_list.Count - 1);
            }
        }

        private void filmCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filmCB.SelectedIndex == film_list.Count)
            {
                Main_Menu.insertOrUpdateIntoFilms(0);

                updateFilms();

                filmCB.SelectedIndex = (film_list.Count - 1);
            }
        }

        public void updateQuality()
        {
            qualityCB.Items.Clear();

            quality_list = ControllerForDB.selectForComboBox("cassette_quality", "quality_name", "pk_quality_id");

            foreach (var it in quality_list)
            {
                qualityCB.Items.Add(it.Key);
            }

            qualityCB.Items.Add("+ Добавить ");
        }

        public void updateFilms()
        {
            filmCB.Items.Clear();

            film_list = ControllerForDB.selectForComboBox("films", "film_name", "pk_film_id");

            foreach (var it in film_list)
            {
                filmCB.Items.Add(it.Key);
            }

            filmCB.Items.Add("+ Добавить ");
        }

        private void photoPB_Click(object sender, EventArgs e)
        {
            if (!Main_Menu.insertPhotoIntoTable())
            {
                return;
            }

            added_photo.Add(Main_Menu.pic_id);

            if (!string.IsNullOrEmpty(Main_Menu.path))
            {
                photoPB.Image = Image.FromFile(Main_Menu.path);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            photoPB.Image = Resources.add_photo;

            if (Main_Menu.pic_id != 0)
            {
                ControllerForDB.deletePhoto(Main_Menu.pic_id);
            } 
        }
    }
}
