using Abstract;
using Entity;

namespace Concrete
{
    public class TeacherRepository : ITeacherRepository
    {
        public void Create(Teacher T)
        {
            using (var db = new ShopContext())
            {
                db.Add(T);
                db.SaveChanges();
            }
        }

        public void Delete(Teacher T)
        {
            using (var db = new ShopContext())
            {
                db.Remove(T);
                db.SaveChanges();
            }
        }

        public List<Teacher> GetAll()
        {
            using (var db = new ShopContext())
            {
                var products = db.Teachers.ToList();
                return products;
            }
        }

        public Teacher GetById(int Id)
        {
            using (var db = new ShopContext())
            {
                var products = db.Teachers.Where(p => p.Id == Id).FirstOrDefault();
                return products;
            }
        }

        public Teacher GetByName(string Title)
        {
            using (var db = new ShopContext())
            {
                var products = db.Teachers.Where(p => p.Name.ToLower().Contains(Title.ToLower())).FirstOrDefault();
                return products;
            }
        }
    }
}