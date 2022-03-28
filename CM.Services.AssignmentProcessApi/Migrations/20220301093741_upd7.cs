using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CM.Services.AssignmentProcessApi.Migrations
{
    public partial class upd7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentProcessId",
                keyValue: new Guid("26d19920-4e7d-4684-a8c2-8ce63d22cd15"));

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Customer",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Consultant",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Brocker",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Action",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentProcessId", "Action", "Brocker", "Consultant", "Customer", "Description", "ImageUrl", "Length", "StartDate", "Status", "Title" },
                values: new object[] { new Guid("804ce16c-37fa-4401-a7b6-5ce00145d256"), "", "Nikita", "NV", "Volvo", "DEscription come here", "https://dotnetmastery.blob.core.windows.net/mango/14.jpg", 0, new DateTime(2022, 6, 1, 10, 37, 40, 903, DateTimeKind.Local).AddTicks(2563), "Submitted", "BackEnd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentProcessId",
                keyValue: new Guid("804ce16c-37fa-4401-a7b6-5ce00145d256"));

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Customer",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Consultant",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Brocker",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Action",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentProcessId", "Action", "Brocker", "Consultant", "Customer", "Description", "ImageUrl", "Length", "StartDate", "Status", "Title" },
                values: new object[] { new Guid("26d19920-4e7d-4684-a8c2-8ce63d22cd15"), "", "Nikita", "NV", "Volvo", "DEscription come here", "https://dotnetmastery.blob.core.windows.net/mango/14.jpg", 0, new DateTime(2022, 6, 1, 8, 55, 44, 127, DateTimeKind.Local).AddTicks(4125), "Submitted", "BackEnd" });
        }
    }
}
