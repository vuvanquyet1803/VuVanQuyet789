using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VuVanQuyet789.Migrations
{
    public partial class VVQ0789Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VVQ0789",
                columns: table => new
                {
                    VVQId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    VVQName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    VVQGender = table.Column<bool>(type: "INTEGER", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VVQ0789", x => x.VVQId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VVQ0789");
        }
    }
}
