using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using ExamenT1.Controllers;


namespace ExamenT1.Models
{
    public class Ventas
    {
        public int id { get; set; }
        public string? descripcion { get; set; }
        public int cantidad { get; set; }
        public decimal precio_unitario {  get; set; }
    }
}
