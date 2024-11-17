using Microsoft.AspNetCore.Mvc;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using Session02.Models;

namespace Session02.Controllers
{
    public class MisVentasController : Controller
    {

        public readonly IConfiguration _config;
        public MisVentasController(IConfiguration config)
        {
            _config = config;
        }

        IEnumerable<Ventas> listado()
        {
            List<Ventas> productos = new List<Ventas>();
            using (SqlConnection cn = new SqlConnection(_config["ConnectionStrings:cn"]))
            {
                SqlCommand cmd = new SqlCommand("select*from Ventas", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    productos.Add(new Ventas()
                    {
                        id = dr.GetInt32(0),
                        descripcion = dr.GetString(1),
                        cantidad = dr.GetInt32(2),
                        precio_unitario = dr.GetDecimal(3),
                    });

                }
            }
            return productos;
        }

        public async Task<IActionResult> Index()
        {
            return View(await Task.Run(() => listado()));
        }
    }
}
