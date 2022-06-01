using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityManager.Migrations
{
    public partial class student_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeacherName",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Student",
                newName: "StudentId");

            migrationBuilder.AlterColumn<string>(
                name: "Shift",
                table: "Department",
                type: "nvarchar(12)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Department",
                type: "nvarchar(12)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Student",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Shift",
                table: "Department",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Department",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeacherName",
                table: "Department",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
