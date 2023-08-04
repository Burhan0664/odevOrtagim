using System;
using System.Collections.Generic;
using System.Data.Common;
using Abstract;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace Concrete
{
    public class StudentRepository : IStudentRepository
    {
        public void Create(Student T)

        {
            using (var db = new ShopContext())
            {
                db.Add(T);
                db.SaveChanges();
            }

        }

        public void Delete(Student T)
        {
            using (var db = new ShopContext())
            {
                db.Remove(T);
                db.SaveChanges();
            }
        }

        public List<Student> GetAll()
        {
            using (var db = new ShopContext())
            {
                var products = db.Students.ToList();
                return products;
            }

        }

        public List<Student> GetByDate24(DateTime Date)
        {
            using (ShopContext db = new ShopContext())
            {
                var products = db.Students.Where(p => p.Date.Hour - Date.Hour <= 24).ToList();
                return products;
            }
        }

        public List<Student> GetByFilter(int min_price, int max_price, string Gender)
        {
            using (ShopContext db = new ShopContext())
            {
                var products = db.Students.Where(p => p.Gender == Gender && p.Price >= min_price && p.Price <= max_price).ToList();
                return products;
            }
        }



        public Student GetById(int Id)
        {
            using (var db = new ShopContext())
            {
                var products = db.Students.Where(p => p.Id == Id).FirstOrDefault();
                return products;
            }
        }

        public List<Student> GetByName(string Title)
        {
            using (var db = new ShopContext())
            {
                var products = db.Students.Where(p => p.Name.ToLower().Contains(Title.ToLower())).ToList();
                return products;
            }
        }




    }
}