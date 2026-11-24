namespace ParkingAPI.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; } = String.Empty;
        public string Make { get; set; } = String.Empty;
        public string Model { get; set; } = String.Empty;
        public string Variant { get; set; } = String.Empty;
        public string Color { get; set; } = String.Empty;
        public string ChassisType { get; set; } = String.Empty;
    }
}
