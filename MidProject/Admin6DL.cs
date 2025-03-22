using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject
{
    internal class Admin6DL
    {
        public static List<Admin6BL> projects = new List<Admin6BL>();
        public static int AddProject(Admin6BL p)
        {
            string query = $"Insert into projects (title, description) values" +
                $" ('{p.title}','{p.description}');";
            int r = DatabaseHelper.Instance.Update(query);
            return r;
        }
        public static void LoadData()
        {
            string query = $"Select title, description From projects";
            var reader = DatabaseHelper.Instance.getData(query);
            projects.Clear();
            while (reader.Read())
            {
                projects.Add(new Admin6BL(reader["title"].ToString(), reader["description"].ToString()));
            }
        }
        public static int Update(string colname, string item, int id)
        {
            string query = $"Update projects set {colname} = '{item}' where project_id = {id + 1};";
            int row = DatabaseHelper.Instance.Update(query);
            return row;
        }
    }
}
