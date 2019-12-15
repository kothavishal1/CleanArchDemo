using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;

namespace CleanArchDemoMVC.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseServ;
        public CourseController(ICourseService courseServ)
        {
            _courseServ = courseServ;
        }
        public IActionResult Index()
        {
            CourseViewModel model = _courseServ.getCourses();
            return View(model);
        }
    }
}