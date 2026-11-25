namespace ParkingAPI.Models
{
    public class Parking
    {
        public int Id { get; set; }
        public DateTime? EntryTime { get; set; }
        public DateTime? ExitTime { get; set; }
        public Car Car { get; set; }
        public ParkedStatus Status { get; set; } = ParkedStatus.NotActive;

        public Parking() { }

        public Parking(DateTime? entryTime, DateTime? exitTime, Car car, ParkedStatus status)
        {
            EntryTime = entryTime;
            ExitTime = exitTime;
            Car = car;
            Status = status;
        }
    }
}
 