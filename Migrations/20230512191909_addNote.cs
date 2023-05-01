using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Template.Migrations
{
    public partial class addNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("1fc7f1da-7968-406a-9108-c8d0af034bdc"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("46e51fbf-8b66-45f7-ab5d-5042934085d4"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("cd9023e2-488e-4958-bd08-c090d4233339"));

            migrationBuilder.CreateTable(
                name: "Notations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DesciplineCode = table.Column<int>(type: "int", nullable: false),
                    Descipline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<double>(type: "float", nullable: false),
                    IsTest = table.Column<bool>(type: "bit", nullable: false),
                    IsRevision = table.Column<bool>(type: "bit", nullable: false),
                    Coefficient = table.Column<double>(type: "float", nullable: false),
                    PhaseFormationCode = table.Column<int>(type: "int", nullable: false),
                    PhaseFormationDisplay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("11780f8a-a503-419d-952f-63ee2c0f4a3e"), 30, new DateTime(2023, 5, 12, 19, 19, 9, 283, DateTimeKind.Utc).AddTicks(4777), false, "Djehinet", "Fateh" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("ace63e00-8520-4346-bfa4-88c14ce7ef1e"), 32, new DateTime(2023, 5, 12, 19, 19, 9, 283, DateTimeKind.Utc).AddTicks(4771), false, "Djehinet", "Nadjib" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("b2e852ed-c192-47b2-a464-a0ad23ad31ae"), 1, new DateTime(2023, 5, 12, 19, 19, 9, 283, DateTimeKind.Utc).AddTicks(4756), false, "Djehinet", "Djawed" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notations");

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("11780f8a-a503-419d-952f-63ee2c0f4a3e"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("ace63e00-8520-4346-bfa4-88c14ce7ef1e"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("b2e852ed-c192-47b2-a464-a0ad23ad31ae"));

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("1fc7f1da-7968-406a-9108-c8d0af034bdc"), 1, new DateTime(2023, 5, 9, 18, 43, 17, 422, DateTimeKind.Utc).AddTicks(4655), false, "Djehinet", "Djawed" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("46e51fbf-8b66-45f7-ab5d-5042934085d4"), 30, new DateTime(2023, 5, 9, 18, 43, 17, 422, DateTimeKind.Utc).AddTicks(4689), false, "Djehinet", "Fateh" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("cd9023e2-488e-4958-bd08-c090d4233339"), 32, new DateTime(2023, 5, 9, 18, 43, 17, 422, DateTimeKind.Utc).AddTicks(4683), false, "Djehinet", "Nadjib" });
        }
    }
}
