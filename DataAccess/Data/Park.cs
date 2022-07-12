namespace DataAccess.Data
{
    public class Park
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Fee { get; set; }

        public double? FeePrice { get; set; }

        public string? Description { get; set; }

        public string? State { get; set; }

        // Dropdown w/ Options
        public string? Activities { get; set; }

        // Dropdown w/ Options
        public string? TerrainFeatures { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
