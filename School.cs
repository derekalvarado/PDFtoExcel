using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFtoExcel
{
    class School
    {
        public string Name { get; set; }
        public int StudentBodyCount { get; set; }
        public int Disadvantaged { get; set; }
        public decimal pcntDisadvantaged { get; set; }
        
        public School(string name, int studentCount, int disadvantageCount, decimal percentDisadvantaged)
        {
            this.Name = name;
            StudentBodyCount = studentCount;
            Disadvantaged = disadvantageCount;
            pcntDisadvantaged = percentDisadvantaged;
        }


    }
}
