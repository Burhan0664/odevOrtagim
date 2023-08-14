using System;
using Abstract;
using Entity;

namespace Concrete
{
    public class TeacherManager : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherManager(ITeacherRepository teacherRepository)
        {
            this._teacherRepository=teacherRepository;
        }
        public void Create(Teacher T)
        {
            _teacherRepository.Create(T);
        }

        public void Delete(Teacher T)
        {
            _teacherRepository.Delete(T);
        }

        public IQueryable<Teacher> GetAll()
        {
            return _teacherRepository.GetAll();
        }

        public IQueryable<Teacher> GetByFilter(int min_price, int max_price, string Gender)
        {
            return _teacherRepository.GetByFilter(min_price,max_price,Gender);
        }

        public Teacher GetById(int Id)
        {
            return _teacherRepository.GetById(Id);
        }

        public IQueryable<Teacher> GetByName(string Title)
        {
            return _teacherRepository.GetByName(Title);

        }

        public int GetCount()
        {
             return _teacherRepository.GetCount();
        }

        public IQueryable<Teacher> GetProductsByPage(int page = 1, int pageSize = 5)
        {
            return _teacherRepository.GetProductsByPage(page,pageSize);
        }
    }
}