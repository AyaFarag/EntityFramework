using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstApp.Migrations
{
    /// <inheritdoc />
    public partial class editstudententity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_grades_Grade_id",
                table: "students");

            migrationBuilder.AlterColumn<int>(
                name: "Grade_id",
                table: "students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    StudentsId = table.Column<int>(type: "int", nullable: false),
                    coursesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.StudentsId, x.coursesId });
                    table.ForeignKey(
                        name: "FK_CourseStudent_courses_coursesId",
                        column: x => x.coursesId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_coursesId",
                table: "CourseStudent",
                column: "coursesId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_grades_Grade_id",
                table: "students",
                column: "Grade_id",
                principalTable: "grades",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_grades_Grade_id",
                table: "students");

            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.AlterColumn<int>(
                name: "Grade_id",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_students_grades_Grade_id",
                table: "students",
                column: "Grade_id",
                principalTable: "grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
