using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Session02.Controllers;
using System.ComponentModel.DataAnnotations;

namespace Session02.Models
{
    public class Ventas
    {
        
        public int id { get; set; }
        public string? descripcion { get; set; } //se cologo '?'  para poder haceptar objetos nulos = NULL
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }



    }
}
