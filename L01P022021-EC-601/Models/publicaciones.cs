using System.ComponentModel.DataAnnotations;
namespace L01P022021_EC_601.Models
{
    public class publicaciones
    {
        [Key]
        public int publicacionId { get; set; }
        public string titulo { get; set; } = string.Empty;
        public string descripcion { get; set; } = string.Empty;
        public int usuarioId { get; set; }

    
    }
}
