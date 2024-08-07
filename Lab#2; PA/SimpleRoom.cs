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
        public SimpleRoom(int bedquantity)
        {
            BedQuantity = bedquantity;
        }
    }
}
