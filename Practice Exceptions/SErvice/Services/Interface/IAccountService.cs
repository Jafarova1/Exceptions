using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SErvice.Services.Interface
{
    public interface IAccountService
    {
        bool Registr(User user);

        User GetUserBYId(int? id);
    }
}
