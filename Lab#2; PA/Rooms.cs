using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2__PA
{
    public class Rooms
    {
        public int Number { get; set; }
        public double PriceNight { get; set; }
        public bool Availability { get; set; }
        public string Status { get; set; }
        
        public Rooms(int number, double pricenight, bool availability, string status)
        {
            Number = number;
            PriceNight = pricenight;
            Availability = availability;
            Status = status;
        }
    }
}
