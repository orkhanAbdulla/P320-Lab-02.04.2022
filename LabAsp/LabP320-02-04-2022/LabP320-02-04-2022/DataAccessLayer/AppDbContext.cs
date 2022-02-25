using LabP320_02_04_2022.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabP320_02_04_2022.DataAccessLayer
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Campaign> Campaigns { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Flower> Flowers { get; set; }

        public DbSet<FlowerCategory> FlowerCategories { get; set; }

        public DbSet<FlowerImage> FlowerImages { get; set; }
        public DbSet<Bio> bio { get; set; }
    }
}
