using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepartmentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class DeptModelUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentCode",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "DepartmentDescription",
                table: "Departments",
                newName: "Description");

            migrationBuilder.AddColumn<DateOnly>(
                name: "EstablishedDate",
                table: "Departments",
                type: "date",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstablishedDate",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Departments",
                newName: "DepartmentDescription");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentCode",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
