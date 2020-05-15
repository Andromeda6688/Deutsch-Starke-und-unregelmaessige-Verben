namespace WindowsFormsApplication1
{
    partial class Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartControl = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btClear = new System.Windows.Forms.Button();
            this.lbNoStatistics = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl
            // 
            chartArea2.Name = "ChartArea1";
            this.chartControl.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartControl.Legends.Add(legend2);
            this.chartControl.Location = new System.Drawing.Point(12, 12);
            this.chartControl.Name = "chartControl";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartControl.Series.Add(series2);
            this.chartControl.Size = new System.Drawing.Size(887, 561);
            this.chartControl.TabIndex = 0;
            this.chartControl.Text = "chart1";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(384, 588);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(141, 23);
            this.btClear.TabIndex = 1;
            this.btClear.Text = "Clear Statistics";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // lbNoStatistics
            // 
            this.lbNoStatistics.AutoSize = true;
            this.lbNoStatistics.Location = new System.Drawing.Point(295, 259);
            this.lbNoStatistics.Name = "lbNoStatistics";
            this.lbNoStatistics.Size = new System.Drawing.Size(357, 13);
            this.lbNoStatistics.TabIndex = 2;
            this.lbNoStatistics.Text = "The Statistics is empty. Please try to train more and take a look a bit later ;)";
            this.lbNoStatistics.Visible = false;
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 623);
            this.Controls.Add(this.lbNoStatistics);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.chartControl);
            this.Name = "Chart";
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartControl;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label lbNoStatistics;
    }
}