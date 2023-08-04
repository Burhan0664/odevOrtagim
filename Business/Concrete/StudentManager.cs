using System;
using System.Net.Http.Headers;
using Abstract;
using Entity;

namespace Concrete
{
    public class StudentManager : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentManager(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }
        public void Create(Student T)
        {
           _studentRepository.Create(T);
        }

        public void Delete(Student T)
        {
            _studentRepository.Delete(T);
        }

        public List<Student> GetAll()
        {
           return _studentRepository.GetAll();
        }

        public List<Student> GetByFilter(int min_price, int max_price, string Gender)
        {
          return _studentRepository.GetByFilter(min_price,max_price,Gender);
        }

        public Student GetById(int Id)
        {
          return  _studentRepository.GetById(Id);
        }

        public List<Student> GetByName(string Title)
        {
            return _studentRepository.GetByName(Title);

        }

   
    }
}