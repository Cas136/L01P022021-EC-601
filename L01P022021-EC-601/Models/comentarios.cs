using System.ComponentModel.DataAnnotations;
namespace L01P022021_EC_601.Models
{
    public class comentarios
    {
        [Key]
        public int cometarioId { get; set; }
        public int publicacionId { get; set; }
        public string comentario { get; set; } = string.Empty;
        public int usuarioId { get; set; }
    }
}
