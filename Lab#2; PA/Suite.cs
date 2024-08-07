using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2__PA
{
    public class Suite : Rooms
    {
        public int NumberRooms { get; set; }
        public bool Jacuzzi { get; set; }
        public Suite(int number, double pricenight, bool availability, string status, int numberrooms, bool jacuzzi) : base(number, pricenight, availability, status) 
        {
            NumberRooms = numberrooms;
            Jacuzzi = jacuzzi;
        }
    }
}
