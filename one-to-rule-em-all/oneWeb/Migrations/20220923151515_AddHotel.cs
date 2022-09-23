using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace oneWeb.Migrations {
  public partial class AddHotel : Migration {
    protected override void Up (MigrationBuilder migrationBuilder) {
      migrationBuilder.CreateTable(
        name: "Hotels",
        columns: table => new {
          Id = table.Column<int>(type: "int", nullable: false)
                .Annotation("SqlServer:Identity", "1, 1"),
          HotelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
          Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
          City = table.Column<string>(type: "nvarchar(max)", nullable: false),
          Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
        },
        constraints: table => {
          table.PrimaryKey("PK_Hotels", x => x.Id);
        });
    }

    protected override void Down (MigrationBuilder migrationBuilder) {
      migrationBuilder.DropTable(name: "Hotels");
    }
  }
}
