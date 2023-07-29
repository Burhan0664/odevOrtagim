using System;
using Microsoft.EntityFrameworkCore;
using Entity;
namespace Concrete
{
    public class ShopContext : DbContext
    {

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             string dbPath = @"C:\Users\burha\OneDrive\Masaüstü\coder\ÖdevOrtağım\DataAccess\shopdb.db"; 

        optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed veritabanı için örnek verileri burada tanımlayın
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { Id = 1, Name = "TIP ÖĞRENCİSİNDEN AÇIK LİSE SINAVI YARDIM",Majority="math",ImageUrl="https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",Price=2000 },
                new Teacher { Id = 2, Name = "TEZ/PROJE/ ÖDEV PROFESYONEL DESTEK" ,Majority="math",ImageUrl="https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",Price=3422 },
                new Teacher { Id = 3, Name = "EGE TIP ÖĞRENCİSİNDE SAĞLIK ve AÇIK ÖĞRETİM DERSLERİNE DESTEK",Majority="math",ImageUrl="https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg" ,Price=12332 },
                new Teacher { Id = 4, Name = "ODTÜ mezunu hocalardan özel ders ve üniversite sınav yardımı",Majority="math",ImageUrl="https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg" ,Price=2332},
                new Teacher { Id = 5, Name = "Matemmatik öedv yardımı", Majority="math",ImageUrl="https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",Price=2000232 },
                new Teacher { Id = 6, Name = "Fizik ödev",Majority="math",ImageUrl="https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg" ,Price=202300},
                new Teacher { Id = 7, Name = "MAtematik Master",Majority="math",ImageUrl="https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg" ,Price=203200}
   
            );
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Matematik sınavı var",Majority="math",ImageUrl="https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",Price=2000  },
                new Student { Id = 2, Name = "yazılım yardım" ,Majority="math",ImageUrl="https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",Price=20200  },
                new Student { Id = 3, Name = "Matematik sınavı var" ,Majority="math",ImageUrl="https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",Price=20200 },  
                new Student { Id = 4, Name = "Matematik sınavı var" ,Majority="math",ImageUrl="https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",Price=223000  },
                new Student { Id = 5, Name = "Matematik sınavı var" ,Majority="math",ImageUrl="https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",Price=20300 },
                new Student { Id = 6, Name = "Matematik sınavı var" ,Majority="math",ImageUrl="https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",Price=20400  },
                new Student { Id = 7, Name = "Matematik sınavı var" ,Majority="math",ImageUrl="https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",Price=25000  }

            );
        }
    }
}