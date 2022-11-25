using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Faktorial_.Exceptions
{
    public class CantBeNegativeException:Exception
    {
        public CantBeNegativeException(string message):base(message)
        {

        }
    }
}
