using ParkingAPI.Repositories;
using ParkingAPI.Data;

namespace ParkingAPI.Services
{
    public class CarDbService
    {
        private readonly CarDbRepository _repo;
        public CarDbService(CarDbRepository carDbRepository)
        {
            _repo = carDbRepository;
        }
    }
}
