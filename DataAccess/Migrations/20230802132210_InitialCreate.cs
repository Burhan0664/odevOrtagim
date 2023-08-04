using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Majority = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Majority = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Date", "Gender", "ImageUrl", "Majority", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 2, 16, 22, 10, 515, DateTimeKind.Local).AddTicks(7347), "Male", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "Matematik sınavı var", 2000m },
                    { 2, new DateTime(2023, 8, 2, 16, 22, 10, 515, DateTimeKind.Local).AddTicks(7353), "Male", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "yazılım yardım", 20200m },
                    { 3, new DateTime(2023, 8, 2, 16, 22, 10, 515, DateTimeKind.Local).AddTicks(7355), "Male", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "Matematik sınavı var", 20200m },
                    { 4, new DateTime(2023, 8, 2, 16, 22, 10, 515, DateTimeKind.Local).AddTicks(7357), "Male", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "Matematik sınavı var", 223000m },
                    { 5, new DateTime(2023, 8, 2, 16, 22, 10, 515, DateTimeKind.Local).AddTicks(7359), "Female", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "Matematik sınavı var", 20300m },
                    { 6, new DateTime(2023, 8, 2, 16, 22, 10, 515, DateTimeKind.Local).AddTicks(7360), "Female", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "Matematik sınavı var", 20400m },
                    { 7, new DateTime(2023, 8, 2, 16, 22, 10, 515, DateTimeKind.Local).AddTicks(7362), "Male", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "Matematik sınavı var", 25000m }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Date", "Gender", "ImageUrl", "Majority", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 2, 16, 22, 10, 515, DateTimeKind.Local).AddTicks(7053), "Male", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "TIP ÖĞRENCİSİNDEN AÇIK LİSE SINAVI YARDIM", 2000m },
                    { 2, new DateTime(2023, 8, 2, 16, 22, 10, 515, DateTimeKind.Local).AddTicks(7160), null, "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "TEZ/PROJE/ ÖDEV PROFESYONEL DESTEK", 3422m },
                    { 3, new DateTime(2023, 8, 2, 16, 22, 10, 515, DateTimeKind.Local).AddTicks(7162), "Male", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "EGE TIP ÖĞRENCİSİNDE SAĞLIK ve AÇIK ÖĞRETİM DERSLERİNE DESTEK", 12332m },
                    { 4, new DateTime(2023, 8, 2, 16, 22, 10, 515, DateTimeKind.Local).AddTicks(7164), "Male", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "ODTÜ mezunu hocalardan özel ders ve üniversite sınav yardımı", 2332m },
                    { 5, new DateTime(2023, 8, 2, 16, 22, 10, 515, DateTimeKind.Local).AddTicks(7165), "Male", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "Matemmatik öedv yardımı", 2000232m },
                    { 6, new DateTime(2023, 8, 2, 16, 22, 10, 515, DateTimeKind.Local).AddTicks(7167), "Female", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "Fizik ödev", 202300m },
                    { 7, new DateTime(2023, 8, 2, 16, 22, 10, 515, DateTimeKind.Local).AddTicks(7169), "Female", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "MAtematik Master", 203200m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
