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

namespace LabP320_02_04_2022.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string basket = Request.Cookies["Basket"];

            if (!string.IsNullOrEmpty(basket))
            {
                List<BasketCookieItemVM> basketCookieItemVMs = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);
                BasketVM basketVm = new BasketVM();
                basketVm.BasketItems = new List<BasketItemVM>();

                foreach (BasketCookieItemVM item in basketCookieItemVMs)
                {
                    Flower flower = await _context.Flowers.Include(f => f.Campaign).Include(f => f.FlowersImages).FirstOrDefaultAsync(f => f.Id == item.Id);
                    if (flower != null)
                    {
                        BasketItemVM basketItem = new BasketItemVM
                        {
                            Flower = flower,
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

                ViewBag.TotalPrice = basketVm.TotalPrice;
                ViewBag.Count = basketVm.Count;
            }
            else
            {
                ViewBag.TotalPrice = 0;
                ViewBag.Count =0;
            }
            Bio bio = await _context.bio.SingleOrDefaultAsync();
            return View(bio);

        }

    }
}
