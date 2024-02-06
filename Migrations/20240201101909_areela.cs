using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class areela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "salary",
                table: "students",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "deptid",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_students_deptid",
                table: "students",
                column: "deptid");

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_deptid",
                table: "students",
                column: "deptid",
                principalTable: "departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_deptid",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_deptid",
                table: "students");

            migrationBuilder.DropColumn(
                name: "deptid",
                table: "students");

            migrationBuilder.AlterColumn<int>(
                name: "salary",
                table: "students",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
