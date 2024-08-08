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
        public static int ShowMenuInfo()
        {
            Console.WriteLine("Mostrar Información");
            Console.WriteLine("1. Habitaciones Simples (1 - 25)");
            Console.WriteLine("2. Habitaciones Dobles (26 - 50)");
            Console.WriteLine("3. Suites (51 - 75)");
            Console.WriteLine("4. Habitaciones Deluxe (76 - 100)");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Seleccione una Opción: ");
            int infoMenuOption = int.Parse(Console.ReadLine());
            return infoMenuOption;
        }
        public static void SwitchMenuInfo(ref List<Rooms> roomsList, bool infoContinue)
        {
            while (infoContinue = true)
            {
                switch (ShowMenuInfo())
                {
                    case 1:
                        SimpleRoomInfo(ref roomsList);
                        break;
                    case 2:
                        DoubleRoomInfo(ref roomsList);
                        break;
                    case 3:
                        SuitesInfo(ref roomsList);
                        break;
                    case 4:
                        DeluxeRoomInfo(ref roomsList);
                        break;
                    case 5:
                        infoContinue = false;
                        break;
                    default:
                        Console.WriteLine("Seleccione una Opción Válida (1 - 5)");
                        Console.ReadKey();
                        break;
                } 
            }
        }
        public static void SimpleRoomInfo(ref List<Rooms> roomsList)
        {
            Console.WriteLine("Habitaciones Simples");
            foreach (SimpleRoom simpleRoom in roomsList)
            {
                Console.WriteLine($"Número: {simpleRoom.Number}");
                Console.WriteLine($"Precio: {simpleRoom.PriceNight}");
                Console.WriteLine($"Disponibilidad: {simpleRoom.Availability}");
                Console.WriteLine($"Estado: {simpleRoom.Status}");
                Console.WriteLine($"No. Camas: {simpleRoom.BedQuantity}");
                Console.WriteLine("------------------------------");
            }
            Console.ReadKey();
        }
        public static void DoubleRoomInfo(ref List<Rooms> roomsList)
        {
            Console.WriteLine("Habitaciones Dobles");
            foreach (DoubleRoom doubleRoom in roomsList)
            {
                Console.WriteLine($"Número: {doubleRoom.Number}");
                Console.WriteLine($"Precio: {doubleRoom.PriceNight}");
                Console.WriteLine($"Disponibilidad: {doubleRoom.Availability}");
                Console.WriteLine($"Estado: {doubleRoom.Status}");
                Console.WriteLine($"Vista al Mar: {doubleRoom.Seaview}");
                Console.WriteLine("------------------------------");
            }
            Console.ReadKey();
        }
        public static void SuitesInfo(ref List<Rooms> roomsList)
        {
            Console.WriteLine("Suites");
            foreach (Suite suite in roomsList)
            {
                Console.WriteLine($"Número: {suite.Number}");
                Console.WriteLine($"Precio: {suite.PriceNight}");
                Console.WriteLine($"Disponibilidad: {suite.Availability}");
                Console.WriteLine($"Estado: {suite.Status}");
                Console.WriteLine($"Número de Habitaciones: {suite.NumberRooms}");
                Console.WriteLine($"Jacuzzi: {suite.Jacuzzi}");
                Console.WriteLine("------------------------------");
            }
            Console.ReadKey();
        }
        public static void DeluxeRoomInfo(ref List<Rooms> roomsList)
        {
            Console.WriteLine("Habitaciones Deluxe");
            foreach (DeluxeRoom deluxeRoom in roomsList)
            {
                Console.WriteLine($"Número: {deluxeRoom.Number}");
                Console.WriteLine($"Precio: {deluxeRoom.PriceNight}");
                Console.WriteLine($"Disponibilidad: {deluxeRoom.Availability}");
                Console.WriteLine($"Estado: {deluxeRoom.Status}");
                Console.WriteLine($"Servicios Extras: {deluxeRoom.ExtraServices}");
                Console.WriteLine("------------------------------");
            }
            Console.ReadKey();
        }
        public Rooms(int number, double pricenight, bool availability, string status)
        {
            Number = number;
            PriceNight = pricenight;
            Availability = availability;
            Status = status;
        }
    }
}
