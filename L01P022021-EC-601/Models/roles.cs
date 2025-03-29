using System.ComponentModel.DataAnnotations;
namespace L01P022021_EC_601.Models
{
    public class roles
    {
        [Key]
        public int RolId { get; set; }
        public string RolNombre { get; set; } = string.Empty;
    }
}

