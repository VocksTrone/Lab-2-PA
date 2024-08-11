using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2__PA
{
    public class Rooms
    {
        public int Number { get; set; }
        public double PriceNight { get; set; }
        public string Availability { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public Rooms(int number, double pricenight, string availability, string status, string type)
        {
            Number = number;
            PriceNight = pricenight;
            Availability = availability;
            Status = status;
            Type = type;
        }
    }
}
