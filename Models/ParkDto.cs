using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ParkDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Is there a fee to enter the park?")]
        public bool Fee { get; set; }

        public string Description { get; set; }
        // Dropdown w/ options
        [Required(ErrorMessage = "Please select a State")]
        public string State { get; set; }
        public virtual ICollection<ParkImageDto> ParkImages { get; set; }

        public List<string> ImageUrls;


    }
}
