﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstApp.Migrations
{
    /// <inheritdoc />
    public partial class addAgeProptouser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "users");
        }
    }
}
