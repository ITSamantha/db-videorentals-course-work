namespace BD_course_work
{
    partial class SearchAndFilterStudio
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.search = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.countryCB = new System.Windows.Forms.ComboBox();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainL1
            // 
            this.mainL1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainL1.Font = new System.Drawing.Font("Garamond", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainL1.Location = new System.Drawing.Point(-2, 0);
            this.mainL1.Name = "mainL1";
            this.mainL1.Size = new System.Drawing.Size(637, 43);
            this.mainL1.TabIndex = 22;
            this.mainL1.Text = "Поиск студии";
            this.mainL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(335, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 36);
            this.button2.TabIndex = 36;
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
            this.button1.Location = new System.Drawing.Point(130, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 36);
            this.button1.TabIndex = 35;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.search);
            this.groupBox4.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(130, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(375, 75);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поиск";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.White;
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Location = new System.Drawing.Point(6, 24);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(358, 37);
            this.search.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.countryCB);
            this.groupBox2.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(130, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 75);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Страна*";
            // 
            // countryCB
            // 
            this.countryCB.DropDownHeight = 100;
            this.countryCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countryCB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryCB.FormattingEnabled = true;
            this.countryCB.IntegralHeight = false;
            this.countryCB.Location = new System.Drawing.Point(6, 26);
            this.countryCB.Name = "countryCB";
            this.countryCB.Size = new System.Drawing.Size(358, 35);
            this.countryCB.TabIndex = 1;
            // 
            // SearchAndFilterStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(634, 327);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainL1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchAndFilterStudio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchAndFilter";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label mainL1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TextBox search;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox countryCB;
    }
}