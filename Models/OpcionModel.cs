using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class OpcionModel
    {
        public string TituloSeleccionado { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        public List<int> NumerosAleatorios { get; set; }
        public string TipoLista { get; set; }  // Nueva propiedad
    }
}