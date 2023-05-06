using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Template.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personnes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    CreationTimeUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("4a357fc2-96d6-4470-92bf-848f0b60fe8b"), 1, new DateTime(2023, 5, 6, 13, 50, 57, 743, DateTimeKind.Utc).AddTicks(3332), false, "Djehinet", "Djawed" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("aada0131-9a3d-48b9-b8a8-e129fe68d712"), 30, new DateTime(2023, 5, 6, 13, 50, 57, 743, DateTimeKind.Utc).AddTicks(3351), false, "Djehinet", "Fateh" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("d6e97553-5130-4a49-9b41-35eefc4f70ea"), 32, new DateTime(2023, 5, 6, 13, 50, 57, 743, DateTimeKind.Utc).AddTicks(3344), false, "Djehinet", "Nadjib" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personnes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
