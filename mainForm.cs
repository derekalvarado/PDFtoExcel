using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;
using System.Text.RegularExpressions;

namespace PDFtoExcel
{
    public partial class mainForm : Form
    {
        PdfReader reader;
        string strText = string.Empty; //string to hold document
        List<string> lines = new List<string>();
        List<string> filteredLines = new List<string>();
        List<School> schools = new List<School>();
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            
            lines = ConvertPDFtoList(reader);

            if (lines.Count > 0) //check to see if anything is in the source List<>
            {
                switch (chkTextSearch.Checked)
                {
                    case (true):
                        {
                            //iterate through lines, looking for lines that start with Austin
                            foreach (var line in lines) 
                                if (line.ToLower().StartsWith(txtTextFilter.Text.ToLower()))
                                    filteredLines.Add(line);
                            if (filteredLines.Count < 1)
                                MessageBox.Show("No rows found",
                                    "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                btnViewResults.Visible = true;
                                MessageBox.Show("Filtering complete", "Result",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }//end case true
                    case (false):
                        //no filtering requested
                        filteredLines = lines;
                        btnViewResults.Visible = true;
                        break;
                }//end switch

                //////////////////
                //Code below was an attempt to match texts to fields in a class called "school"
                //////////////////
                //try
                //{
                //    foreach (var line in filteredLines)
                //    {
                //        string SchoolName = regex.Match(line).ToString();
                //        string[] schoolArray = line.Split(' ');
                //        School currSchool = new School(schoolArray[1],
                //                                        Convert.ToInt32(schoolArray[schoolArray.Length - 3]),
                //                                        Convert.ToInt32(schoolArray[schoolArray.Length - 2]),
                //                                        Convert.ToDecimal(schoolArray[schoolArray.Length - 1]));
                //        schools.Add(currSchool);
                //    }

                //    MessageBox.Show("List filtered.", "Complete", MessageBoxButtons.OK);
                //}
                
            }//end if lines.count > 0
            else
                MessageBox.Show("No document loaded.", 
                    "Blank document", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }//end method convertbutton_click

        private void btnOpen_Click(object sender, EventArgs e)
        {
            
            //Create a file dialog to select PDF file
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files (*.pdf)|*.pdf";
            ofd.Multiselect = false;

            //Show dialog
            DialogResult result = ofd.ShowDialog();

            //Check result and create new PDF reader if file was selected
            if (result == DialogResult.OK)
            {
                //initialize new PdfReader with selected file
                reader = new PdfReader(ofd.FileName);
                //remove ViewResults button from previous file selection
                btnViewResults.Visible = false;
            }
            
        }//end method OpenButton_Click

        private static List<string> ConvertPDFtoList(PdfReader pdfFile)
        {
            List<string> lines = new List<string>();
            
            try
            {
                for (int page = 1; page <= pdfFile.NumberOfPages; page++)
                {
                    //For some reason this has to be within the for loop
                    ITextExtractionStrategy its = new LocationTextExtractionStrategy();

                    //Declare a string to hold a page
                    string s = PdfTextExtractor.GetTextFromPage(pdfFile, page, its);
                    lines.AddRange(s.Split('\n'));

                    ////Convert string to UTF8
                    //s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(
                    //    Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s)));

                    ////Add page to strText
                    //strText += s;
                }
                MessageBox.Show("Text extraction complete", "Success", MessageBoxButtons.OK);
                return lines;
            }//end try
            catch
            {
                return lines;
            }//end catch
        }//end ConvertPDFtoList

        

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (reader != null)
                reader.Close();
        }

        private void btnViewResults_Click(object sender, EventArgs e)
        {
            //create a new resultsForm, pass the list over, and dispaly form
            resultsForm results = new resultsForm(filteredLines);
            results.ShowDialog();
        }
    }//end class mainForm
}//end namespace
