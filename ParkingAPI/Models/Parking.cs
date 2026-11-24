namespace ParkingAPI.Models
{
    public class Parking
    {
        public int Id { get; set; }
        public DateTime? EntryTime { get; set; }
        public DateTime? ExitTime { get; set; }
        public Car Car { get; set; }
        public ParkedStatus Status { get; set; } = ParkedStatus.NotActive;
    }
}
