namespace BD_course_work
{
    partial class addOrEditFilm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.title = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.studio = new System.Windows.Forms.GroupBox();
            this.studioCB = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.producerCB = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.year = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.duration = new System.Windows.Forms.TextBox();
            this.adress1 = new System.Windows.Forms.GroupBox();
            this.info = new System.Windows.Forms.TextBox();
            this.year1 = new System.Windows.Forms.MaskedTextBox();
            this.year2 = new System.Windows.Forms.MaskedTextBox();
            this.dur1 = new System.Windows.Forms.TextBox();
            this.dur2 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.fam = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.name = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.patron = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.studio.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.adress1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainL1
            // 
            this.mainL1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainL1.Font = new System.Drawing.Font("Garamond", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainL1.Location = new System.Drawing.Point(-2, 0);
            this.mainL1.Name = "mainL1";
            this.mainL1.Size = new System.Drawing.Size(803, 43);
            this.mainL1.TabIndex = 20;
            this.mainL1.Text = "Добавить видеопрокат";
            this.mainL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 75);
            this.groupBox1.TabIndex = 24;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(421, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 36);
            this.button2.TabIndex = 26;
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
            this.button1.Location = new System.Drawing.Point(202, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 36);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studio
            // 
            this.studio.Controls.Add(this.studioCB);
            this.studio.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studio.Location = new System.Drawing.Point(12, 158);
            this.studio.Name = "studio";
            this.studio.Size = new System.Drawing.Size(381, 75);
            this.studio.TabIndex = 27;
            this.studio.TabStop = false;
            this.studio.Text = "Студия";
            // 
            // studioCB
            // 
            this.studioCB.DropDownHeight = 100;
            this.studioCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studioCB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studioCB.FormattingEnabled = true;
            this.studioCB.IntegralHeight = false;
            this.studioCB.Location = new System.Drawing.Point(6, 26);
            this.studioCB.Name = "studioCB";
            this.studioCB.Size = new System.Drawing.Size(369, 35);
            this.studioCB.TabIndex = 1;
            this.studioCB.SelectedIndexChanged += new System.EventHandler(this.studioCB_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.producerCB);
            this.groupBox2.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 75);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Режиссер";
            // 
            // producerCB
            // 
            this.producerCB.DropDownHeight = 100;
            this.producerCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.producerCB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.producerCB.FormattingEnabled = true;
            this.producerCB.IntegralHeight = false;
            this.producerCB.Location = new System.Drawing.Point(6, 26);
            this.producerCB.Name = "producerCB";
            this.producerCB.Size = new System.Drawing.Size(369, 35);
            this.producerCB.TabIndex = 1;
            this.producerCB.SelectedIndexChanged += new System.EventHandler(this.producerCB_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.year2);
            this.groupBox4.Controls.Add(this.year1);
            this.groupBox4.Controls.Add(this.year);
            this.groupBox4.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(406, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 75);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Год выпуска";
            // 
            // year
            // 
            this.year.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.year.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year.Location = new System.Drawing.Point(6, 30);
            this.year.Mask = "0000";
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(168, 32);
            this.year.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dur2);
            this.groupBox3.Controls.Add(this.dur1);
            this.groupBox3.Controls.Add(this.duration);
            this.groupBox3.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(605, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 75);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Длительность(м)";
            // 
            // duration
            // 
            this.duration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.duration.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.duration.Location = new System.Drawing.Point(6, 24);
            this.duration.Multiline = true;
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(170, 37);
            this.duration.TabIndex = 13;
            // 
            // adress1
            // 
            this.adress1.Controls.Add(this.info);
            this.adress1.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adress1.Location = new System.Drawing.Point(406, 158);
            this.adress1.Name = "adress1";
            this.adress1.Size = new System.Drawing.Size(381, 174);
            this.adress1.TabIndex = 30;
            this.adress1.TabStop = false;
            this.adress1.Text = "Описание";
            // 
            // info
            // 
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(6, 24);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(369, 136);
            this.info.TabIndex = 13;
            // 
            // year1
            // 
            this.year1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.year1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year1.Location = new System.Drawing.Point(6, 30);
            this.year1.Mask = "0000";
            this.year1.Name = "year1";
            this.year1.Size = new System.Drawing.Size(71, 32);
            this.year1.TabIndex = 31;
            this.year1.Visible = false;
            // 
            // year2
            // 
            this.year2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.year2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year2.Location = new System.Drawing.Point(100, 30);
            this.year2.Mask = "0000";
            this.year2.Name = "year2";
            this.year2.Size = new System.Drawing.Size(74, 32);
            this.year2.TabIndex = 32;
            this.year2.Visible = false;
            // 
            // dur1
            // 
            this.dur1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dur1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dur1.Location = new System.Drawing.Point(6, 24);
            this.dur1.Multiline = true;
            this.dur1.Name = "dur1";
            this.dur1.Size = new System.Drawing.Size(79, 37);
            this.dur1.TabIndex = 14;
            this.dur1.Visible = false;
            // 
            // dur2
            // 
            this.dur2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dur2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dur2.Location = new System.Drawing.Point(97, 25);
            this.dur2.Multiline = true;
            this.dur2.Name = "dur2";
            this.dur2.Size = new System.Drawing.Size(79, 37);
            this.dur2.TabIndex = 15;
            this.dur2.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.fam);
            this.groupBox5.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(12, 257);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(381, 75);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Фамилия режиссера";
            this.groupBox5.Visible = false;
            // 
            // fam
            // 
            this.fam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fam.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fam.Location = new System.Drawing.Point(6, 24);
            this.fam.Multiline = true;
            this.fam.Name = "fam";
            this.fam.Size = new System.Drawing.Size(369, 37);
            this.fam.TabIndex = 13;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.name);
            this.groupBox6.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(406, 158);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(381, 75);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Имя режиссера";
            this.groupBox6.Visible = false;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(6, 24);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(369, 37);
            this.name.TabIndex = 13;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.patron);
            this.groupBox7.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox7.Location = new System.Drawing.Point(406, 257);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(381, 75);
            this.groupBox7.TabIndex = 27;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Отчество режиссера";
            this.groupBox7.Visible = false;
            // 
            // patron
            // 
            this.patron.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patron.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patron.Location = new System.Drawing.Point(6, 24);
            this.patron.Multiline = true;
            this.patron.Name = "patron";
            this.patron.Size = new System.Drawing.Size(369, 37);
            this.patron.TabIndex = 13;
            // 
            // addOrEditFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(799, 414);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.adress1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.studio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainL1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addOrEditFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addOrEditFilm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.studio.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.adress1.ResumeLayout(false);
            this.adress1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label mainL1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.GroupBox studio;
        public System.Windows.Forms.ComboBox studioCB;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox producerCB;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.MaskedTextBox year;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox duration;
        public System.Windows.Forms.GroupBox adress1;
        public System.Windows.Forms.TextBox info;
        public System.Windows.Forms.MaskedTextBox year2;
        public System.Windows.Forms.MaskedTextBox year1;
        public System.Windows.Forms.TextBox dur2;
        public System.Windows.Forms.TextBox dur1;
        public System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.TextBox patron;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.TextBox fam;
        public System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.TextBox name;
    }
}