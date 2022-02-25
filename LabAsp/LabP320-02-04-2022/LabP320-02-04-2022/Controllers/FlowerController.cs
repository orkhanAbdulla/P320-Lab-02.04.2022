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
          
            if (!string.IsNullOrEmpty(basket))
            {
                List<BasketCookieItemVM> basketCookieItemVMs = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);
                BasketVM basketVm = new BasketVM();
                basketVm.BasketItems = new List<BasketItemVM>();

                foreach (BasketCookieItemVM item in basketCookieItemVMs)
                {
                    Flower flower =await _context.Flowers.Include(f => f.Campaign).Include(f => f.FlowersImages).FirstOrDefaultAsync(f => f.Id == item.Id);
                    if (flower!=null)
                    {
                        BasketItemVM basketItem = new BasketItemVM
                        {
                            Flower= flower,
                            Count = item.Count
                        };
                        if (basketItem.Flower.CampaignId == null)
                        {
                            basketItem.Price += basketItem.Flower.Price;
                        }
                        else
                        {
                            basketItem.Price += basketItem.Flower.Price - basketItem.Flower.Price * basketItem.Flower.Campaign.Discount / 100;
                        }
                        basketVm.BasketItems.Add(basketItem);
                        basketVm.Count++;
                        basketVm.TotalPrice += basketItem.Price * basketItem.Count;
                    }
                 
                }
                return View();

            }
            return Content("Empty");
        }
        public async Task<IActionResult> AddToCart(int? id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            Flower flower = await _context.Flowers.Include(x=>x.Campaign).Include(x=>x.FlowersImages).FirstOrDefaultAsync(x=>x.Id== id);
            if (flower==null)
            {
                return NotFound();
            }
            List<BasketCookieItemVM> basketCookieItemVMs;
            string Exsistbasket = Request.Cookies["Basket"];
            if (string.IsNullOrEmpty(Exsistbasket))
            {
                basketCookieItemVMs = new List<BasketCookieItemVM>();
                basketCookieItemVMs.Add(new BasketCookieItemVM
                {
                    Id = flower.Id,
                    Count = 1
                });

            }
            else
            {
                basketCookieItemVMs = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(Exsistbasket);
                BasketCookieItemVM existBasketCookieItem = basketCookieItemVMs.FirstOrDefault(x => x.Id == flower.Id);
                if (existBasketCookieItem==null)
                {
                    existBasketCookieItem = new BasketCookieItemVM
                    {
                        Id = flower.Id,
                        Count=1
                    };
                    basketCookieItemVMs.Add(existBasketCookieItem);
                }
                else
                {
                    existBasketCookieItem.Count++;
                }
            }
            var basket = JsonConvert.SerializeObject(basketCookieItemVMs);
            Response.Cookies.Append("Basket", basket);
            return RedirectToAction(nameof(Index),"Home");

        }
    }
}
