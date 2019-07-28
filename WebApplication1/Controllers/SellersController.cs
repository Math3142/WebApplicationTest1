using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class SellersController : Controller
    {
        private SellersService _SellersService;
        public SellersController(SellersService sellersService)
        {
            _SellersService = sellersService;
        }

        public IActionResult Index()
        {
            var listSellers = _SellersService.FindAll();
            return View(listSellers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller item)
        {
            _SellersService.Insert(item);
            return RedirectToAction(nameof(Index));
        }
    }
}