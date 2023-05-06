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
                values: new object[,]
                {
                    { new Guid("16dabfbb-8c50-4c29-9940-5bf9c47f1563"), 32, new DateTime(2023, 5, 6, 14, 5, 40, 862, DateTimeKind.Utc).AddTicks(2307), false, "Djehinet", "Nadjib" },
                    { new Guid("6b64bab0-5c4f-432b-9691-7231706082b9"), 1, new DateTime(2023, 5, 6, 14, 5, 40, 862, DateTimeKind.Utc).AddTicks(2293), false, "Djehinet", "Djawed" },
                    { new Guid("f0207297-1509-4b8b-be24-b6c1707a299e"), 30, new DateTime(2023, 5, 6, 14, 5, 40, 862, DateTimeKind.Utc).AddTicks(2313), false, "Djehinet", "Fateh" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "PasswordHash", "Username" },
                values: new object[] { 1, "djawed", "djehinet", "$2a$11$EYjFiD/mUA9eCtNuS6O.du.ezBbIIaq1WQqUydaA8tmX/cC5bDVFK", "djawed" });
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
