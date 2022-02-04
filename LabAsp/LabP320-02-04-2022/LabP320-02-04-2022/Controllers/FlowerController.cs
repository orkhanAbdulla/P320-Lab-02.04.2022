using LabP320_02_04_2022.DataAccessLayer;
using LabP320_02_04_2022.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabP320_02_04_2022.Controllers
{
    public class FlowerController : Controller
    {
        private readonly AppDbContext _context;
        public FlowerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Detail(int id)
        {
            Flower flower = _context.Flowers.FirstOrDefault(x=>x.Id==id);
            if (flower==null)
            {
                return NotFound();
            }
            
            return Json(flower);
        }
    }
}
