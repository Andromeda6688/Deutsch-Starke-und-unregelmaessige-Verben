using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class StarkeVerben : Form
    {
        Loader myLoader;
        List<KonjugiertesVerb> VerbenList;
        List<KonjugiertesVerb> VerbenToCheck;
        Random r;
        KonjugiertesVerb myVerb;
        int Scores = 0;
        int VerbsCount = 10;

        public StarkeVerben()
        {
            InitializeComponent();

            Restart();

        }

        public void Restart()
        {
            r = new Random();

            myLoader = new Loader();
            myLoader.ReadVerbs("VerbFormen.xlsx");

            VerbenList = myLoader.VerbenList;

            lbVerbsLeft.Text = (VerbsCount + 1).ToString();
            Scores = 0;
            lbScores.Text = Scores.ToString();

            VerbenToCheck = SelectVerbsToCheck(VerbenList);

            DisplayNewVerb(); 
        }

        private void linkTip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkTip.Text = myVerb.Tip;
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }

        private List<KonjugiertesVerb> SelectVerbsToCheck(List<KonjugiertesVerb> p_VerbenList)
        {
            List<KonjugiertesVerb> _VerbenToCheck = new List<KonjugiertesVerb>();

            for (int i = 0; i < VerbsCount; i++)
            {
                int number = r.Next(p_VerbenList.Count);
                _VerbenToCheck.Add(p_VerbenList[number]);
                p_VerbenList.Remove(p_VerbenList[number]);
            }
            return _VerbenToCheck;
        }

        private void DisplayNewVerb()
        {
            if (VerbenToCheck.Count>0)
            {
                myVerb = VerbenToCheck[r.Next(VerbenToCheck.Count)];
                VerbenToCheck.Remove(myVerb);

                tbPraesens.Text = myVerb.Praesens;                
                tbHilfsverb.Text = myVerb.Hilfsverb;
                lbTranslation.Text = myVerb.Translation;
                linkTip.Text = "Show me a tip";
               
                lbVerbsLeft.Text = ((Convert.ToInt32(lbVerbsLeft.Text)) - 1).ToString();

                tbPraeteritum.BackColor = Color.White;
                tbPerfekt.BackColor = Color.White;
                tbPraeteritum.Text = "";
                tbPerfekt.Text = "";

                tbPraeteritum.Focus();
            }
            else
            {
                myLoader.WriteStatistics(Scores);

                Chart ChartWindow = new Chart(myLoader);
                ChartWindow.Owner = this;
                ChartWindow.ShowDialog();

                DialogResult UserAnswer =
                MessageBox.Show(String.Format("You have scored {0} points out of 1000 possible.\r\nWould you like to train again?", Scores),"", MessageBoxButtons.YesNo); 

                if (UserAnswer == DialogResult.Yes)
                {
                    Restart();
                }
                else
                {
                    this.Close();
                }
            
            }           
 
        }

        private void CheckAnswer ()
        {
            int scoresGain = 0;

            if (tbPraeteritum.Text == myVerb.Praeteritum)
            {
                tbPraeteritum.BackColor = Color.FromArgb(192, 255, 192);//green
                scoresGain += 1000 / VerbsCount / 2;
            }
            else
            {
                tbPraeteritum.Text = myVerb.Praeteritum;
                tbPraeteritum.BackColor = Color.FromArgb(255, 192, 192);//red
            }

            if (tbPerfekt.Text == myVerb.Perfekt)
            {
                tbPerfekt.BackColor = Color.FromArgb(192, 255, 192);//green
                scoresGain += 1000 / VerbsCount / 2;
            }
            else
            {
                tbPerfekt.Text = myVerb.Perfekt;
                tbPerfekt.BackColor = Color.FromArgb(255, 192, 192);//red
            }

            if (linkTip.Text!="Show me a tip")//the tip is used
            {
                scoresGain /= 5;
            }

            Scores += scoresGain;
            lbScores.Text = Scores.ToString();

            timer.Start();//wait till show the next verb

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            DisplayNewVerb();
        }

     /*   private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btNext.PerformClick();
        }*/

        string SymbolToAdd;

        private void btInsertSs_Click(object sender, EventArgs e)
        {
            SymbolToAdd = "ß";
            AddSymbol(SymbolToAdd);
        }

        private void btInsertAe_Click(object sender, EventArgs e)
        {
            SymbolToAdd = "ä";
            AddSymbol(SymbolToAdd);
        }

        private void btInsertOe_Click(object sender, EventArgs e)
        {
            SymbolToAdd = "ö";
            AddSymbol(SymbolToAdd);
        }

        private void btInsertUe_Click(object sender, EventArgs e)
        {
            SymbolToAdd = "ü";
            AddSymbol(SymbolToAdd);
        }

        bool IsTbPraeteritumLastActive = false;
        bool IsTbPerfektLastActive = false;

        private void AddSymbol(string p_symbol)
        {
            if (IsTbPraeteritumLastActive)
            {
                tbPraeteritum.Text = tbPraeteritum.Text + p_symbol;
            }
            else if (IsTbPerfektLastActive)
            {
                tbPerfekt.Text = tbPerfekt.Text + p_symbol;
            }
        }
        private void tbPraeteritum_KeyUp(object sender, KeyEventArgs e)
        {
            IsTbPraeteritumLastActive = true;
            IsTbPerfektLastActive = false;
        }

        private void tbPerfekt_KeyUp(object sender, KeyEventArgs e)
        {
            IsTbPraeteritumLastActive = false;
            IsTbPerfektLastActive = true;
        }

      /*  private void button1_Click(object sender, EventArgs e)
        {
            
        }*/

        private void btShowStatistics_Click(object sender, EventArgs e)
        {
            Chart ChartWindow = new Chart(myLoader);
            ChartWindow.Show();            
        }
    }
}
