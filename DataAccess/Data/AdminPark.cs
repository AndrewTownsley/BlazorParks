using System.ComponentModel.DataAnnotations;

namespace DataAccess.Data
{
    public class AdminPark
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public double FeePrice { get; set; }
        public string? State { get; set; }
        //public List<string> Activities { get; set; }
        /*   public string[] Activities { get; set; } = { "Camping", "Hiking", "WildLife Viewing", "Water Access", "Winter Sports", "Fishing", "Boating", "Skiing" };*/
        public bool HasSeasonalClosures { get; set; }
        public bool HasCamping { get; set; }
        public bool ParkReservationNeeded { get; set; }
        public bool CampingReservationNeeded { get; set; }
        public bool CampingFee { get; set; }
        public bool IsDesert { get; set; }
        public bool IsHot { get; set; }
        public bool IsCold { get; set; }
        public bool HasAvalanchDanger { get; set; }
        public bool HasWinterSports { get; set; }
        public bool HasBCSkiing { get; set; }
        public bool HasIceFishing { get; set; }
        public bool HasWaterAccess { get; set; }
        public bool HasBoating { get; set; }
        public bool HasFishing { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
