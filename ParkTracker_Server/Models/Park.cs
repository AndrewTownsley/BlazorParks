namespace ParkTracker_Server.Models
{
    public class Park
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string State { get; set; }

        public string Description { get; set; }

        public string Activities { get; set; }

        public bool Fee { get; set; }
    }
}
