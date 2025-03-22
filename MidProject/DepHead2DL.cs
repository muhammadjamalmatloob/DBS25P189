using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MidProject
{
    internal class DepHead2DL
    {
        public static List<DepHead2BL> faculty_projects = new List<DepHead2BL>();
        public static int AddFacultyProject(DepHead2BL fp)
        {
            string query = $"Insert into faculty_projects (faculty_id,project_id,semester_id) values " +
                $"((Select faculty_id From faculty Where name = '{fp.name}')," +
                $"(Select project_id From courses Where title = '{fp.title}')," +
                $"(Select semester_id From semesters Where term = '{fp.term}' and year = {fp.year}))";

            int r = DatabaseHelper.Instance.Update(query);
            return r;
        }
        public static void LoadData()
        {
            string query = $"Select name, title, year From faculty_projects Natural Join projects Natural Join semesters Natural Join faculty";
            var reader = DatabaseHelper.Instance.getData(query);
            faculty_projects.Clear();
            while (reader.Read())
            {
                faculty_projects.Add(new DepHead2BL(reader["name"].ToString(), reader["title"].ToString(), reader["term"].ToString(), Convert.ToInt32(reader["year"])));
            }
        }
        public static MySqlDataReader LoadYears(string term)
        {

            string query = $"SELECT DISTINCT year FROM semesters Where term = '{term}'";
            var reader = DatabaseHelper.Instance.getData(query);
            return reader;
        }
        
    }
}

