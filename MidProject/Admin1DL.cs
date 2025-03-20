using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MidProject
{
    internal class Admin1DL
    {
        public static List<Admin1BL> faculties = new List<Admin1BL>();

        public static void LoadData(string username)
        {
            string query = $"SELECT u.username,f.name,u.email,contact,l.value as designation,f.research_area,f.total_teaching_hours FROM users u Natural join faculty f join lookup l ON designation_id = lookup_id";
            var reader = DatabaseHelper.Instance.getData(query);
            faculties.Clear();
            while (reader.Read())
            {
                faculties.Add(new Admin1BL(reader["username"].ToString(), reader["name"].ToString(), reader["email"].ToString(), reader["contact"].ToString(), reader["designation"].ToString(), reader["research_area"].ToString(), Convert.ToInt32(reader["total_teaching_hours"])));
            }
        }
    }
}
