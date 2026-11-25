using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ParkingAPI.Data;
using ParkingAPI.Models;
using ParkingAPI.Repositories;

namespace ParkingTests
{
    [TestClass]
    public sealed class ParkingTests
    {
        private ParkingDbContext _context;

        [TestInitialize]
        public void Initialize()
        {
            var options = new DbContextOptionsBuilder<ParkingDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            _context = new ParkingDbContext(options);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _context.Dispose();
        }

        [TestMethod]
        public void AddParking_ShouldAddParkingToDatabase_ReturnObject()
        {
            // Arrange
            var parking = new Parking
            {
                EntryTime = DateTime.Now,
                ExitTime = null,
                Car = new Car
                {
                    LicensePlate = "ABC123",
                    ColorId = 1,
                    ChassisTypeId = 1,
                    VariantId = 1
                },
            };

            // Act
            var repository = new ParkingDbRepository(_context);
            var result = repository.Add(parking);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(parking.Id, result.Id);
        }

        [TestMethod]
        public void UpdateExitTime_ShouldUpdateExitTimeInDatabase_ReturnObject()
        {
            // Arrange
            var parking = new Parking
            {
                EntryTime = DateTime.Now,
                ExitTime = null,
                Car = new Car
                {
                    LicensePlate = "ABC123",
                    ColorId = 1,
                    ChassisTypeId = 1,
                    VariantId = 1
                },
            };
            var repository = new ParkingDbRepository(_context);
            repository.Add(parking);
            // Act
            repository.UpdateExitTime(parking.Id);

            // Assert
            var updatedParking = _context.Parkings.Find(parking.Id);
            Assert.IsNotNull(updatedParking.ExitTime);
        }

        [TestMethod]
        public void 

    }
}