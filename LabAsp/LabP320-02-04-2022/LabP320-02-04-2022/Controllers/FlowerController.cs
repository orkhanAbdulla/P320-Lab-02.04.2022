using LabP320_02_04_2022.DataAccessLayer;
using LabP320_02_04_2022.Models;
using LabP320_02_04_2022.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
        public async Task<IActionResult> Basket()
        {
            string basket = Request.Cookies["Basket"];
            if (string.IsNullOrEmpty(basket))
            {
                return Content("Empty");
            }

            List<BasketVM> basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            List<BasketVM> newBasketVM = new List<BasketVM>();
            foreach (var basketVM in basketVMs)
            {
                Flower flower =await _context.Flowers.FindAsync(basketVM.Id);
                if (flower == null)
                    continue;
                newBasketVM.Add(new BasketVM
                {
                    Id = flower.Id,
                    Description = flower.Description,
                    Name = flower.Name,
                    Price = flower.Price,
                    Count = basketVM.Count
                });
            }
            basket = JsonConvert.SerializeObject(newBasketVM);
            Response.Cookies.Append("Basket", basket);


            return Json(newBasketVM);

        }
        public async Task<IActionResult> AddToCart(int? id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            Flower flower = await _context.Flowers.FindAsync(id);
            if (flower==null)
            {
                return NotFound();
            }
            List<BasketVM> basketVMs;
            string Exsistbasket = Request.Cookies["Basket"];
            if (string.IsNullOrEmpty(Exsistbasket))
            {
                basketVMs = new List<BasketVM>();
            }
            else
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(Exsistbasket);
            }
            BasketVM existBasketVM = basketVMs.FirstOrDefault(x => x.Id == flower.Id);
            if (existBasketVM == null)
            {
                existBasketVM = new BasketVM
                {
                    Id = flower.Id,
                };
                basketVMs.Add(existBasketVM);
            }
            else
            {
                existBasketVM.Count ++;
            }

            string basket = JsonConvert.SerializeObject(basketVMs);
            Response.Cookies.Append("Basket", basket);
            return RedirectToAction(nameof(Index),"Home");

        }
    }
}
