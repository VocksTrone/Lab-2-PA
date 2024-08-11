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
        public DeluxeRoom(int number, double pricenight, bool availability, string status, string type, string extraservices) : base(number, pricenight, availability, status, type)
        {
            ExtraServices = extraservices;
        }
        public override void ShowRoom()
        {
            base.ShowRoom();
            Console.WriteLine($"Servicios: {ExtraServices}");
        }
    }
}
