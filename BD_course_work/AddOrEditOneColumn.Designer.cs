namespace BD_course_work
{
    partial class AddOrEditOneColumn
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
            this.countryTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainL1
            // 
            this.mainL1.AutoSize = true;
            this.mainL1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainL1.Location = new System.Drawing.Point(77, 9);
            this.mainL1.Name = "mainL1";
            this.mainL1.Size = new System.Drawing.Size(234, 32);
            this.mainL1.TabIndex = 0;
            this.mainL1.Text = "Добавить страну";
            // 
            // countryTB
            // 
            this.countryTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countryTB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryTB.Location = new System.Drawing.Point(12, 76);
            this.countryTB.Multiline = true;
            this.countryTB.Name = "countryTB";
            this.countryTB.Size = new System.Drawing.Size(360, 40);
            this.countryTB.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(118, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.countryTB);
            this.Controls.Add(this.mainL1);
            this.Name = "AddOrEdit";
            this.Text = "Добавление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox countryTB;
        public System.Windows.Forms.Label mainL1;
    }
}