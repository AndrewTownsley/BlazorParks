using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ParkImageDto
    {
        public int Id { get; set; }
        [Required]
        public int ParkId { get; set; }
        [Required]
        public string? ParkImageUrl { get; set; }
    }
}
