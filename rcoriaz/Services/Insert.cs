using rcoriaz.DAL;

namespace rcoriaz.Services
{
    public class Insert
    {
        public void InsertarVajilla(Vajilla vajilla, ExaDosContext contexto)
        {
            contexto.Vajillas.Add(vajilla);
            contexto.SaveChanges();
        }
    }
}
