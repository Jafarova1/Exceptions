using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Login_.Models
{
    public class User
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public void CheckUser(string email,string password)
        {
            try
            {
                if (email == "gultajvj@gmail.com" && password == "123g")
                {
                    Console.WriteLine("giriş uğurludur");
                }
                else
                {
                    throw new Exception("User tapilmadi");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           


        }
    }
}
