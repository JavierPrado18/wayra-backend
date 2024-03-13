using Microsoft.EntityFrameworkCore;

namespace WebApiFestivities.Models
{

    public class FestividadesDBContext(DbContextOptions<FestividadesDBContext> options) : DbContext(options)
    {
        public DbSet<Festividad> Festividades { get; set; }
    }

}