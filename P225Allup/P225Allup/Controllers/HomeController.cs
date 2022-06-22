using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P225Allup.DAL;
using P225Allup.Models;
using P225Allup.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P225Allup.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Sliders = await _context.Sliders.ToListAsync(),
                Categories = await _context.Categories.Where(c => c.IsMain).ToListAsync(),
                
                Products = await _context.Products.Include(p => p.ProductImages).ToListAsync()

            };

            

            return View(homeVM);
        }
    }
}
