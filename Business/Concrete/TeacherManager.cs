﻿using System;
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

        public List<Teacher> GetAll()
        {
            return _teacherRepository.GetAll();
        }

        public List<Teacher> GetByFilter(int min_price, int max_price, string Gender)
        {
            return _teacherRepository.GetByFilter(min_price,max_price,Gender);
        }

        public Teacher GetById(int Id)
        {
            return _teacherRepository.GetById(Id);
        }

        public List<Teacher> GetByName(string Title)
        {
            return _teacherRepository.GetByName(Title);

        }


    }
}