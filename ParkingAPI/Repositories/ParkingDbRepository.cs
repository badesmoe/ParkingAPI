using Microsoft.EntityFrameworkCore;
using ParkingAPI.Data;
using ParkingAPI.Models;

namespace ParkingAPI.Repositories
{
    public class ParkingDbRepository
    {
        private readonly ParkingDbContext _context;
        public ParkingDbRepository(ParkingDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Parking> GetAllParkings()
        {
            var parkings = _context.Parkings.ToList();
            _context.SaveChanges();
            return parkings;
        }
        public Parking Add(Parking parking)
        {
            _context.Parkings.Add(parking);
            _context.SaveChanges();
            return parking;
        }
        public Parking? UpdateExitTime(int id)
        {
            var parking = _context.Parkings.FirstOrDefault(p => p.Id == id);
            if (parking != null)
            {
                parking.ExitTime = DateTime.Now;
                _context.SaveChanges();
            }
            return parking;
        }
    }
}
