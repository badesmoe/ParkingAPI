using Microsoft.EntityFrameworkCore;
using ParkingAPI.Models;

namespace ParkingAPI.Data
{
    public class ParkingDbContext : DbContext
    {
        public ParkingDbContext(DbContextOptions<ParkingDbContext> options) : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Parking> Parkings { get; set; }
    }
}
