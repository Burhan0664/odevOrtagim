using System;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Abstract;
using Concrete;
using Microsoft.VisualBasic;
using System.Net.Http.Headers;
using odevortagi;


namespace Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherController(ITeacherRepository teacherRepository)
        {
            this._teacherRepository = teacherRepository;
        }
        public IActionResult Index(int page = 1, int pageSize = 5)
        {

            PageInfo pageInfo = new PageInfo()
            {
                TotalItems = _teacherRepository.GetCount(),
                CurrentPage = page,
                ItemsPerPage = 5,
            };
            TeacherListViewModel teacherListViewModel = new TeacherListViewModel()
            {
                Teachers = _teacherRepository.GetProductsByPage(page, pageSize),
                PageInfo = pageInfo,
            };

            return View(teacherListViewModel);
        }
        [HttpGet]
        public IActionResult Index(string explore, int min_price, int max_price, DateTime Date, string Gender, int page = 1)
        {
            PageInfo pageInfo = new PageInfo()
            {
                TotalItems = _teacherRepository.GetCount(),
                CurrentPage = page,
                ItemsPerPage = 5,
            };

            if (!string.IsNullOrEmpty(explore))
            {
                TeacherListViewModel teacherListViewModel1 = new TeacherListViewModel()
                {
                    Teachers = _teacherRepository.GetByName(explore),
                    PageInfo = pageInfo,
                };

                if (teacherListViewModel1.Teachers.Count() > 0)
                {
                    teacherListViewModel1.PageInfo.TotalItems = _teacherRepository.GetByName(explore).Count();
                    return View(teacherListViewModel1);
                }
                else
                {
                    return View("notFound");
                }
            }

            TeacherListViewModel teacherListViewModel2 = new TeacherListViewModel()
            {
                Teachers = _teacherRepository.GetByFilter(min_price, max_price, Gender),
                PageInfo = pageInfo,
            };

            if (teacherListViewModel2.Teachers.Count() > 0)
            {
                teacherListViewModel2.PageInfo.TotalItems = _teacherRepository.GetByFilter(min_price, max_price, Gender).Count();

                return View(teacherListViewModel2);
            }

            TeacherListViewModel teacherListViewModel = new TeacherListViewModel()
            {
                Teachers = _teacherRepository.GetProductsByPage(page, 5),
                PageInfo = pageInfo,
            };

            return View(teacherListViewModel);

        }


    }
}