namespace BD_course_work
{
    partial class Diagrams
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainL1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // mainL1
            // 
            this.mainL1.BackColor = System.Drawing.Color.RosyBrown;
            this.mainL1.Font = new System.Drawing.Font("Garamond", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainL1.Location = new System.Drawing.Point(-1, -4);
            this.mainL1.Name = "mainL1";
            this.mainL1.Size = new System.Drawing.Size(802, 74);
            this.mainL1.TabIndex = 21;
            this.mainL1.Text = "Диаграммы";
            this.mainL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea13.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chart1.Legends.Add(legend13);
            this.chart1.Location = new System.Drawing.Point(122, 6);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.chart1.Series.Add(series13);
            this.chart1.Size = new System.Drawing.Size(520, 367);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(-2, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 451);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Круговая диаграмма";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Столбчатая диаграмма";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(795, 399);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Трехмерная диаграмма";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea14.AxisX.Interval = 1D;
            chartArea14.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea14.AxisX.IsLabelAutoFit = false;
            chartArea14.AxisX.LabelStyle.Angle = -90;
            chartArea14.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea14);
            legend14.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend14.MaximumAutoSize = 20F;
            legend14.Name = "Legend1";
            this.chart2.Legends.Add(legend14);
            this.chart2.Location = new System.Drawing.Point(10, 16);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series14.ChartArea = "ChartArea1";
            series14.IsVisibleInLegend = false;
            series14.Legend = "Legend1";
            series14.MarkerSize = 1;
            series14.Name = "Series1";
            this.chart2.Series.Add(series14);
            this.chart2.Size = new System.Drawing.Size(776, 368);
            this.chart2.TabIndex = 23;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea15.Area3DStyle.Enable3D = true;
            chartArea15.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.chart3.Legends.Add(legend15);
            this.chart3.Location = new System.Drawing.Point(137, 16);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            series15.YValuesPerPoint = 6;
            this.chart3.Series.Add(series15);
            this.chart3.Size = new System.Drawing.Size(520, 367);
            this.chart3.TabIndex = 23;
            this.chart3.Text = "chart3";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(632, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 36);
            this.button2.TabIndex = 25;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Diagrams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.mainL1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Diagrams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagrams";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label mainL1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Button button2;
    }
}