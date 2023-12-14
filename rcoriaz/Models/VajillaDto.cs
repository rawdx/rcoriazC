namespace rcoriaz.Models
{
    public class VajillaDto
    {
        long idVajilla;
        string? codigo;
        string? nombre;
        string? descripcion;
        int? cantidad;

        public long IdVajilla { get => idVajilla; set => idVajilla = value; }
        public string? Codigo { get => codigo; set => codigo = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Descripcion { get => descripcion; set => descripcion = value; }
        public int? Cantidad { get => cantidad; set => cantidad = value; }

        override
        public string ToString()
        {
            return "[id=" + idVajilla + ", codigo=" + codigo + ", nombre=" + nombre + ", descripcion=" + descripcion
                + ", cantidad=" + cantidad + "]";
        }
    }
}
