using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject
{
    internal class Admin9DL
    {
        public static List<Admin9BL> rooms = new List<Admin9BL>();
        public static int AddRoom(Admin9BL rm)
        {
            string query = $"Insert into rooms (room_name, room_type, capacity) values" +
                $" ('{rm.room_name}','{rm.room_type}',{rm.capacity});";
            int r = DatabaseHelper.Instance.Update(query);
            return r;
        }
        public static void LoadData()
        {
            string query = $"Select room_name, room_type, capacity From rooms";
            var reader = DatabaseHelper.Instance.getData(query);
            rooms.Clear();
            while (reader.Read())
            {
                rooms.Add(new Admin9BL(reader["room_name"].ToString(), reader["room_type"].ToString(), Convert.ToInt32(reader["capacity"])));
            }
        }
        public static int Update(string colname, string item, int id)
        {
            string query = $"Update rooms set {colname} = '{item}' where room_id = {id + 1};";
            int row = DatabaseHelper.Instance.Update(query);
            return row;
        }
    }
}
