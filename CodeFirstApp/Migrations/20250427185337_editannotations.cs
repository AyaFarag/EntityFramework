using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstApp.Migrations
{
    /// <inheritdoc />
    public partial class editannotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_addresses_students_Student_id",
                table: "addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_addresses",
                table: "addresses");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "addresses");

            migrationBuilder.RenameTable(
                name: "addresses",
                newName: "ContentAdress");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "ContentAdress",
                newName: "ADContent");

            migrationBuilder.RenameIndex(
                name: "IX_addresses_Student_id",
                table: "ContentAdress",
                newName: "IX_ContentAdress_Student_id");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_at",
                table: "users",
                type: "datetime2",
                rowVersion: true,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_at",
                table: "users",
                type: "datetime2",
                rowVersion: true,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "categories",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContentAdress",
                table: "ContentAdress",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContentAdress_students_Student_id",
                table: "ContentAdress",
                column: "Student_id",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContentAdress_students_Student_id",
                table: "ContentAdress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContentAdress",
                table: "ContentAdress");

            migrationBuilder.DropColumn(
                name: "Created_at",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Updated_at",
                table: "users");

            migrationBuilder.RenameTable(
                name: "ContentAdress",
                newName: "addresses");

            migrationBuilder.RenameColumn(
                name: "ADContent",
                table: "addresses",
                newName: "Content");

            migrationBuilder.RenameIndex(
                name: "IX_ContentAdress_Student_id",
                table: "addresses",
                newName: "IX_addresses_Student_id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_addresses",
                table: "addresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_addresses_students_Student_id",
                table: "addresses",
                column: "Student_id",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
