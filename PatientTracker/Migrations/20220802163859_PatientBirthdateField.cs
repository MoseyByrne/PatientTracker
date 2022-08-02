using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientTracker.Migrations
{
    public partial class PatientBirthdateField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Birthdate",
                table: "Patients",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthdate",
                table: "Patients");
        }
    }
}
