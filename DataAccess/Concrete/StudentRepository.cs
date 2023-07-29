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



        public Student GetById(int Id)
        {
            using (var db = new ShopContext())
            {
                var products = db.Students.Where(p => p.Id == Id).FirstOrDefault();
                return products;
            }
        }

        public Student GetByName(string Title)
        {
            using (var db = new ShopContext())
            {
                var products = db.Students.Where(p => p.Name.ToLower().Contains(Title.ToLower())).FirstOrDefault();
                return products;
            }
        }
    }
}