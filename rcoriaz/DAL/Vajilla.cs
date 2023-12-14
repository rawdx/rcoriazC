using System;
using System.Collections.Generic;

namespace rcoriaz.DAL;

public partial class Vajilla
{
    public int IdVajilla { get; set; }

    public int? Cantidad { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string? Nombre { get; set; }

    public Vajilla()
    {
    }

    public Vajilla(int? cantidad, string? codigo, string? descripcion, string? nombre)
    {
        Cantidad = cantidad;
        Codigo = codigo;
        Descripcion = descripcion;
        Nombre = nombre;
    }
}
