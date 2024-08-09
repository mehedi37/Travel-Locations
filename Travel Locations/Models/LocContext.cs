using Microsoft.EntityFrameworkCore;

namespace Travel_Locations.Models
{
    public class LocContext(DbContextOptions<LocContext> options) : DbContext(options)
    {
        public DbSet<Locations> Locations { get; set; }
    }
}
