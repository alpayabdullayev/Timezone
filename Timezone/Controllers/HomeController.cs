using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Timezone.DAL;
using Timezone.Models;

namespace Timezone.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            
            _db = db;
        }

        public IActionResult Index()
        {   
            List<Product> products = _db.Products.ToList();
            return View(products);
        }

        public IActionResult Error()
        {
            return View();
        }

      
    }
}
