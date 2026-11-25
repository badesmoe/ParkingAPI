using ParkingAPI.Models;
using ParkingAPI.Data;

namespace ParkingAPI.Repositories
{
    public class CarDbRepository
    {
        private readonly ParkingDbContext _context;
        public CarDbRepository(ParkingDbContext context)
        {
            _context = context;
        }

        public Car Add(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
            return car;
        }

        public Car? Update(Car car)
        {
            var existingCar = _context.Cars.FirstOrDefault(c => c.Id == car.Id);
            if (existingCar != null)
            {
                existingCar.ColorId = car.ColorId;
                existingCar.ChassisTypeId = car.ChassisTypeId;
                existingCar.VariantId = car.VariantId;
                _context.SaveChanges();
            }
            return existingCar;
        }
    }
}
