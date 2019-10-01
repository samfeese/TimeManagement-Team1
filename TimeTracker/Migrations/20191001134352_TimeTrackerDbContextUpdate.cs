using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeTracker.Migrations
{
    public partial class TimeTrackerDbContextUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "Profile",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Profile",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Profile");
        }
    }
}
