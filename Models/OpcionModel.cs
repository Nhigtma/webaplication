using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class OpcionModel
    {
        public string TituloSeleccionado { get; set; } = "Selecciona una opción";
        public string Descripcion { get; set; } = "Selecciona una opción de la lista para ver más detalles.";
        public Dictionary<string, string> Opciones { get; set; } = new Dictionary<string, string>
        {
            { "concepto", "Concepto de Lista" },
            { "enlazada", "Lista Enlazada" },
            { "doble", "Lista Enlazada Doble" },
            { "circular", "Lista Enlazada Circular" }
        };
    }
}
