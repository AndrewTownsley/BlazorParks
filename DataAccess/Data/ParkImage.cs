using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Data
{
    public class ParkImage
    {
        public int Id { get; set; }

        public int ParkId { get; set; }

        public string ParkImageUrl { get; set; }

        [ForeignKey("RoomId")]
        public virtual Park Park { get; set; }
    }
}
