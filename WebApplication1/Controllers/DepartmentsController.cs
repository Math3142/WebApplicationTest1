using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class DepartmentsController : Controller
    {
        private DepartmentsService _departmentsService;
        public DepartmentsController(DepartmentsService departmentsService)
        {
            _departmentsService = departmentsService;
        }

        public IActionResult Index()
        {
            var list = _departmentsService.FindAll();
            return View(list);
        }
    }
}
