using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2__PA
{
    public class SimpleRoom : Rooms
    {
        public int BedQuantity { get; set; }
        public SimpleRoom(int number, double pricenight, bool availability, string status, int bedquantity) : base(number, pricenight, availability, status)
        {
            BedQuantity = bedquantity;
        }
    }
}
