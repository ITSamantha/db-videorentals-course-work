﻿namespace BD_course_work
{
    partial class AddOrEditVideoRental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainL1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.title = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.districtCB = new System.Windows.Forms.ComboBox();
            this.adress1 = new System.Windows.Forms.GroupBox();
            this.adress = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.number = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.amountEmpl = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.propCB = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.timeStart = new System.Windows.Forms.MaskedTextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.timeEnd = new System.Windows.Forms.MaskedTextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.ownerCB = new System.Windows.Forms.ComboBox();
            this.license = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.adress1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainL1
            // 
            this.mainL1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainL1.Font = new System.Drawing.Font("Garamond", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainL1.Location = new System.Drawing.Point(-1, -2);
            this.mainL1.Name = "mainL1";
            this.mainL1.Size = new System.Drawing.Size(861, 43);
            this.mainL1.TabIndex = 19;
            this.mainL1.Text = "Добавить видеопрокат";
            this.mainL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(448, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 36);
            this.button2.TabIndex = 22;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(243, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(25, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 75);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Название";
            // 
            // title
            // 
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(6, 24);
            this.title.Multiline = true;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(369, 37);
            this.title.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.districtCB);
            this.groupBox2.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(448, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 75);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Район";
            // 
            // districtCB
            // 
            this.districtCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.districtCB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.districtCB.FormattingEnabled = true;
            this.districtCB.Location = new System.Drawing.Point(6, 26);
            this.districtCB.Name = "districtCB";
            this.districtCB.Size = new System.Drawing.Size(369, 35);
            this.districtCB.TabIndex = 1;
            this.districtCB.SelectedIndexChanged += new System.EventHandler(this.districtCB_SelectedIndexChanged);
            // 
            // adress1
            // 
            this.adress1.Controls.Add(this.adress);
            this.adress1.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adress1.Location = new System.Drawing.Point(25, 137);
            this.adress1.Name = "adress1";
            this.adress1.Size = new System.Drawing.Size(381, 156);
            this.adress1.TabIndex = 24;
            this.adress1.TabStop = false;
            this.adress1.Text = "Адрес";
            // 
            // adress
            // 
            this.adress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adress.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adress.Location = new System.Drawing.Point(6, 24);
            this.adress.Multiline = true;
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(369, 118);
            this.adress.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.number);
            this.groupBox3.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(448, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 75);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Телефон";
            // 
            // number
            // 
            this.number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.number.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number.Location = new System.Drawing.Point(6, 24);
            this.number.Multiline = true;
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(369, 37);
            this.number.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.license);
            this.groupBox4.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(448, 299);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(381, 75);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "№ Лицензии";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.amountEmpl);
            this.groupBox5.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(448, 380);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(381, 75);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Количество работников";
            // 
            // amountEmpl
            // 
            this.amountEmpl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountEmpl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountEmpl.Location = new System.Drawing.Point(6, 24);
            this.amountEmpl.Multiline = true;
            this.amountEmpl.Name = "amountEmpl";
            this.amountEmpl.Size = new System.Drawing.Size(369, 37);
            this.amountEmpl.TabIndex = 13;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.propCB);
            this.groupBox6.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(448, 137);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(381, 75);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Тип собственности";
            // 
            // propCB
            // 
            this.propCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.propCB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.propCB.FormattingEnabled = true;
            this.propCB.Location = new System.Drawing.Point(6, 26);
            this.propCB.Name = "propCB";
            this.propCB.Size = new System.Drawing.Size(369, 35);
            this.propCB.TabIndex = 1;
            this.propCB.SelectedIndexChanged += new System.EventHandler(this.propCB_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.timeStart);
            this.groupBox7.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox7.Location = new System.Drawing.Point(25, 299);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(178, 75);
            this.groupBox7.TabIndex = 24;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Начало работы";
            // 
            // timeStart
            // 
            this.timeStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeStart.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeStart.Location = new System.Drawing.Point(6, 30);
            this.timeStart.Mask = "00";
            this.timeStart.Name = "timeStart";
            this.timeStart.Size = new System.Drawing.Size(166, 28);
            this.timeStart.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.timeEnd);
            this.groupBox8.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox8.Location = new System.Drawing.Point(228, 299);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(178, 75);
            this.groupBox8.TabIndex = 25;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Конец работы";
            // 
            // timeEnd
            // 
            this.timeEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeEnd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeEnd.Location = new System.Drawing.Point(6, 30);
            this.timeEnd.Mask = "00";
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Size = new System.Drawing.Size(166, 28);
            this.timeEnd.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.ownerCB);
            this.groupBox9.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox9.Location = new System.Drawing.Point(25, 380);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(381, 75);
            this.groupBox9.TabIndex = 25;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Хозяин";
            // 
            // ownerCB
            // 
            this.ownerCB.DropDownHeight = 100;
            this.ownerCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ownerCB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerCB.FormattingEnabled = true;
            this.ownerCB.IntegralHeight = false;
            this.ownerCB.Location = new System.Drawing.Point(6, 26);
            this.ownerCB.MaximumSize = new System.Drawing.Size(369, 0);
            this.ownerCB.MinimumSize = new System.Drawing.Size(369, 0);
            this.ownerCB.Name = "ownerCB";
            this.ownerCB.Size = new System.Drawing.Size(369, 35);
            this.ownerCB.TabIndex = 1;
            this.ownerCB.SelectedIndexChanged += new System.EventHandler(this.ownerCB_SelectedIndexChanged);
            // 
            // license
            // 
            this.license.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.license.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.license.Location = new System.Drawing.Point(6, 30);
            this.license.Mask = "0000000";
            this.license.Name = "license";
            this.license.Size = new System.Drawing.Size(369, 32);
            this.license.TabIndex = 1;
            // 
            // AddOrEditVideoRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(859, 519);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.adress1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainL1);
            this.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddOrEditVideoRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.adress1.ResumeLayout(false);
            this.adress1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label mainL1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox title;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox districtCB;
        public System.Windows.Forms.GroupBox adress1;
        public System.Windows.Forms.TextBox adress;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox number;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.TextBox amountEmpl;
        public System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.ComboBox propCB;
        public System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.GroupBox groupBox8;
        public System.Windows.Forms.GroupBox groupBox9;
        public System.Windows.Forms.ComboBox ownerCB;
        public System.Windows.Forms.MaskedTextBox timeStart;
        public System.Windows.Forms.MaskedTextBox timeEnd;
        public System.Windows.Forms.MaskedTextBox license;
    }
}