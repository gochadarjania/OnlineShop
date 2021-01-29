using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Extensions
{
    public static class PasswordEncriptor
    {
        public static string CreatePasswordHash(this string password, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password + salt);
            var sha256hash = new SHA256Managed();
            byte[] hash = sha256hash.ComputeHash(bytes);
            var hashString = new StringBuilder();
            foreach (var item in hash)
            {
                hashString.Append(item.ToString("x2"));
            }
            return hashString.ToString();
        }

        public static bool ValidatePasswordHash(this string password, string hash, string salt)
        {
            return (password.CreatePasswordHash(salt) == hash);
        }

        private static string CreateSalt(int size)
        {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            string salt = Convert.ToBase64String(buff);
            return salt;
        }
    }
}
