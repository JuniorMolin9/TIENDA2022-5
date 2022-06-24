using Microsoft.EntityFrameworkCore;
using Tienda.Models;


namespace Tienda.Datos
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>  option):base(option)
        {

        }

        public DbSet<Categoria> Categoria { get; set; }
    }
}
