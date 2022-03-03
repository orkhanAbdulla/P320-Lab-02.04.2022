using LabP320_02_04_2022.DataAccessLayer;
using LabP320_02_04_2022.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabP320_02_04_2022.Data
{
    public class DataInitializer
    {
        private readonly AppDbContext _dbcontext;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager ;

        public DataInitializer(AppDbContext context, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _dbcontext = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task SeedDataAsync()
        {
            await _dbcontext.Database.MigrateAsync();

            var roles = new List<string> {
                RoleConstants.AdminRole,
                RoleConstants.ModeratorRole,
                RoleConstants.userRole
            };

            foreach (var role in roles)
            {
                if (await _roleManager.RoleExistsAsync(role))
                    continue;

                await _roleManager.CreateAsync(new IdentityRole(role));

            }
            var user = new AppUser()
            {
                Fullname = "Admin Admin",
                UserName="Admin",
                Email="admin@mail.ru"
            };
            if (await _userManager.FindByNameAsync(user.UserName) != null)
                return;
            await _userManager.CreateAsync(user, "1234@admin");

            await _userManager.AddToRoleAsync(user, RoleConstants.AdminRole);
         
        }
    }
}
