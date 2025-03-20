using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject
{
    internal class Admin1BL
    {
        public string Username { get; set; }
        public string Name {  get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Designation { get; set; }
        public string Reasearch_Area { get; set; }
        public int Teaching_Hours {  get; set; }
        public Admin1BL(string Username,string Name, string Email, string Contact, string Designation, string Reasearch_Area,int Teaching_Hours)
        {
            this.Username = Username;
            this.Name = Name;
            this.Email = Email;
            this.Contact = Contact;
            this.Designation = Designation;
            this.Reasearch_Area = Reasearch_Area;
            this.Teaching_Hours = Teaching_Hours;
        }
        public Admin1BL()
        {

        }
    }
}
