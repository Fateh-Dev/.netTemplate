using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Template.Migrations
{
    public partial class addNoteIdPersonne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "IdPersonne",
                table: "Notations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("4ba26e97-8dae-4d31-9995-4418b5f4952c"), 30, new DateTime(2023, 5, 12, 19, 23, 5, 97, DateTimeKind.Utc).AddTicks(5979), false, "Djehinet", "Fateh" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("69428ad2-56c3-48e2-ab32-8f2282145038"), 1, new DateTime(2023, 5, 12, 19, 23, 5, 97, DateTimeKind.Utc).AddTicks(5965), false, "Djehinet", "Djawed" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("df418748-01fa-4849-93e8-20d213dee1df"), 32, new DateTime(2023, 5, 12, 19, 23, 5, 97, DateTimeKind.Utc).AddTicks(5974), false, "Djehinet", "Nadjib" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("4ba26e97-8dae-4d31-9995-4418b5f4952c"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("69428ad2-56c3-48e2-ab32-8f2282145038"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("df418748-01fa-4849-93e8-20d213dee1df"));

            migrationBuilder.DropColumn(
                name: "IdPersonne",
                table: "Notations");

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
    }
}
