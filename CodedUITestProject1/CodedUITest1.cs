using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using WindowsFormsApplication1;


namespace CodedUITestProject1
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {

        Loader myLoader;
        List<KonjugiertesVerb> VerbsList;

        public CodedUITest1()
        {
            myLoader = new Loader();
            myLoader.ReadVerbs(@"I:\euler\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\VerbFormen.xlsx");
            VerbsList = myLoader.VerbenList;           
        }

        [TestMethod]
        public void CorrectVerbTest()
        {
            KonjugiertesVerb currVerb = UIMap.GetVerbToCheck(VerbsList);

            UIMap.EnterAnswer(currVerb.Praeteritum, currVerb.Perfekt, false);

            UIMap.CheckAnswer(100);
        }

        [TestMethod]
        public void CorrectPraeteritumTest()
        {
            KonjugiertesVerb currVerb = UIMap.GetVerbToCheck(VerbsList);

            UIMap.EnterAnswer(currVerb.Praeteritum, "ldhgdgnb", false);

            UIMap.CheckAnswer(50);
        }

        [TestMethod]
        public void CorrectPerfectTest()
        {
            KonjugiertesVerb currVerb = UIMap.GetVerbToCheck(VerbsList);

            UIMap.EnterAnswer("sdhgbsjhbg", currVerb.Perfekt, false);

            UIMap.CheckAnswer(50);
        }

        [TestMethod]
        public void UsedTipCorrectVerbTest()
        {
            KonjugiertesVerb currVerb = UIMap.GetVerbToCheck(VerbsList);

            UIMap.EnterAnswer(currVerb.Praeteritum, currVerb.Perfekt, true);

            UIMap.CheckAnswer(20);
        }

        [TestMethod]
        public void WrongVerbTest()
        {
            KonjugiertesVerb currVerb = UIMap.GetVerbToCheck(VerbsList);

            UIMap.EnterAnswer("jdfkj", "sfhbs", false);

            UIMap.CheckAnswer(0);

        }



        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {

           // this.UIMap.StartApp();
            ApplicationUnderTest.Launch(@"I:\euler\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe");


            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        }

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
