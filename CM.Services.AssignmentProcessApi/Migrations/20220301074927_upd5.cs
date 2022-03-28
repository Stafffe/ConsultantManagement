using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CM.Services.AssignmentProcessApi.Migrations
{
    public partial class upd5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentProcessId",
                keyValue: new Guid("281e4b37-fba0-44a4-a99f-f932d78aaa9f"));

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentProcessId", "Action", "Brocker", "Consultant", "Customer", "Description", "ImageUrl", "Length", "StartDate", "Status", "Title" },
                values: new object[] { new Guid("5965fa55-95b3-4047-8a8e-0cf22adf5daa"), "", "Nikita", "NV", "Volvo", "DEscription come here", "https://dotnetmastery.blob.core.windows.net/mango/14.jpg", 0, new DateTime(2022, 6, 1, 8, 49, 26, 901, DateTimeKind.Local).AddTicks(142), "Submitted", "BackEnd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentProcessId",
                keyValue: new Guid("5965fa55-95b3-4047-8a8e-0cf22adf5daa"));

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentProcessId", "Action", "Brocker", "Consultant", "Customer", "Description", "ImageUrl", "Length", "StartDate", "Status", "Title" },
                values: new object[] { new Guid("281e4b37-fba0-44a4-a99f-f932d78aaa9f"), "", "Nikita", "NV", "Volvo", "DEscription come here", "https://dotnetmastery.blob.core.windows.net/mango/14.jpg", 0, new DateTime(2022, 5, 28, 15, 11, 17, 379, DateTimeKind.Local).AddTicks(1839), "Submitted", "BackEnd" });
        }
    }
}
