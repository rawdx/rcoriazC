using Microsoft.AspNetCore.Mvc;
using rcoriaz.DAL;
using rcoriaz.Models;
using rcoriaz.Services;
using System.Diagnostics;

namespace rcoriaz.Controllers
{
    public class HomeController : Controller
    {
        private readonly ExaDosContext contexto;
        public HomeController(ExaDosContext contexto)
        {
            try
            {
                this.contexto = contexto;

                IMenu menu = new Menu();
                IGestorStock gestor = new GestorStock();

                List<VajillaDto> vajillas = new List<VajillaDto>();
                List<ReservaDto> reservas = new List<ReservaDto>();

                int opcion;
                do
                {
                    opcion = menu.MostrarMenu();

                    switch (opcion)
                    {
                        case 1:
                            gestor.AltaVajilla(vajillas, contexto);
                            break;
                        case 2:
                            gestor.MostrarStock(vajillas, contexto);
                            break;
                        case 3:
                            gestor.CrearReserva(reservas, vajillas, contexto);
                            break;
                    }
                } while (opcion != 3);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error: " + e.Message);
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}