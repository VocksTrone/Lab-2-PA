using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2__PA
{
    public class DoubleRoom : Rooms
    {
        public bool Seaview { get; set; }
        public DoubleRoom(bool seaview)
        {
            Seaview = seaview;
        }
    }
}
