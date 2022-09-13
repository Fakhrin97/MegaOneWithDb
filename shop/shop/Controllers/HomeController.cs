using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Logging;
using shop.DAL;
using shop.Models;
using shop.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Controllers
{
    
    public class HomeController : Controller
    {
       
        private readonly AppDbContext _context;
        public static List<Prodacts> prodacts;

        public HomeController(AppDbContext context)
        {
            _context = context;         
        }
        public IActionResult Index()
        {
            List<Arrivals> arrivals = _context.Arrivals.ToList();
            List<Prodacts> products = _context.Prodacts.ToList();
            List<Slider> sliders = _context.Sliders.ToList();
            IndexVM indexVMs = new IndexVM { Arrival = arrivals, Prodact = products ,Slider= sliders };
            return View(indexVMs);  
        }

        public IActionResult Products()
        {
            List<Prodacts> products = _context.Prodacts.ToList();
            return View(products);
        }
    }
}
