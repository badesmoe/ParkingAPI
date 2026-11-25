namespace ParkingAPI.Models
{
    public class Variant
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public Model Model { get; set; } = null!;
        public int ModelId { get; set; }
    }
}
