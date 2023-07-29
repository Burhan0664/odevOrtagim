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

        public Student GetById(int Id)
        {
          return  _studentRepository.GetById(Id);
        }

        public Student GetByName(string Title)
        {
            return _studentRepository.GetByName(Title);

        }
    }
}