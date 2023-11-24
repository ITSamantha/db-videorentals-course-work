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
    public partial class deleteMenu : Form
    {

        public bool isCanceled = false;

        public bool isDeleteStr = false;

        public bool isDeleteManyStr = false;

        public bool isDeleteValue = false;

        public bool isDeleteSelectedRows = false;
        
        public deleteMenu()
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
            isCanceled = false;

            isDeleteStr = false;

            isDeleteManyStr = false;

            isDeleteValue = false;
        }

        private void deleteStr_Click(object sender, EventArgs e)
        {
            isDeleteStr = true;

            Close();
        }

        private void deleteValue_Click(object sender, EventArgs e)
        {
            isDeleteValue = true;

            Close();
        }

        private void deleteManyStr_Click(object sender, EventArgs e)
        {
            isDeleteSelectedRows = true;
            
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isDeleteManyStr = true;

            Close();
        }
    }
}
