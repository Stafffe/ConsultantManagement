using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CM.Services.AssignmentProcessApi.Migrations
{
    public partial class upd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentProcessId",
                keyValue: new Guid("7efe74c1-42c0-489d-970f-78c8abb0d002"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Assignments",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentProcessId", "Action", "Brocker", "Consultant", "Customer", "Description", "ImageUrl", "Length", "StartDate", "Status", "Title" },
                values: new object[] { new Guid("281e4b37-fba0-44a4-a99f-f932d78aaa9f"), "", "Nikita", "NV", "Volvo", "DEscription come here", "https://dotnetmastery.blob.core.windows.net/mango/14.jpg", 0, new DateTime(2022, 5, 28, 15, 11, 17, 379, DateTimeKind.Local).AddTicks(1839), "Submitted", "BackEnd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentProcessId",
                keyValue: new Guid("281e4b37-fba0-44a4-a99f-f932d78aaa9f"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Assignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentProcessId", "Action", "Brocker", "Consultant", "Customer", "Description", "ImageUrl", "Length", "StartDate", "Status", "Title" },
                values: new object[] { new Guid("7efe74c1-42c0-489d-970f-78c8abb0d002"), "", "Nikita", "NV", "Volvo", "DEscription come here", "https://dotnetmastery.blob.core.windows.net/mango/14.jpg", 0, new DateTime(2022, 5, 28, 14, 18, 11, 615, DateTimeKind.Local).AddTicks(5710), "Submitted", "BackEnd" });
        }
    }
}
