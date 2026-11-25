namespace ParkingAPI.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; } = string.Empty;
        public Variant Variant { get; set; } = null!;
        public int VariantId { get; set; }
        public Color Color { get; set; } = null!;
        public int ColorId { get; set; }
        public ChassisType ChassisType { get; set; } = null!;
        public int ChassisTypeId { get; set; }

        public Car() { }
        public Car(int id, string licensePlate, Variant variant, Color color, ChassisType chassisType)
        {
            Id = id;
            LicensePlate = licensePlate;
            Variant = variant;
            Color = color;
            ChassisType = chassisType;
        }
    }
}
