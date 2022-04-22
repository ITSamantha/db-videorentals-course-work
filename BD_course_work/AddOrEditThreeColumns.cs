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
    public partial class AddOrEditThreeColumns : Form
    {

        public bool isCanceled = false;

        public  bool isEnabled;
        
        public AddOrEditThreeColumns()
        {
            InitializeComponent();

            clean();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isEnabled = true;

            Close();
        }

        private void AddOrEditThreeColumns_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                isCanceled = true;
            }
        }

        public void clean()
        {
            isEnabled = false;

            isCanceled = false;
        }
    }
}
