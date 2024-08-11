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
        public string MaskAvailability(bool availability)
        {
            if (availability == true)
            {
                return "Disponible";
            }
            else
            {
                return "No Disponible";
            }
        }
        public string MaskIncluides(bool incluidesText)
        {
            if (incluidesText == true)
            {
                return "Incluido";
            }
            else
            {
                return "No Incluido";
            }
        }
        public bool MaskIncluidesBool(string incluidesText)
        {
            if (incluidesText == "Incluido")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int RoomsMenu()
        {
            Console.WriteLine("Tipos de Habitaciones");
            Console.WriteLine("1. Habitación Simple");
            Console.WriteLine("2. Habitación Doble");
            Console.WriteLine("3. Suite");
            Console.WriteLine("4. Habitación Deluxe");
            Console.Write("Ingrese una Opción: ");
            int optionRoomsMenu = int.Parse(Console.ReadLine());
            return optionRoomsMenu;
        }
    }
}
