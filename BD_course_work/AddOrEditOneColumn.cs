﻿using System;
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
    public partial class AddOrEditOneColumn : Form
    {
        public bool isCanceled = false;

        public bool isEnabled;

        public AddOrEditOneColumn()
        {
            InitializeComponent();

            clean();
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

        public void clean()
        {
            isEnabled = false;

            isCanceled = false;
        }
    }
    
}
