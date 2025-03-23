using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MidProject
{
    internal class Admin8DL
    {
        public static List<Admin8BL> faculty_schedule = new List<Admin8BL>();
        public static int AddFacultySchedule(Admin8BL fp)
        {
            string query = $"Insert into faculty_course_schedule (faculty_course_id,room_id,day_of_week,start_time,end_time) values " +
                $"((Select faculty_course_id From faculty_courses Natural join faculty Where name = '{fp.name}'), " +
                $"(Select room_id From rooms Where room_name = '{fp.room_name}' and room_type = '{fp.room_type}'), '{fp.day_of_week}'," +
                $" '{fp.start_time}', '{fp.end_time}')";
            

            int r = DatabaseHelper.Instance.Update(query);
            return r;
        }
        public static void LoadData()
        {
            string query = $"Select name, room_name, room_type, day_of_week, start_time, end_time From faculty_course_schedule Natural join faculty_courses Natural Join rooms Natural Join faculty";
            var reader = DatabaseHelper.Instance.getData(query);
            faculty_schedule.Clear();
            while (reader.Read())
            {
                faculty_schedule.Add(new Admin8BL(reader["name"].ToString(), reader["room_name"].ToString(), reader["room_type"].ToString(), reader["day_of_week"].ToString(), reader["start_time"].ToString(), reader["end_time"].ToString()));
            }
        }
        
        public static int DeleteFacultySchedule(Admin8BL fp)
        {
            string query = $"delete from faculty_course_schedule Where " +
                $"faculty_course_id = (Select faculty_course_id From faculty_courses Natural join faculty Where name = '{fp.name}') and " +
                $"room_id = (Select room_id From rooms Where room_name = '{fp.room_name}' and room_type = '{fp.room_type}') day_of_week = '{fp.day_of_week}' and " +
                $"start_time = CONVERT(TIME, '{fp.start_time}', 108), end_time = CONVERT(TIME, '{fp.end_time}', 108)";

            int r = DatabaseHelper.Instance.Update(query);
            return r;
        }
    }
}
