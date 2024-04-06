using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgrammingLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProgrammingLanguages",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "Name", "UpdatedTime", "Version" },
                values: new object[] { 1, new DateTime(2024, 3, 31, 3, 4, 13, 856, DateTimeKind.Local).AddTicks(6899), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7.0" });

            migrationBuilder.InsertData(
                table: "ProgrammingLanguages",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "Name", "UpdatedTime", "Version" },
                values: new object[] { 2, new DateTime(2024, 3, 31, 3, 4, 13, 856, DateTimeKind.Local).AddTicks(6915), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruby", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4.0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgrammingLanguages");
        }
    }
}
