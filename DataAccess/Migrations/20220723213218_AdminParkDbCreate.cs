using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AdminParkDbCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminParks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeePrice = table.Column<double>(type: "float", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasSeasonalClosures = table.Column<bool>(type: "bit", nullable: false),
                    HasCamping = table.Column<bool>(type: "bit", nullable: false),
                    ParkReservationNeeded = table.Column<bool>(type: "bit", nullable: false),
                    CampingReservationNeeded = table.Column<bool>(type: "bit", nullable: false),
                    CampingFee = table.Column<bool>(type: "bit", nullable: false),
                    IsDesert = table.Column<bool>(type: "bit", nullable: false),
                    IsHot = table.Column<bool>(type: "bit", nullable: false),
                    IsCold = table.Column<bool>(type: "bit", nullable: false),
                    HasAvalanchDanger = table.Column<bool>(type: "bit", nullable: false),
                    HasWinterSports = table.Column<bool>(type: "bit", nullable: false),
                    HasBCSkiing = table.Column<bool>(type: "bit", nullable: false),
                    HasIceFishing = table.Column<bool>(type: "bit", nullable: false),
                    HasWaterAccess = table.Column<bool>(type: "bit", nullable: false),
                    HasBoating = table.Column<bool>(type: "bit", nullable: false),
                    HasFishing = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminParks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminParks");
        }
    }
}
