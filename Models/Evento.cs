using System.ComponentModel.DataAnnotations.Schema;

namespace MvcEventosExamen2.Models
{
    public class Evento
    {
        public int Idevento { get; set; }
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public int IdCategoria { get; set; }
        public string Imagen { get; set; }
    }
}
