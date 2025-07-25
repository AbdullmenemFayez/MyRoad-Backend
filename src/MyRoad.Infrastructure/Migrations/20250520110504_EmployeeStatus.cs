﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyRoad.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Employee",
                newName: "IsActive");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Employee",
                newName: "Status");
        }
    }
}
