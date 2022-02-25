using LabP320_02_04_2022.DataAccessLayer;
using LabP320_02_04_2022.Models;
using LabP320_02_04_2022.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabP320_02_04_2022.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbcontext;

        public HomeController(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IActionResult Index()
        {
            HomeVM homeWM = new HomeVM()
            {
                Categories = _dbcontext.Categories.ToList(),
                Flowers = _dbcontext.Flowers.Include(f=>f.FlowersImages).Include(f=>f.FlowerCategories).ThenInclude(fc=>fc.Category).Include(f=>f.Campaign).ToList()
            };
            return View(homeWM);
        }
      
    }
}
