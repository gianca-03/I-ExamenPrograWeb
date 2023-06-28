﻿namespace FrontEnd.Models
{
    public class ProveedorViewModel
    {
        public int CodProveedor { get; set; }
        public string NombreProveedor { get; set; } = null!;
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? CodigoArchivo { get; set; }
    }
}
