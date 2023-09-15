using System;
using System.IO.Compression;
using System.Net.Http.Headers;
using Abstract;
using Concrete;
using Entity;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using odevortagi;


namespace Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IActionResult Index(int page = 1)
        {
            PageInfo pageInfo = new PageInfo()
            {
                TotalItems = _studentRepository.GetCount(),
                CurrentPage = page,
                ItemsPerPage = 5,
            };
            ProductListViewModel productListViewModel = new ProductListViewModel()
            {
                Students = _studentRepository.GetProductsByPage(page, 5),
                PageInfo = pageInfo,
            };

            return View(productListViewModel);


        }
        [HttpGet]
        public IActionResult Index(string explore, int min_price, int max_price, int Date, string Gender, int page = 1)
        {
            PageInfo pageInfo = new PageInfo()
            {
                TotalItems = _studentRepository.GetCount(),
                CurrentPage = page,
                ItemsPerPage = 5,
            };
            if (!string.IsNullOrEmpty(explore))
            {
                ProductListViewModel productListViewModel2 = new ProductListViewModel()
                {
                    Students = _studentRepository.GetByName(explore),
                    PageInfo = pageInfo,

                };
                if (productListViewModel2.Students.Count() > 0)
                {
                    productListViewModel2.PageInfo.TotalItems = _studentRepository.GetByName(explore).Count();

                    return View(productListViewModel2);
                }
                else
                {
                    return View("notFound");
                }
            }
            ProductListViewModel productListViewModel1 = new ProductListViewModel()
            {
                Students = _studentRepository.GetByFilter(min_price, max_price, Gender),
                PageInfo = pageInfo,
            };

            if (productListViewModel1.Students.Count() > 0)
            {
                productListViewModel1.PageInfo.TotalItems = _studentRepository.GetByFilter(min_price, max_price, Gender).Count();

                return View(productListViewModel1);
            }


            ProductListViewModel productListViewModel = new ProductListViewModel()
            {
                Students = _studentRepository.GetProductsByPage(page, 5),
                PageInfo = pageInfo,
            };

            return View(productListViewModel);
        }
        public IActionResult Details(int Id){
           return View(_studentRepository.GetById(Id));
        }


    }
}