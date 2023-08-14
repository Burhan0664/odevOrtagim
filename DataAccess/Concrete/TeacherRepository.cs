using Abstract;
using Entity;

namespace Concrete
{
    public class TeacherRepository : ITeacherRepository
    {
       private readonly ShopContext _context;
       public TeacherRepository(ShopContext _context)
       {
        this._context = _context;
       }
        public void Create(Teacher T)
        {
            
                _context.Add(T);
                _context.SaveChanges();
            
        }

        public void Delete(Teacher T)
        {
            
                _context.Remove(T);
                _context.SaveChanges();
            
        }

        public IQueryable<Teacher> GetAll()
        {
            
                var products = _context.Teachers.AsQueryable();
                return products;
            
        }



        public IQueryable<Teacher> GetByFilter(int min_price, int max_price, string Gender)
        {
            
                var products = _context.Teachers.Where(p => p.Gender == Gender && p.Price >= min_price && p.Price <= max_price).AsQueryable();
                return products;
            
        }



        public Teacher GetById(int Id)
        {
            
                var products = _context.Teachers.Where(p => p.Id == Id).FirstOrDefault();
                return products;
            
        }

        public IQueryable<Teacher> GetByName(string Title)
        {
            
                var products = _context.Teachers.Where(p => p.Name.ToLower().Contains(Title.ToLower())).AsQueryable();
                return products;
            
        }

        public int GetCount()
        {
           
                var products = _context.Teachers.Count();
                return products;
            
        }

        public IQueryable<Teacher> GetProductsByPage(int page = 1, int pageSize = 5)
        {
            
                var products = _context.Teachers.Skip((page - 1) * pageSize).Take(pageSize).AsQueryable();
                return products;
            
        }
    }

}
