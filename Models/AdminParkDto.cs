using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class AdminParkDto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please entere the Park Name.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter a description of the Park.")]
        public string? Description { get; set; }
        [Range(1, 100, ErrorMessage = "Please choose an amount between $1.00 and $100")]
        [Required(ErrorMessage = "Please enter the Fee for the Park. ex. $20.00")]
        public double FeePrice { get; set; }
        [Required(ErrorMessage = "Please pick the State that is home ot a majority of the Park.")]
        public string? State { get; set; }

    }
}
