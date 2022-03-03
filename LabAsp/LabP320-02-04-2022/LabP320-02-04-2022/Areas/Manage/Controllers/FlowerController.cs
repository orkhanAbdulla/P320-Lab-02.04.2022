using LabP320_02_04_2022.DataAccessLayer;
using LabP320_02_04_2022.Extensions;
using LabP320_02_04_2022.Models;
using Microsoft.AspNetCore.Hosting;
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
        private readonly IWebHostEnvironment _web;
        public FlowerController(AppDbContext context, IWebHostEnvironment web)
        {
            _context = context;
            _web = web;
        }
        public IActionResult Index(int page=1)
        {
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Flowers.Count() / 2);
            ViewBag.CurrentPage = page;


            var flowers = _context.Flowers.Include(x=>x.FlowersImages).Skip((page-1)*2).Take(2).ToList();
            return View(flowers);
        }
        public IActionResult Create()
        {
            ViewBag.Campaigns = _context.Campaigns.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Flower flower )
        {
            ViewBag.Campaigns = _context.Campaigns.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            if (!ModelState.IsValid) return View();
            if (flower.CampaignId==0)
            {
                flower.CampaignId = null;
            }
            flower.FlowerCategories = new List<FlowerCategory>();
            flower.FlowersImages = new List<FlowerImage>();
            foreach (var id in flower.CategoryIds)
            {
                FlowerCategory flowerCategory = new FlowerCategory
                {
                    CategoryId = id,
                    FlowerId = flower.Id
                };
                flower.FlowerCategories.Add(flowerCategory);
            }
            foreach (var image in flower.FormFiles)
            {
                if (!image.IsValidType("image/"))
                {
                    ModelState.AddModelError("FormFiles", "Please Select the image type");
                    return View();
                }
                if (!image.IsValidSize(800))
                {
                    ModelState.AddModelError("FormFiles", "You can choose file witch size is max 200kb");
                    return View();
                }
                FlowerImage flowerImage = new FlowerImage()
                {
                    Image = image.SavaFile(_web.WebRootPath, "assets/images"),
                    IsMain = flower.FlowersImages.Count < 1 ? true : false,
                    FlowerId = flower.Id
                };
                flower.FlowersImages.Add(flowerImage);
            }
            _context.Flowers.Add(flower);
            _context.SaveChanges();
           return RedirectToAction(nameof(Index));
        }
    }
}
