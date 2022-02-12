using LabP320_02_04_2022.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabP320_02_04_2022.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class FlowerController : Controller
    {
        private readonly AppDbContext _context;
        public FlowerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page=1)
        {
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Flowers.Count() / 2);
            ViewBag.CurrentPage = page;


            var flowers = _context.Flowers.Include(x=>x.FlowersImages).Skip((page-1)*2).Take(2).ToList();
            return View(flowers);
        }
    }
}
