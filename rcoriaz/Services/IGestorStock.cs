using rcoriaz.DAL;
using rcoriaz.Models;

namespace rcoriaz.Services
{
    public interface IGestorStock
    {
        void AltaVajilla(List<VajillaDto> vajillas, ExaDosContext contexto);
        void MostrarStock(List<VajillaDto> vajillas, ExaDosContext contexto);
        void CrearReserva(List<ReservaDto> reservas, List<VajillaDto> vajillas, ExaDosContext contexto);
    }
}
