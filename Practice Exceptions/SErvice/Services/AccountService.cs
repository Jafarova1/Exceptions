using Domain.Models;
using Service.EXceptions;
using SErvice.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AccountService : IAccountService
    {
        public User GetUserBYId(int? id)
        {

            
            List<User> users = new List<User>();

            users.Add(new User() { Id = 1, UserName = "Test1", Email = "test@gamıl.com", Password = "1234" });
            users.Add(new User() { Id = 2, UserName = "Test2", Email = "test@gamıl.com", Password = "1234" });
            users.Add(new User() { Id = 2, UserName = "Test3", Email = "test@gamıl.com", Password = "1234" });

            var result= users.Find(m => m.Id == id);
            if (result == null)
            {
                throw new NotFoundException("not found");
            }
            return result;
        }

        public bool Registr(User user)
        {
          
            if (user.Email.Contains("@"))
            {
                return true;
            }
            return false;
        }
    }
}
