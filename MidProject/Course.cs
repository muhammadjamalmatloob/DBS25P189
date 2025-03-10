using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject
{
    public class Course
    {
        public string name {  get; set; }
        public string type { get; set; }
        public int credit_hours {  get; set; }

        public Course(string name, string type, int credit_hours)
        {
            this.name = name;
            this.type = type;
            this.credit_hours = credit_hours;
        }
    }
}
