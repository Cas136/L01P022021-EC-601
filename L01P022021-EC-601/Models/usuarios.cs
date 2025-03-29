using System.ComponentModel.DataAnnotations;
namespace L01P022021_EC_601.Models
{
    public class usuarios
    {
        [Key]
        public int usuarioId { get; set; }
        public int rolId { get; set; }
        public string nombreUsuario { get; set; } = string.Empty;
        public string clave { get; set; } = string.Empty;
        public string nombre { get; set; } = string.Empty;
        public string apellido { get; set; } = string.Empty;

       
    }
}
