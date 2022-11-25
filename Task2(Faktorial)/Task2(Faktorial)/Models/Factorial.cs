using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2_Faktorial_.Models
{
    public class Factorial:Exception
    {

        public void CalculateFactorial(int num)
        {
           
            try
            {
                int i = 1;
                while (num != 1)
                {
                    i = i * num;
                    num--;

                    if (num < 0)
                    {
                        throw new Exception("Duzgun eded daxil edin");
                    }
                }
                Console.WriteLine(i);
               
                


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
          

        }

       
    }
}
