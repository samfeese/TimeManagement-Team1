using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeTracker.Migrations
{
    public partial class Current : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Time",
                table: "Time");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CostCenter",
                table: "CostCenter");

            migrationBuilder.DropColumn(
                name: "TimePercentage",
                table: "CostCenter");

            migrationBuilder.DropColumn(
                name: "TotalTime",
                table: "CostCenter");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CostCenter");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Time",
                newName: "IdentityUserId");

            migrationBuilder.AlterColumn<int>(
                name: "TotalTime",
                table: "Time",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "TimeId",
                table: "Time",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "CostCenterId",
                table: "Time",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CostCenterId",
                table: "CostCenter",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CostCenter",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Time",
                table: "Time",
                column: "TimeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CostCenter",
                table: "CostCenter",
                column: "CostCenterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Time",
                table: "Time");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CostCenter",
                table: "CostCenter");

            migrationBuilder.DropColumn(
                name: "TimeId",
                table: "Time");

            migrationBuilder.DropColumn(
                name: "CostCenterId",
                table: "Time");

            migrationBuilder.DropColumn(
                name: "CostCenterId",
                table: "CostCenter");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CostCenter");

            migrationBuilder.RenameColumn(
                name: "IdentityUserId",
                table: "Time",
                newName: "UserId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TotalTime",
                table: "Time",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<double>(
                name: "TimePercentage",
                table: "CostCenter",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "TotalTime",
                table: "CostCenter",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "CostCenter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Time",
                table: "Time",
                column: "Start");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CostCenter",
                table: "CostCenter",
                column: "TimePercentage");

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    OwnerID = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.UserId);
                });
        }
    }
}
