namespace BD_course_work
{
    partial class AddOrEditThreeColumns
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
            this.button1 = new System.Windows.Forms.Button();
            this.fam = new System.Windows.Forms.TextBox();
            this.mainL2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(166, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fam
            // 
            this.fam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fam.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fam.Location = new System.Drawing.Point(155, 72);
            this.fam.Multiline = true;
            this.fam.Name = "fam";
            this.fam.Size = new System.Drawing.Size(317, 40);
            this.fam.TabIndex = 4;
            // 
            // mainL2
            // 
            this.mainL2.AutoSize = true;
            this.mainL2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainL2.Location = new System.Drawing.Point(117, 9);
            this.mainL2.Name = "mainL2";
            this.mainL2.Size = new System.Drawing.Size(281, 32);
            this.mainL2.TabIndex = 3;
            this.mainL2.Text = "Добавить режиссера";
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(155, 155);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(317, 40);
            this.name.TabIndex = 6;
            // 
            // patronymic
            // 
            this.patronymic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patronymic.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymic.Location = new System.Drawing.Point(155, 237);
            this.patronymic.Multiline = true;
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(317, 40);
            this.patronymic.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(86, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Отчество";
            // 
            // AddOrEditThreeColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fam);
            this.Controls.Add(this.mainL2);
            this.Name = "AddOrEditThreeColumns";
            this.Text = "Добавление";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddOrEditThreeColumns_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox fam;
        public System.Windows.Forms.Label mainL2;
        public System.Windows.Forms.TextBox name;
        public System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}