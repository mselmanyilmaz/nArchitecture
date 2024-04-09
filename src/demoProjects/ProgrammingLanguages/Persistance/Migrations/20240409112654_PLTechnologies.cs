using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    public partial class PLTechnologies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PLTechnologies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgrammingLanguageId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLTechnologies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PLTechnologies_ProgrammingLanguages_ProgrammingLanguageId",
                        column: x => x.ProgrammingLanguageId,
                        principalTable: "ProgrammingLanguages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PLTechnologies",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "Name", "ProgrammingLanguageId", "ReleaseTime", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 9, 14, 26, 54, 571, DateTimeKind.Local).AddTicks(8822), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deneme C", 1, new DateTime(1978, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 4, 9, 14, 26, 54, 571, DateTimeKind.Local).AddTicks(8829), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deneme Jaava", 4, new DateTime(1998, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 4, 9, 14, 26, 54, 571, DateTimeKind.Local).AddTicks(8834), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deneme C++", 5, new DateTime(2002, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 9, 14, 26, 54, 571, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 9, 14, 26, 54, 571, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.CreateIndex(
                name: "IX_PLTechnologies_ProgrammingLanguageId",
                table: "PLTechnologies",
                column: "ProgrammingLanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PLTechnologies");

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 3, 31, 3, 4, 13, 856, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "ProgrammingLanguages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 3, 31, 3, 4, 13, 856, DateTimeKind.Local).AddTicks(6915));
        }
    }
}
