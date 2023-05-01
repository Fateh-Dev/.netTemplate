using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Template.Migrations
{
    public partial class exter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("327f16f8-3b31-4e7b-819f-7b0e4673a877"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("328a284b-7857-436c-a743-7f1fa0b3a9e7"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("4eb7c6c5-18af-4984-bfc4-2c25e4741a47"));

            migrationBuilder.CreateTable(
                name: "ExternalEntities",
                columns: table => new
                {
                    ServerName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ServerUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Port = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalEntities", x => x.ServerName);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExternalEntities");

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

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("327f16f8-3b31-4e7b-819f-7b0e4673a877"), 30, new DateTime(2023, 5, 9, 18, 39, 43, 794, DateTimeKind.Utc).AddTicks(4035), false, "Djehinet", "Fateh" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("328a284b-7857-436c-a743-7f1fa0b3a9e7"), 32, new DateTime(2023, 5, 9, 18, 39, 43, 794, DateTimeKind.Utc).AddTicks(4030), false, "Djehinet", "Nadjib" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("4eb7c6c5-18af-4984-bfc4-2c25e4741a47"), 1, new DateTime(2023, 5, 9, 18, 39, 43, 794, DateTimeKind.Utc).AddTicks(4018), false, "Djehinet", "Djawed" });
        }
    }
}
