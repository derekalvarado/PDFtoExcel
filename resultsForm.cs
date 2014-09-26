using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFtoExcel
{
    public partial class resultsForm : Form
    {
        List<string> list;
        public resultsForm(List<string> list)
        {
            this.list = list;
            InitializeComponent();
            LoadList(list);
        }

        private void LoadList(List<string> list)
        {
            foreach (var line in list)
            {
                rtbResults.AppendText(line + "\n");
            }
                
        }
        
    }
}
