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
        public bool Availability { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public Rooms(int number, double pricenight, bool availability, string status, string type)
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
            if (incluidesText.Trim().ToLower().Equals("incluido"))
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
            Console.WriteLine("\n1. Habitación Simple");
            Console.WriteLine("2. Habitación Doble");
            Console.WriteLine("3. Suite");
            Console.WriteLine("4. Habitación Deluxe");
            Console.Write("\nIngrese una Opción: ");
            int optionRoomsMenu = int.Parse(Console.ReadLine());
            return optionRoomsMenu;
        }
        public void AddRoom(List<Rooms> roomsList, int numberRoom, double priceRoom, int bedsRoom)
        {
            try
            {
                do
                {
                    Console.Clear();
                    Console.Write("\nNúmero de Habitación: ");
                    numberRoom = int.Parse(Console.ReadLine());
                    if (numberRoom >= 0)
                    {
                        do
                        {
                            Console.Clear();
                            Console.Write("\nPrecio de la Habitación: ");
                            priceRoom = double.Parse(Console.ReadLine());
                            if (priceRoom > 0)
                            {
                                RoomsMenu();
                                string typeRoom = "";
                                switch (RoomsMenu())
                                {
                                    case 1:
                                        typeRoom = "\nHabitación Simple";
                                        do
                                        {
                                            Console.Clear();
                                            Console.Write("\nCantidad de Camas");
                                            bedsRoom = int.Parse(Console.ReadLine());
                                            if (bedsRoom > 0)
                                            {
                                                roomsList.Add(new SimpleRoom(numberRoom, priceRoom, true, "", typeRoom, bedsRoom));
                                                Console.WriteLine($"\nLa Habitación {numberRoom} fue Añadida con Éxito");
                                                Console.ReadKey();
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nIngrese un Valor Mayor a 0");
                                                Console.ReadKey();
                                            }
                                        } while (bedsRoom <= 0);
                                        break;
                                    case 2:
                                        typeRoom = "\nHabitación Doble";
                                        Console.Write("\nVista al Mar (Incluido / No Incluido): ");
                                        string seaview = Console.ReadLine();
                                        roomsList.Add(new DoubleRoom(numberRoom, priceRoom, true, "", typeRoom, MaskIncluidesBool(seaview)));
                                        Console.WriteLine($"\nLa Habitación {numberRoom} fue Añadida con Éxito");
                                        Console.ReadKey();
                                        break;
                                    case 3:
                                        typeRoom = "\nSuite";
                                        Console.Write("\nNúmero de Habitaciones: ");
                                        int roomsNumber = int.Parse(Console.ReadLine());
                                        Console.Write("\nJacuzzi (Incluido / No Incluido): ");
                                        string jacuzzi = Console.ReadLine();
                                        roomsList.Add(new Suite(numberRoom, priceRoom, true, "", typeRoom, roomsNumber, MaskIncluidesBool(jacuzzi)));
                                        Console.WriteLine($"\nLa Habitación {numberRoom} fue Añadida con Éxito");
                                        Console.ReadKey();
                                        break;
                                    case 4:
                                        typeRoom = "\nHabitación Deluxe";
                                        Console.Write("\nServicios: ");
                                        string services = Console.ReadLine();
                                        roomsList.Add(new DeluxeRoom(numberRoom, priceRoom, true, "", typeRoom, services));
                                        Console.WriteLine($"\nLa Habitación {numberRoom} fue Añadida con Éxito");
                                        Console.ReadKey();
                                        break;
                                    default:
                                        Console.WriteLine("\nIngrese una Opción Válida (1 - 4)");
                                        Console.ReadKey();
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nIngrese un Valor Mayor a 0");
                                Console.ReadKey();
                            }
                        } while (priceRoom <= 0);
                    }
                    else
                    {
                        Console.WriteLine("\nIngrese un Número de Habitación Mayor a 0");
                        Console.ReadKey();
                    }
                } while (numberRoom < 0);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nERROR!, Datos Inválidos");
                Console.ReadKey();
            }
        }
        public virtual void ShowRoom()
        {
            Console.WriteLine($"Habitación No. {Number}");
            Console.WriteLine($"Precio: {PriceNight}");
            Console.WriteLine($"Disponibilidad: {Availability}");
            Console.WriteLine($"Estado: {Status}");
            Console.WriteLine($"Tipo: {Type}");
            Console.ReadKey();
        }
        public void ShowAllRooms(List<Rooms> roomsList)
        {
            if (roomsList.Count == 0)
            {
                Console.WriteLine("No Existen Habitaciones Registradas");
                Console.ReadKey();
            }
            else
            {
                foreach (var room in roomsList)
                {
                    room.ShowRoom();
                }
                Console.ReadKey();
            }
        }
    }
}
