
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CRUD_TDescuento.Models
{
    public class DescuentoDBContext : DbContext
    {
        public DescuentoDBContext(DbContextOptions<DescuentoDBContext> options) : base(options)
        { 

        }
        public DbSet<Descuento> Tdescuento { get; set; } = null;
    }
     
}
