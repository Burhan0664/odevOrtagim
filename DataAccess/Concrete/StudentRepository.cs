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
        private readonly ShopContext _context;

        public StudentRepository(ShopContext context)
        {
            this._context = context;
        }
        public void Create(Student T)

        {
            
                _context.Add(T);
                _context.SaveChanges();
            

        }

        public void Delete(Student T)
        {
            
                _context.Remove(T);
                _context.SaveChanges();
            
        }

        public IQueryable<Student> GetAll()
        {
            
                var products = _context.Students.AsQueryable();
                return products;
            

        }

        public IQueryable<Student> GetByDate24(DateTime Date)
        {
            
                var products = _context.Students.Where(p => p.Date.Hour - Date.Hour <= 24).AsQueryable();
                return products;
            
        }

        public IQueryable<Student> GetByFilter(int min_price, int max_price, string Gender)
        {
            
                var products = _context.Students.Where(p => p.Gender == Gender ||p.Gender==null||Gender=="Double"&& p.Price >= min_price && p.Price <= max_price).AsQueryable();
                return products;
            
        }



        public Student GetById(int Id)
        {
            
                var products = _context.Students.Where(p => p.Id == Id).FirstOrDefault();
                return products;
            
        }

        public IQueryable<Student> GetByName(string Title)
        {
            
                var products = _context.Students.Where(p => p.Name.ToLower().Contains(Title.ToLower())).AsQueryable();
                return products;
            
        }

        public int GetCount()
        {
              var products = _context.Students.Count();
                return products;
            
        }



        public IQueryable<Student> GetProductsByPage(int page = 1, int pageSize = 5)
        {
           
                var products = _context.Students.Skip((page - 1) * pageSize).Take(pageSize).AsQueryable();
                return products;
            
        }


    }
}