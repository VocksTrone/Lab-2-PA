using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2__PA
{
    public class DeluxeRoom : Rooms
    {
        public string ExtraServices { get; set; }
        public DeluxeRoom(string extraservices)
        {
            ExtraServices = extraservices;
        }
    }
}
