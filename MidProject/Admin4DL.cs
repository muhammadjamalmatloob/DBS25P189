using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mysqlx.Crud;

namespace MidProject
{
    internal class Admin4DL
    {
        public static List<Admin4BL> items = new List<Admin4BL>();
        public static void LoadData()
        {
            string query = $"Select item_name From consumables";
            var reader = DatabaseHelper.Instance.getData(query);
            items.Clear();
            while (reader.Read())
            {
                items.Add(new Admin4BL(reader["item_name"].ToString()));
            }
        }
        public static int AddItem(string item)
        {
            string query = $"insert into consumables (item_name) values ('{item}');";
            int row = DatabaseHelper.Instance.Update(query);
            return row;
        }

        public static int Update(string colname , string item, int id)
        {
            string query = $"Update consumables set {colname} = '{item}' where consumable_id = {id + 1};";
            int row = DatabaseHelper.Instance.Update(query);
            return row;  
        }
    }
}
