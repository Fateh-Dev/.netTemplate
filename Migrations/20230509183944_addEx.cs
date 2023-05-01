using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Template.Migrations
{
    public partial class addEx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("16dabfbb-8c50-4c29-9940-5bf9c47f1563"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("6b64bab0-5c4f-432b-9691-7231706082b9"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("f0207297-1509-4b8b-be24-b6c1707a299e"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("16dabfbb-8c50-4c29-9940-5bf9c47f1563"), 32, new DateTime(2023, 5, 6, 14, 5, 40, 862, DateTimeKind.Utc).AddTicks(2307), false, "Djehinet", "Nadjib" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("6b64bab0-5c4f-432b-9691-7231706082b9"), 1, new DateTime(2023, 5, 6, 14, 5, 40, 862, DateTimeKind.Utc).AddTicks(2293), false, "Djehinet", "Djawed" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("f0207297-1509-4b8b-be24-b6c1707a299e"), 30, new DateTime(2023, 5, 6, 14, 5, 40, 862, DateTimeKind.Utc).AddTicks(2313), false, "Djehinet", "Fateh" });
        }
    }
}
