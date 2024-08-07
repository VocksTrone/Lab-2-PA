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
        public Suite(int numberrooms, bool jacuzzi)
        {
            NumberRooms = numberrooms;
            Jacuzzi = jacuzzi;
        }
    }
}
