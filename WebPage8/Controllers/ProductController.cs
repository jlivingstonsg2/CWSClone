using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPage8.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BrandItems(string id)
        {
            int BrandId = String.IsNullOrEmpty(id) ? 0 : Convert.ToInt16(id);
            ViewBag.Id = BrandId; 
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
        public IActionResult Items()
        {
            return View();
        }
       
    }
}
