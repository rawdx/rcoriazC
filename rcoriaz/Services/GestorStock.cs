using rcoriaz.DAL;
using rcoriaz.Models;
using rcoriaz.Utils;

namespace rcoriaz.Services
{
    public class GestorStock: IGestorStock
    {
        Conversion gestorConversion = new Conversion();
        Insert insertar = new Insert();
        Select obtener = new Select();

        public void AltaVajilla(List<VajillaDto> vajillas, ExaDosContext contexto)
        {
            Console.Write("Introduce el nombre de la vajilla: ");
            string nombre = Console.ReadLine();

            Console.Write("Introduce su descripción: ");
            string descripcion = Console.ReadLine();

            Console.Write("Introduce la cantidad: ");
            int cantidad;
            while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad < 0)
                Console.Write("Introduce una cantidad válida: ");

            string codigo = nombre + descripcion;

            //Inserta los datos en la BD
            insertar.InsertarVajilla(new Vajilla(cantidad, codigo, descripcion, nombre), contexto);
        }

        public void MostrarStock(List<VajillaDto> vajillas, ExaDosContext contexto)
        {
            //Obtiene todos los datos de la BD en dao, los convierte a dto y los añade a la lista de dto para el controller
            vajillas = gestorConversion.ConvertirDaoADto(obtener.SelectVajillas(contexto));

            Console.WriteLine("\nTodas las vajillas:");
            foreach (var vajilla in vajillas)
                Console.WriteLine(vajilla.ToString());
        }

        public void CrearReserva(List<ReservaDto> reservas, List<VajillaDto> vajillas, ExaDosContext contexto)
        {
            vajillas = gestorConversion.ConvertirDaoADto(obtener.SelectVajillas(contexto));

            Console.Write("Introduce el código de la vajilla a reservar: ");
            string codigo = Console.ReadLine();

            VajillaDto vajilla = vajillas.FirstOrDefault(a => a.Codigo == codigo);

            if(vajilla != null)
            {
                Console.WriteLine(vajilla.ToString());

                Console.Write("Introduce la cantidad que quieres reservar: ");
            }
            else
                Console.WriteLine("La vajilla no existe.");

        }
    }
}
