namespace WebApplication1.Models;
    public class OpcionModel
    {
        public string? TituloSeleccionado { get; set; }
        public string? Descripcion { get; set; }
        public Dictionary<string, string>? Opciones { get; set; } // Lista de opciones
    }
