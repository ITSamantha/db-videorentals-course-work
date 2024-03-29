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
    public partial class Connect : Form
    {
        static public string status;

        public Connect()
        {
            InitializeComponent();

            password.UseSystemPasswordChar = true;

            password.PasswordChar = '*';

            password.Text = "01dr10kv";

            login.Text = "postgres";
        }
        
        private void button1_Click_1(object sender, EventArgs e)//Вход
        {
            if (Verifying(login.Text, password.Text))
            {
                status = "running";
                CClose();
            }
            else
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool Verifying(string login,string pass)
        {
            if (login == "postgres"&&pass=="01dr10kv")
            {
                return true;
            }
            return false;
        }

        void CClose()
        {
            if (status == "running")
                Close();
        }
        
    }
}
