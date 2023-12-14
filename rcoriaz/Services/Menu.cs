namespace rcoriaz.Services
{
    public class Menu:IMenu
    {
        public int MostrarMenu()
        {
            Console.WriteLine("\nGestor de Vajillas");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. Crear vajilla");
            Console.WriteLine("2. Mostrar stock");
            Console.WriteLine("3. Crear Reserva");
            Console.WriteLine("4. Salir");
            Console.Write("\nIntroduce una opción: ");

            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
            {
                Console.Write("Introduce un número dentro del rango: ");
            }

            return opcion;
        }
    }
}
