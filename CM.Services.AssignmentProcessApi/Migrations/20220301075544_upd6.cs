using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CM.Services.AssignmentProcessApi.Migrations
{
    public partial class upd6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentProcessId",
                keyValue: new Guid("5965fa55-95b3-4047-8a8e-0cf22adf5daa"));

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentProcessId", "Action", "Brocker", "Consultant", "Customer", "Description", "ImageUrl", "Length", "StartDate", "Status", "Title" },
                values: new object[] { new Guid("26d19920-4e7d-4684-a8c2-8ce63d22cd15"), "", "Nikita", "NV", "Volvo", "DEscription come here", "https://dotnetmastery.blob.core.windows.net/mango/14.jpg", 0, new DateTime(2022, 6, 1, 8, 55, 44, 127, DateTimeKind.Local).AddTicks(4125), "Submitted", "BackEnd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentProcessId",
                keyValue: new Guid("26d19920-4e7d-4684-a8c2-8ce63d22cd15"));

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentProcessId", "Action", "Brocker", "Consultant", "Customer", "Description", "ImageUrl", "Length", "StartDate", "Status", "Title" },
                values: new object[] { new Guid("5965fa55-95b3-4047-8a8e-0cf22adf5daa"), "", "Nikita", "NV", "Volvo", "DEscription come here", "https://dotnetmastery.blob.core.windows.net/mango/14.jpg", 0, new DateTime(2022, 6, 1, 8, 49, 26, 901, DateTimeKind.Local).AddTicks(142), "Submitted", "BackEnd" });
        }
    }
}
