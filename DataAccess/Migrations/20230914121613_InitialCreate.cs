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
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Majority = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
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
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Majority = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Date", "Description", "Gender", "ImageUrl", "Majority", "Name", "PhoneNumber", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 14, 15, 16, 12, 968, DateTimeKind.Local).AddTicks(7418), "Boğaziçi Üniversitesi Bilgisayar Mühendisliği mezunu, aynı üniversitede Endüstri Mühendisliği Doktorası yapan, ÖSS Matematik Kitapları Yazarı, eski İTÜ Öğretim Görevlisinden, YKS sınavlarına yönelik veya takviye amaçlı Matematik, Geometri, Fizik, Kimya, İngilizce, SAT Mathematics, AP Calculus, AP Physics, AP Statistics, IB Mathematics, IB Physics vb. dersleri verilir Ayrıca, üniversite öğrencilerine/mezunlarına yönelik KPSS Matematik, ALES Matematik, GRE/GMAT Mathematics, Calculus, Differential Equations, Discrete Mathematics, University Physics, Operations Research, Probability, Statistics, Mathematical Statistics, Econometrics, SAS, SPSS, Linear Algebra, C, C++, C#.NET, Java vb. dersleri  (Çevrimiçi/Öğrencinin Evi/Hocanın Evi) verilir...", "Male", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "Matematik sınavı var", "05070198810", 2000m },
                    { 2, new DateTime(2023, 9, 14, 15, 16, 12, 968, DateTimeKind.Local).AddTicks(7423), "Boğaziçi Üniversitesi Bilgisayar Mühendisliği mezunu, aynı üniversitede Endüstri Mühendisliği Doktorası yapan, ÖSS Matematik Kitapları Yazarı, eski İTÜ Öğretim Görevlisinden, YKS sınavlarına yönelik veya takviye amaçlı Matematik, Geometri, Fizik, Kimya, İngilizce, SAT Mathematics, AP Calculus, AP Physics, AP Statistics, IB Mathematics, IB Physics vb. dersleri verilir Ayrıca, üniversite öğrencilerine/mezunlarına yönelik KPSS Matematik, ALES Matematik, GRE/GMAT Mathematics, Calculus, Differential Equations, Discrete Mathematics, University Physics, Operations Research, Probability, Statistics, Mathematical Statistics, Econometrics, SAS, SPSS, Linear Algebra, C, C++, C#.NET, Java vb. dersleri  (Çevrimiçi/Öğrencinin Evi/Hocanın Evi) verilir...", "Male", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "yazılım yardım", "05070198810", 20200m },
                    { 3, new DateTime(2023, 9, 14, 15, 16, 12, 968, DateTimeKind.Local).AddTicks(7425), "Boğaziçi Üniversitesi Bilgisayar Mühendisliği mezunu, aynı üniversitede Endüstri Mühendisliği Doktorası yapan, ÖSS Matematik Kitapları Yazarı, eski İTÜ Öğretim Görevlisinden, YKS sınavlarına yönelik veya takviye amaçlı Matematik, Geometri, Fizik, Kimya, İngilizce, SAT Mathematics, AP Calculus, AP Physics, AP Statistics, IB Mathematics, IB Physics vb. dersleri verilir Ayrıca, üniversite öğrencilerine/mezunlarına yönelik KPSS Matematik, ALES Matematik, GRE/GMAT Mathematics, Calculus, Differential Equations, Discrete Mathematics, University Physics, Operations Research, Probability, Statistics, Mathematical Statistics, Econometrics, SAS, SPSS, Linear Algebra, C, C++, C#.NET, Java vb. dersleri  (Çevrimiçi/Öğrencinin Evi/Hocanın Evi) verilir...", "Male", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "Matematik sınavı var", "05070198810", 20200m },
                    { 4, new DateTime(2023, 9, 14, 15, 16, 12, 968, DateTimeKind.Local).AddTicks(7427), "Boğaziçi Üniversitesi Bilgisayar Mühendisliği mezunu, aynı üniversitede Endüstri Mühendisliği Doktorası yapan, ÖSS Matematik Kitapları Yazarı, eski İTÜ Öğretim Görevlisinden, YKS sınavlarına yönelik veya takviye amaçlı Matematik, Geometri, Fizik, Kimya, İngilizce, SAT Mathematics, AP Calculus, AP Physics, AP Statistics, IB Mathematics, IB Physics vb. dersleri verilir Ayrıca, üniversite öğrencilerine/mezunlarına yönelik KPSS Matematik, ALES Matematik, GRE/GMAT Mathematics, Calculus, Differential Equations, Discrete Mathematics, University Physics, Operations Research, Probability, Statistics, Mathematical Statistics, Econometrics, SAS, SPSS, Linear Algebra, C, C++, C#.NET, Java vb. dersleri  (Çevrimiçi/Öğrencinin Evi/Hocanın Evi) verilir...", "Male", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "Matematik sınavı var", "05070198810", 223000m },
                    { 5, new DateTime(2023, 9, 14, 15, 16, 12, 968, DateTimeKind.Local).AddTicks(7428), "Boğaziçi Üniversitesi Bilgisayar Mühendisliği mezunu, aynı üniversitede Endüstri Mühendisliği Doktorası yapan, ÖSS Matematik Kitapları Yazarı, eski İTÜ Öğretim Görevlisinden, YKS sınavlarına yönelik veya takviye amaçlı Matematik, Geometri, Fizik, Kimya, İngilizce, SAT Mathematics, AP Calculus, AP Physics, AP Statistics, IB Mathematics, IB Physics vb. dersleri verilir Ayrıca, üniversite öğrencilerine/mezunlarına yönelik KPSS Matematik, ALES Matematik, GRE/GMAT Mathematics, Calculus, Differential Equations, Discrete Mathematics, University Physics, Operations Research, Probability, Statistics, Mathematical Statistics, Econometrics, SAS, SPSS, Linear Algebra, C, C++, C#.NET, Java vb. dersleri  (Çevrimiçi/Öğrencinin Evi/Hocanın Evi) verilir...", "Female", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "Matematik sınavı var", "05070198810", 20300m },
                    { 6, new DateTime(2023, 9, 14, 15, 16, 12, 968, DateTimeKind.Local).AddTicks(7430), "Boğaziçi Üniversitesi Bilgisayar Mühendisliği mezunu, aynı üniversitede Endüstri Mühendisliği Doktorası yapan, ÖSS Matematik Kitapları Yazarı, eski İTÜ Öğretim Görevlisinden, YKS sınavlarına yönelik veya takviye amaçlı Matematik, Geometri, Fizik, Kimya, İngilizce, SAT Mathematics, AP Calculus, AP Physics, AP Statistics, IB Mathematics, IB Physics vb. dersleri verilir Ayrıca, üniversite öğrencilerine/mezunlarına yönelik KPSS Matematik, ALES Matematik, GRE/GMAT Mathematics, Calculus, Differential Equations, Discrete Mathematics, University Physics, Operations Research, Probability, Statistics, Mathematical Statistics, Econometrics, SAS, SPSS, Linear Algebra, C, C++, C#.NET, Java vb. dersleri  (Çevrimiçi/Öğrencinin Evi/Hocanın Evi) verilir...", "Female", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "Matematik sınavı var", "05070198810", 20400m },
                    { 7, new DateTime(2023, 9, 14, 15, 16, 12, 968, DateTimeKind.Local).AddTicks(7431), "Boğaziçi Üniversitesi Bilgisayar Mühendisliği mezunu, aynı üniversitede Endüstri Mühendisliği Doktorası yapan, ÖSS Matematik Kitapları Yazarı, eski İTÜ Öğretim Görevlisinden, YKS sınavlarına yönelik veya takviye amaçlı Matematik, Geometri, Fizik, Kimya, İngilizce, SAT Mathematics, AP Calculus, AP Physics, AP Statistics, IB Mathematics, IB Physics vb. dersleri verilir Ayrıca, üniversite öğrencilerine/mezunlarına yönelik KPSS Matematik, ALES Matematik, GRE/GMAT Mathematics, Calculus, Differential Equations, Discrete Mathematics, University Physics, Operations Research, Probability, Statistics, Mathematical Statistics, Econometrics, SAS, SPSS, Linear Algebra, C, C++, C#.NET, Java vb. dersleri  (Çevrimiçi/Öğrencinin Evi/Hocanın Evi) verilir...", "Male", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "Matematik sınavı var", "05070198810", 25000m }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Date", "Description", "Gender", "ImageUrl", "Majority", "Name", "PhoneNumber", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 14, 15, 16, 12, 968, DateTimeKind.Local).AddTicks(7273), "Boğaziçi Üniversitesi Bilgisayar Mühendisliği mezunu, aynı üniversitede Endüstri Mühendisliği Doktorası yapan, ÖSS Matematik Kitapları Yazarı, eski İTÜ Öğretim Görevlisinden, YKS sınavlarına yönelik veya takviye amaçlı Matematik, Geometri, Fizik, Kimya, İngilizce, SAT Mathematics, AP Calculus, AP Physics, AP Statistics, IB Mathematics, IB Physics vb. dersleri verilir Ayrıca, üniversite öğrencilerine/mezunlarına yönelik KPSS Matematik, ALES Matematik, GRE/GMAT Mathematics, Calculus, Differential Equations, Discrete Mathematics, University Physics, Operations Research, Probability, Statistics, Mathematical Statistics, Econometrics, SAS, SPSS, Linear Algebra, C, C++, C#.NET, Java vb. dersleri  (Çevrimiçi/Öğrencinin Evi/Hocanın Evi) verilir...", "Male", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "TIP ÖĞRENCİSİNDEN AÇIK LİSE SINAVI YARDIM", "05070198810", 2000m },
                    { 2, new DateTime(2023, 9, 14, 15, 16, 12, 968, DateTimeKind.Local).AddTicks(7288), "Boğaziçi Üniversitesi Bilgisayar Mühendisliği mezunu, aynı üniversitede Endüstri Mühendisliği Doktorası yapan, ÖSS Matematik Kitapları Yazarı, eski İTÜ Öğretim Görevlisinden, YKS sınavlarına yönelik veya takviye amaçlı Matematik, Geometri, Fizik, Kimya, İngilizce, SAT Mathematics, AP Calculus, AP Physics, AP Statistics, IB Mathematics, IB Physics vb. dersleri verilir Ayrıca, üniversite öğrencilerine/mezunlarına yönelik KPSS Matematik, ALES Matematik, GRE/GMAT Mathematics, Calculus, Differential Equations, Discrete Mathematics, University Physics, Operations Research, Probability, Statistics, Mathematical Statistics, Econometrics, SAS, SPSS, Linear Algebra, C, C++, C#.NET, Java vb. dersleri  (Çevrimiçi/Öğrencinin Evi/Hocanın Evi) verilir...", null, "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "TEZ/PROJE/ ÖDEV PROFESYONEL DESTEK", "05070198810", 3422m },
                    { 3, new DateTime(2023, 9, 14, 15, 16, 12, 968, DateTimeKind.Local).AddTicks(7290), "Boğaziçi Üniversitesi Bilgisayar Mühendisliği mezunu, aynı üniversitede Endüstri Mühendisliği Doktorası yapan, ÖSS Matematik Kitapları Yazarı, eski İTÜ Öğretim Görevlisinden, YKS sınavlarına yönelik veya takviye amaçlı Matematik, Geometri, Fizik, Kimya, İngilizce, SAT Mathematics, AP Calculus, AP Physics, AP Statistics, IB Mathematics, IB Physics vb. dersleri verilir Ayrıca, üniversite öğrencilerine/mezunlarına yönelik KPSS Matematik, ALES Matematik, GRE/GMAT Mathematics, Calculus, Differential Equations, Discrete Mathematics, University Physics, Operations Research, Probability, Statistics, Mathematical Statistics, Econometrics, SAS, SPSS, Linear Algebra, C, C++, C#.NET, Java vb. dersleri  (Çevrimiçi/Öğrencinin Evi/Hocanın Evi) verilir...", "Male", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "EGE TIP ÖĞRENCİSİNDE SAĞLIK ve AÇIK ÖĞRETİM DERSLERİNE DESTEK", "05070198810", 12332m },
                    { 4, new DateTime(2023, 9, 14, 15, 16, 12, 968, DateTimeKind.Local).AddTicks(7292), "Boğaziçi Üniversitesi Bilgisayar Mühendisliği mezunu, aynı üniversitede Endüstri Mühendisliği Doktorası yapan, ÖSS Matematik Kitapları Yazarı, eski İTÜ Öğretim Görevlisinden, YKS sınavlarına yönelik veya takviye amaçlı Matematik, Geometri, Fizik, Kimya, İngilizce, SAT Mathematics, AP Calculus, AP Physics, AP Statistics, IB Mathematics, IB Physics vb. dersleri verilir Ayrıca, üniversite öğrencilerine/mezunlarına yönelik KPSS Matematik, ALES Matematik, GRE/GMAT Mathematics, Calculus, Differential Equations, Discrete Mathematics, University Physics, Operations Research, Probability, Statistics, Mathematical Statistics, Econometrics, SAS, SPSS, Linear Algebra, C, C++, C#.NET, Java vb. dersleri  (Çevrimiçi/Öğrencinin Evi/Hocanın Evi) verilir...", "Male", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "ODTÜ mezunu hocalardan özel ders ve üniversite sınav yardımı", "05070198810", 2332m },
                    { 5, new DateTime(2023, 9, 14, 15, 16, 12, 968, DateTimeKind.Local).AddTicks(7293), "Boğaziçi Üniversitesi Bilgisayar Mühendisliği mezunu, aynı üniversitede Endüstri Mühendisliği Doktorası yapan, ÖSS Matematik Kitapları Yazarı, eski İTÜ Öğretim Görevlisinden, YKS sınavlarına yönelik veya takviye amaçlı Matematik, Geometri, Fizik, Kimya, İngilizce, SAT Mathematics, AP Calculus, AP Physics, AP Statistics, IB Mathematics, IB Physics vb. dersleri verilir Ayrıca, üniversite öğrencilerine/mezunlarına yönelik KPSS Matematik, ALES Matematik, GRE/GMAT Mathematics, Calculus, Differential Equations, Discrete Mathematics, University Physics, Operations Research, Probability, Statistics, Mathematical Statistics, Econometrics, SAS, SPSS, Linear Algebra, C, C++, C#.NET, Java vb. dersleri  (Çevrimiçi/Öğrencinin Evi/Hocanın Evi) verilir...", "Male", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "Matemmatik öedv yardımı", "05070198810", 2000232m },
                    { 6, new DateTime(2023, 9, 14, 15, 16, 12, 968, DateTimeKind.Local).AddTicks(7295), "Boğaziçi Üniversitesi Bilgisayar Mühendisliği mezunu, aynı üniversitede Endüstri Mühendisliği Doktorası yapan, ÖSS Matematik Kitapları Yazarı, eski İTÜ Öğretim Görevlisinden, YKS sınavlarına yönelik veya takviye amaçlı Matematik, Geometri, Fizik, Kimya, İngilizce, SAT Mathematics, AP Calculus, AP Physics, AP Statistics, IB Mathematics, IB Physics vb. dersleri verilir Ayrıca, üniversite öğrencilerine/mezunlarına yönelik KPSS Matematik, ALES Matematik, GRE/GMAT Mathematics, Calculus, Differential Equations, Discrete Mathematics, University Physics, Operations Research, Probability, Statistics, Mathematical Statistics, Econometrics, SAS, SPSS, Linear Algebra, C, C++, C#.NET, Java vb. dersleri  (Çevrimiçi/Öğrencinin Evi/Hocanın Evi) verilir...", "Female", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "Fizik ödev", "05070198810", 202300m },
                    { 7, new DateTime(2023, 9, 14, 15, 16, 12, 968, DateTimeKind.Local).AddTicks(7296), "Boğaziçi Üniversitesi Bilgisayar Mühendisliği mezunu, aynı üniversitede Endüstri Mühendisliği Doktorası yapan, ÖSS Matematik Kitapları Yazarı, eski İTÜ Öğretim Görevlisinden, YKS sınavlarına yönelik veya takviye amaçlı Matematik, Geometri, Fizik, Kimya, İngilizce, SAT Mathematics, AP Calculus, AP Physics, AP Statistics, IB Mathematics, IB Physics vb. dersleri verilir Ayrıca, üniversite öğrencilerine/mezunlarına yönelik KPSS Matematik, ALES Matematik, GRE/GMAT Mathematics, Calculus, Differential Equations, Discrete Mathematics, University Physics, Operations Research, Probability, Statistics, Mathematical Statistics, Econometrics, SAS, SPSS, Linear Algebra, C, C++, C#.NET, Java vb. dersleri  (Çevrimiçi/Öğrencinin Evi/Hocanın Evi) verilir...", "Female", "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg", "math", "MAtematik Master", "05070198810", 203200m }
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
