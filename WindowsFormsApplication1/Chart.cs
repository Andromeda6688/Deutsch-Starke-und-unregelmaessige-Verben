using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class Chart : Form
    {
        public Chart(Loader p_myLoader)
        {
            InitializeComponent();

            myLoader = p_myLoader;
        }

        Loader myLoader;

        private void Chart_Load(object sender, EventArgs e)
        {
            DrawGraphics();
        }

        private void DrawGraphics()
        {
            chartControl.Series.Clear();
            chartControl.Legends.Clear();

            List<Result> myStatistics = myLoader.ReadStatistics();

            if (myStatistics.Count > 0)
            {
                //this should not ever work, but just a precaution
                chartControl.Visible = true;
                lbNoStatistics.Visible = false;
                btClear.Enabled = true;

                //graphs margins
                DateTime minDate = myStatistics.Min(s => s.Date);
                DateTime MaxDate = myStatistics.Max(s => s.Date);

                Series ScoresSeries = this.chartControl.Series.Add("Scores");
                ScoresSeries.ChartType = SeriesChartType.Spline;

                Axis ox = new Axis();
                ox.Title = "Date";
                ox.LabelStyle.Angle = 90;
                ox.Interval = 1;
                ox.MajorGrid.LineColor = Color.LightGray;
                chartControl.ChartAreas[0].AxisX = ox;

                Axis oy = new Axis();
                oy.Title = "Scores";
                oy.Interval = 50;
                oy.Maximum = 1100;
                oy.Minimum = 0;
                oy.MajorGrid.LineColor = Color.LightGray;
                chartControl.ChartAreas[0].AxisY = oy;

                for (int i = 0; i <= (MaxDate - minDate).Days; i++)
                {
                    DateTime currDate = minDate.AddDays(i);

                    List<Result> currResult = myStatistics.Where(r => r.Date == currDate).ToList();

                    if (currResult.Count > 0)
                    {
                        DataPoint point1 = new DataPoint(i, Convert.ToDouble(currResult[0].Score));
                        //we use the number of the day in Point coordinates instead of string value not to miss days without data in our Gpaph
                        //without these spaces the chart of the progress is not realictic
                        point1.AxisLabel = currDate.ToShortDateString();
                        ScoresSeries.Points.Add(point1);
                    }
                }
            }
            else
            {
                chartControl.Visible = false;
                lbNoStatistics.Visible = true;
                btClear.Enabled = false;
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            DialogResult UserAnswer =
               MessageBox.Show(
               String.Format("It will be impossible to restore your previous Statistics.\r\nAre you 100% sure that you still want to delete your previous Results?"), 
               "Warning!", 
               MessageBoxButtons.YesNo);

            if (UserAnswer == DialogResult.Yes)
            {
                myLoader.ClearStatistics();
                MessageBox.Show("Done!");

                DrawGraphics();
            }
           
        }
    }
}
