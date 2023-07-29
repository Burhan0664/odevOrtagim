using System;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Abstract;
using Concrete;
using Microsoft.VisualBasic;

namespace Controllers
{
    public class TeacherController:Controller
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherController(ITeacherRepository teacherRepository)
        {
            this._teacherRepository=teacherRepository;
        }
        public IActionResult Index()
    {
        
        return View(_teacherRepository.GetAll());
    }
       [HttpGet]
        public IActionResult Index(string? explore)
        {
            if (explore!=null&&_teacherRepository.GetByName(explore)!=null)
            {

                var teacher = _teacherRepository.GetByName(explore);
                return View(new List<Teacher> { teacher });
            }
            else
            {
                return View(_teacherRepository.GetAll());   
            }
        }

    }
}