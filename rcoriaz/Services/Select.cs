using rcoriaz.DAL;

namespace rcoriaz.Services
{
    public class Select
    {
        public List<Vajilla> SelectVajillas(ExaDosContext contexto)
        {
            return contexto.Vajillas.ToList();
        }
    }
}
