using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Session02_b.Models;
using System.ComponentModel.DataAnnotations;

namespace Session02_b.Models
{
    public class Ventas
    {
        public int id { get; set; }
        public string? descripcion { get; set; }
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }
    }
}
