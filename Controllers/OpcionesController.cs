using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OpcionesController : Controller
    {
        public IActionResult Main(string opcion = null)
        {
            var model = new OpcionModel();
            
            // Lista de opciones disponibles
            var opciones = new Dictionary<string, string>
            {
                { "concepto", "Concepto de Lista" },
                { "enlazada", "Lista Enlazada" },
                { "doble", "Lista Enlazada Doble" },
                { "circular", "Lista Enlazada Circular" }
            };

            // Configuración del modelo basado en la opción seleccionada
            if (opcion != null && opciones.ContainsKey(opcion))
            {
                model.TituloSeleccionado = opciones[opcion];
                model.Descripcion = $"Aquí puedes agregar el contenido relacionado con {opciones[opcion]}.";
            }
            else
            {
                model.TituloSeleccionado = "Selecciona una opción";
                model.Descripcion = "Selecciona una opción de la lista para ver más detalles.";
            }

            model.Opciones = opciones; // Pasar las opciones a la vista

            return View(model); // Devuelve la vista con el modelo
        }
    }
}

