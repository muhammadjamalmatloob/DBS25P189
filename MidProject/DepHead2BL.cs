using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject
{
    internal class DepHead2BL
    {
        public string name {  get; set; }
        public string title {  get; set; }
        public string term {  get; set; }
        public int year { get; set; } 
        public DepHead2BL(string name, string title, string term, int year)
        {
            this.title = title;
            this.name = name;
            this.term = term;
            this.year = year;
        }
    }
}
