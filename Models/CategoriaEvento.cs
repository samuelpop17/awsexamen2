using System.ComponentModel.DataAnnotations.Schema;

namespace MvcEventosExamen2.Models
{
    public class CategoriaEvento
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
    }
}
