namespace ParkingAPI.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int MakeId { get; set; }
        public Make Make { get; set; } = null!;
    }
}
