using System.Data;
using Microsoft.EntityFrameworkCore;
namespace L01P022021_EC_601.Models
{
    public class blog_DbContext : DbContext
    {
        public blog_DbContext(DbContextOptions options) : base(options)
        {
    }
        public DbSet<roles> roles { get; set; }
        public DbSet<usuarios> usuarios { get; set; }
        public DbSet<publicaciones> publicaciones { get; set; }
        public DbSet<comentarios> comentarios { get; set; }
        public DbSet<calificaciones> calificaciones { get; set; }
    }
    
}
