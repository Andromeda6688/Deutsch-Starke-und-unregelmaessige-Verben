namespace CodedUITestProject1
{
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using WindowsFormsApplication1;

    
    
    public partial class UIMap
    {     

        public void EnterAnswer(string p_Praeteritum, string p_Perfekt, bool IsTipUsed)
        {
            #region Variable Declarations
            WinEdit uITbPraeteritumEdit = this.UIStarkeundunregelmäßiWindow.UITbPraeteritumWindow.UITbPraeteritumEdit;
            WinEdit uITbPerfektEdit = this.UIStarkeundunregelmäßiWindow.UITbPerfektWindow.UITbPerfektEdit;
            WinHyperlink uIShowmeatipHyperlink = this.UIStarkeundunregelmäßiWindow.UIShowmeatipText.UIShowmeatipHyperlink;
            #endregion

            uITbPraeteritumEdit.Text = p_Praeteritum;
            uITbPerfektEdit.Text = p_Perfekt;

            if (IsTipUsed)
            {
                Mouse.Click(uIShowmeatipHyperlink);                
            }
        }


        public KonjugiertesVerb GetVerbToCheck(List<KonjugiertesVerb> p_VerbList)
        {
            #region Variable Declarations                
            WinEdit uITbPraesensEdit = this.UIStarkeundunregelmäßiWindow.UILeidenWindow.UITbPraesensEdit;
            #endregion
           

            string currVerbPraesens = uITbPraesensEdit.Text;

            KonjugiertesVerb currVerb = p_VerbList.Where(v => v.Praesens == currVerbPraesens).First();

            return currVerb;
        }

        public void CheckAnswer(int p_expectedScore)
        {
            #region Variable Declarations
            // WinEdit uITbScoresEdit = this.UIStarkeundunregelmäßiWindow.UIItem0Window.UITbScoresEdit;
            WinText uIItem0Text = this.UIStarkeundunregelmäßiWindow.UIItem0Window1.UIItem0Text;
            WinButton uIOKButton = this.UIStarkeundunregelmäßiWindow.UIOKWindow.UIOKButton;
            #endregion

            int initialScore = Convert.ToInt32(uIItem0Text.DisplayText);
            Mouse.Click(uIOKButton, new Point(88, 11));
            int resultScore = Convert.ToInt32(uIItem0Text.DisplayText);

            Assert.AreEqual((resultScore - initialScore), p_expectedScore);
        }

    }
}
