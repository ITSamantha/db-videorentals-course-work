namespace BD_course_work
{
    partial class addOrEditDeals
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.idCB = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateCB = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rentalCB = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.serviceCB = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.recipeTB = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainL1
            // 
            this.mainL1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainL1.Font = new System.Drawing.Font("Garamond", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainL1.Location = new System.Drawing.Point(0, -5);
            this.mainL1.Name = "mainL1";
            this.mainL1.Size = new System.Drawing.Size(811, 43);
            this.mainL1.TabIndex = 21;
            this.mainL1.Text = "Добавить видеопрокат";
            this.mainL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.idCB);
            this.groupBox3.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(35, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 75);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ID кассеты";
            // 
            // idCB
            // 
            this.idCB.DropDownHeight = 200;
            this.idCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idCB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idCB.FormattingEnabled = true;
            this.idCB.IntegralHeight = false;
            this.idCB.Location = new System.Drawing.Point(6, 26);
            this.idCB.Name = "idCB";
            this.idCB.Size = new System.Drawing.Size(332, 35);
            this.idCB.TabIndex = 1;
            this.idCB.SelectedIndexChanged += new System.EventHandler(this.idCB_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateCB);
            this.groupBox1.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(426, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 75);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дата сделки";
            // 
            // dateCB
            // 
            this.dateCB.CalendarFont = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateCB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateCB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCB.Location = new System.Drawing.Point(6, 26);
            this.dateCB.MaxDate = new System.DateTime(2046, 8, 11, 0, 0, 0, 0);
            this.dateCB.MinDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dateCB.Name = "dateCB";
            this.dateCB.Size = new System.Drawing.Size(321, 35);
            this.dateCB.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rentalCB);
            this.groupBox2.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(426, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 75);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Видеопрокат";
            // 
            // rentalCB
            // 
            this.rentalCB.DropDownHeight = 200;
            this.rentalCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentalCB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rentalCB.FormattingEnabled = true;
            this.rentalCB.IntegralHeight = false;
            this.rentalCB.Location = new System.Drawing.Point(6, 26);
            this.rentalCB.Name = "rentalCB";
            this.rentalCB.Size = new System.Drawing.Size(332, 35);
            this.rentalCB.TabIndex = 1;
            this.rentalCB.SelectedIndexChanged += new System.EventHandler(this.rentalCB_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.priceTB);
            this.groupBox4.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(426, 294);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 75);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Цена";
            // 
            // priceTB
            // 
            this.priceTB.BackColor = System.Drawing.Color.White;
            this.priceTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTB.Location = new System.Drawing.Point(6, 24);
            this.priceTB.Multiline = true;
            this.priceTB.Name = "priceTB";
            this.priceTB.ReadOnly = true;
            this.priceTB.Size = new System.Drawing.Size(332, 37);
            this.priceTB.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.serviceCB);
            this.groupBox5.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(426, 213);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(344, 75);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Услуги";
            // 
            // serviceCB
            // 
            this.serviceCB.DropDownHeight = 200;
            this.serviceCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceCB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceCB.FormattingEnabled = true;
            this.serviceCB.IntegralHeight = false;
            this.serviceCB.Location = new System.Drawing.Point(6, 26);
            this.serviceCB.Name = "serviceCB";
            this.serviceCB.Size = new System.Drawing.Size(332, 35);
            this.serviceCB.TabIndex = 1;
            this.serviceCB.SelectedIndexChanged += new System.EventHandler(this.serviceCB_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.recipeTB);
            this.groupBox6.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(35, 132);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(344, 237);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Квитанция";
            // 
            // recipeTB
            // 
            this.recipeTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recipeTB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recipeTB.Location = new System.Drawing.Point(6, 24);
            this.recipeTB.Multiline = true;
            this.recipeTB.Name = "recipeTB";
            this.recipeTB.Size = new System.Drawing.Size(332, 199);
            this.recipeTB.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(421, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 36);
            this.button2.TabIndex = 34;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(216, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 36);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addOrEditDeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(809, 429);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.mainL1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addOrEditDeals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addOrEditDeals";
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label mainL1;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.ComboBox idCB;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox rentalCB;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TextBox priceTB;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.ComboBox serviceCB;
        public System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.TextBox recipeTB;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.DateTimePicker dateCB;
    }
}