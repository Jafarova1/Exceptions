using Domain.Models;
using Service.Services;
using SErvice.Services.Interface;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Exceptions.Controllers
{
    public class AccountController
    {

        public void Register()
        {
            
            try
            {
                Console.WriteLine("Add username:");
                string username = Console.ReadLine();

                Console.WriteLine("Add email:");
                string email = Console.ReadLine();
                if (email.Contains("@"))
                {
                    Console.WriteLine("simvolu yoxdur");
                }

                Console.WriteLine("Add password:");
                string password = Console.ReadLine();


                IAccountService service = new AccountService();


                User newUser = new()
                {
                    UserName = username,
                    Email = email,
                    Password = password

                };

                var result = service.Registr(newUser);
                if (!result)
                {
                    throw new Exception("simvolu yoxudr");
                }
                else
                {
                    Console.WriteLine("success");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

           
        }
        public void GetUserById()
        {
            try
            {
                IAccountService service = new AccountService();
               var result= service.GetUserBYId(2);
                Console.WriteLine(result.UserName);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
