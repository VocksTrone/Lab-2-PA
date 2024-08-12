using Lab_2__PA;
bool generalContinue = false; int numberRoom = default; double priceRoom = default; int bedsRoom = default;
List <Rooms> roomsList = new List <Rooms>();

while (generalContinue)
{
    try
    {
        SwitchMenu(ref roomsList, ref generalContinue);
    }
    catch (FormatException)
    {
        Console.WriteLine("\nERROR!, Datos Inválidos");
        Console.ReadKey();
    }
}
static int ShowMenu()
{
    Console.Clear();
    Console.WriteLine("--- Hotel Ross ---");
    Console.WriteLine("1. Agregar Habitación");
    Console.WriteLine("2. Asignar Habitación");
    Console.WriteLine("3. Liberar Habitación");
    Console.WriteLine("4. Eliminar Habitación");
    Console.WriteLine("5. Mostrar Habitaciones");
    Console.WriteLine("6. Salir");
    Console.Write("Ingrese una Opción: ");
    int optionMenu = int.Parse(Console.ReadLine());
    return optionMenu;
}
static bool GoOut(ref bool generalContinue)
{
    Console.Clear();
    Console.WriteLine("Usted está Saliendo del Programa");
    generalContinue = false;
    return generalContinue;
}
 void SwitchMenu(ref List<Rooms> roomsList, ref bool generalContinue)
{
    switch (ShowMenu())
    {
        case 1:
            Rooms.AddRoom(roomsList, ref numberRoom, ref priceRoom, ref bedsRoom);
            break;
        case 2:
            Rooms.AssignRoom(roomsList);
            break;
        case 3:
            Rooms.FreeRoom(roomsList);
            break;
        case 4:
            Rooms.DeleteRoom(roomsList);
            break;
        case 5:
            Rooms.ShowAllRooms(roomsList);
            break;
        case 6:
            GoOut(ref generalContinue);
            break;
        default:
            Console.WriteLine("Ingrese una Opción Válida (1 - 6)");
            Console.ReadKey();
            break;
    }
}
