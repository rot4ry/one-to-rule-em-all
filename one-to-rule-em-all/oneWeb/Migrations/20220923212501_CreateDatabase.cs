using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace oneWeb.Migrations {
  public partial class CreateDatabase: Migration {
    protected override void Up (MigrationBuilder migrationBuilder) {
      migrationBuilder.CreateTable(
        name: "Bookings",
        columns: table => new {
          Id = table.Column<int>(type: "int", nullable: false)
                .Annotation("SqlServer:Identity", "1, 1"),
          UserId = table.Column<int>(type: "int", nullable: false),
          HotelId = table.Column<int>(type: "int", nullable: false),
          DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
          DateEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
        },
        constraints: table => {
          table.PrimaryKey("PK_Bookings", x => x.Id);
        });

      migrationBuilder.CreateTable(
        name: "Hotels",
        columns: table => new {
          Id = table.Column<int>(type: "int", nullable: false)
                .Annotation("SqlServer:Identity", "1, 1"),
          Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
          Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
          City = table.Column<string>(type: "nvarchar(max)", nullable: false),
          Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
        },
        constraints: table => {
          table.PrimaryKey("PK_Hotels", x => x.Id);
        });

      migrationBuilder.CreateTable(
        name: "Photos",
        columns: table => new {
          Id = table.Column<int>(type: "int", nullable: false)
                .Annotation("SqlServer:Identity", "1, 1"),
          HotelId = table.Column<int>(type: "int", nullable: false),
          PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
        },
        constraints: table => {
          table.PrimaryKey("PK_Photos", x => x.Id);
        });

      migrationBuilder.CreateTable(
        name: "Users",
        columns: table => new {
          Id = table.Column<int>(type: "int", nullable: false)
                .Annotation("SqlServer:Identity", "1, 1"),
          Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
          Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
          Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
          Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
          isAdmin = table.Column<bool>(type: "bit", nullable: false)
        },
        constraints: table => {
          table.PrimaryKey("PK_Users", x => x.Id);
        });
    }

    protected override void Down (MigrationBuilder migrationBuilder) {
      migrationBuilder.DropTable(name: "Bookings");
      migrationBuilder.DropTable(name: "Hotels");
      migrationBuilder.DropTable(name: "Photos");
      migrationBuilder.DropTable(name: "Users");
    }
  }
}
