using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject
{
    internal class Admin8BL
    {
        public string name {  get; set; }
        public string room_name {  get; set; }
        public string room_type { get; set; }
        public string day_of_week { get; set; }
        public string start_time {  get; set; }
        public string end_time { get; set; }
        public Admin8BL (string name, string room_name, string room_type,  string day_of_week, string start_time, string end_time)
        {
            this.name = name;
            this.room_name = room_name;
            this.room_type = room_type;
            this.end_time = end_time;
            this.start_time = start_time;
            this.day_of_week = day_of_week;
        }
    }
}
