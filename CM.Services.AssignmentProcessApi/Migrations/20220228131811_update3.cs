using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CM.Services.AssignmentProcessApi.Migrations
{
    public partial class update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    AssignmentProcessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Customer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brocker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Consultant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.AssignmentProcessId);
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentProcessId", "Action", "Brocker", "Consultant", "Customer", "Description", "ImageUrl", "Length", "StartDate", "Status", "Title" },
                values: new object[] { new Guid("7efe74c1-42c0-489d-970f-78c8abb0d002"), "", "Nikita", "NV", "Volvo", "DEscription come here", "https://dotnetmastery.blob.core.windows.net/mango/14.jpg", 0, new DateTime(2022, 5, 28, 14, 18, 11, 615, DateTimeKind.Local).AddTicks(5710), "Submitted", "BackEnd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");
        }
    }
}
