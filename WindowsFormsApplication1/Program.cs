using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Xml;


namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StarkeVerben());
        }

    }

   public class Loader
    {
        public List<KonjugiertesVerb> VerbenList;

        string GetSharedStringItemById(WorkbookPart workbookPart, int id)
        {
            return workbookPart.SharedStringTablePart.SharedStringTable.Elements<SharedStringItem>().ElementAt(id).InnerText;
        }

        public void ReadVerbs(string p_fileName)
        {
            try
            {
                using (SpreadsheetDocument spreadsheetDocument =
                    SpreadsheetDocument.Open(p_fileName, false))
                {
                    WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
                    WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                    SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();

                    VerbenList = new List<KonjugiertesVerb>();

                    foreach (Row r in sheetData.Elements<Row>())
                    {
                        List<Cell> curr_row = r.Elements<Cell>().ToList();

                        string praesens = GetSharedStringItemById(workbookPart, Convert.ToInt32(curr_row[0].CellValue.Text));
                        string praeteritum = GetSharedStringItemById(workbookPart, Convert.ToInt32(curr_row[1].CellValue.Text));
                        string hilfsverb = GetSharedStringItemById(workbookPart, Convert.ToInt32(curr_row[2].CellValue.Text));
                        string perfekt = GetSharedStringItemById(workbookPart, Convert.ToInt32(curr_row[3].CellValue.Text));
                        string translation = GetSharedStringItemById(workbookPart, Convert.ToInt32(curr_row[4].CellValue.Text));
                        string tip = GetSharedStringItemById(workbookPart, Convert.ToInt32(curr_row[5].CellValue.Text));

                        KonjugiertesVerb Verb = new KonjugiertesVerb(praesens, praeteritum, perfekt, hilfsverb, translation, tip);

                        VerbenList.Add(Verb);
                    }
                }
            }
              catch (Exception)
            {
                MessageBox.Show("The source file is lost or not available. Please try to close the Excel file and restart the application");
                
                throw;
            }

        }

        public void WriteStatistics(int p_scores)
        {
            XmlDocument myXml = new XmlDocument();
            XmlElement myRoot;

            try
            {
                myXml.Load("Statistics.xml");
                myRoot = myXml.DocumentElement;
            }
            catch (Exception)
            {
                myXml.CreateXmlDeclaration("1.0", "utf-8", "");
                myRoot = myXml.CreateElement("Statistics");
                myXml.AppendChild(myRoot);
            }           

            XmlText DateText = myXml.CreateTextNode(DateTime.Now.ToShortDateString());
            XmlText ScoresText = myXml.CreateTextNode(p_scores.ToString());
            
            XmlElement ScoreElem = myXml.CreateElement("Score");
            ScoreElem.AppendChild(ScoresText);

            bool IsDateFound = false;

            foreach (XmlNode day in myRoot.ChildNodes)
            {               
                XmlNode WrittenDate = day.Attributes.GetNamedItem("Date");
                if (WrittenDate.Value.ToString() == DateText.Value.ToString())
                {
                    day.AppendChild(ScoreElem);
                    IsDateFound = true;
                }
            }

            if (!IsDateFound)
            {
                XmlElement ResultElem = myXml.CreateElement("DayResult");
                XmlAttribute DateAttr = myXml.CreateAttribute("Date");

                DateAttr.AppendChild(DateText);

                ResultElem.AppendChild(ScoreElem);
                ResultElem.Attributes.Append(DateAttr);

                myRoot.AppendChild(ResultElem);
            }
            
            myXml.Save("Statistics.xml");
        }

        public List<Result> ReadStatistics()
        {
            XmlDocument myXml = new XmlDocument();

            List<Result> ResultsList = new List<Result>();

            try
            {
                myXml.Load("Statistics.xml");
                XmlElement myRoot = myXml.DocumentElement;//statistics

                foreach (XmlNode day in myRoot.ChildNodes)
                {
                    Result myresult = new Result();

                    myresult.Date = Convert.ToDateTime(day.Attributes[0].Value.ToString());
                    myresult.Score = 0;

                    foreach (XmlNode score in day.ChildNodes)
                    {
                        myresult.Score += Convert.ToInt32(score.InnerText);
                    }

                    myresult.Score /= day.ChildNodes.Count;

                    ResultsList.Add(myresult);
                }
            }
            catch { } 
                       
            return ResultsList;
           
            }

        public void ClearStatistics()
        {
            try
            {
                XmlDocument myXml = new XmlDocument();
                myXml.Load("Statistics.xml");
                myXml.DocumentElement.RemoveAll();
                myXml.Save("Statistics.xml");
            }
            catch { } 
        }
    }

    public class Result
    {
        public int Score;
        public DateTime Date;
    }

    public class KonjugiertesVerb
    {
        public string Praesens;
        public string Praeteritum;
        public string Perfekt;
        public string Hilfsverb;
        public string Translation;
        public string Tip;

        public KonjugiertesVerb(string p_praesens, string p_praeteritum, string p_perfekt, string p_hilfsverb, string p_translation, string p_tip)
        {
            Praesens = p_praesens;
            Praeteritum = p_praeteritum;
            Perfekt = p_perfekt;
            Hilfsverb = p_hilfsverb;
            Translation = p_translation;
            Tip = p_tip;
        }
    }
}
