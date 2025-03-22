using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject
{
    internal class PasswordResetDL
    {
        public static int UpdatePassword(string password, string email)
        {
            string query = $"Update users set password_hash = '{HashPassword(password)}' Where email = '{email}'";
            int row = DatabaseHelper.Instance.Update(query);
            return row;
        }
        public static string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
