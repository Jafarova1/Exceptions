using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class MyList
    {
       public static void GetAll()
        {
            var rooms = Add();

            foreach (var item in rooms)
            {

                Console.Writeline(item.Name);
            }
       
        }
      
        public static List<Room> Add()
        {
            List<Room> rooms = new List<Room>();
            Room room1 = new Room()
            {
                Name = "Otaq1"
                
            };
            Room room2 = new Room()
            {
                Name = "Otaq2"
            };
            Room room3 = new Room()
            {
                Name = "Otaq3"
            };
            rooms.Add(room1);
            rooms.Add(room2);
            rooms.Add(room3);
            rooms.Clear();
            return rooms;
           
        }
    }
}
