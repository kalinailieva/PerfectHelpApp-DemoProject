using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectHelp.Data.Infrastructure
{
    public class DataSeeder
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IServiceProvider serviceProvider;
        public DataSeeder(ApplicationDbContext dbContext, IServiceProvider services)
        {
            this.dbContext = dbContext;
            this.serviceProvider = services;
        }

        public void Seed()
        {
           // if (!dbContext.Roles.Any())
           // {
           //     string[] roles = new string[] { "Admin", "Therapyst", "Client" };
           //     foreach (string currentRole in roles)
           //     {
           //         var roleStore = new RoleStore<IdentityRole>(dbContext);
           //         roleStore.CreateAsync(new IdentityRole(currentRole));
           //         dbContext.SaveChangesAsync();
           //     }
           // }

           // var user = new IdentityUser()
           // {
           //     Email = "yokogrup@gmail.com",
           //     UserName = "admin",
           //     NormalizedEmail = "YOKOGRUP@GMAIL.COM",
           //     NormalizedUserName = "ADMIN",
           //     SecurityStamp = Guid.NewGuid().ToString("D")

           // };

           // if (!dbContext.Users.Any(u => u.UserName == user.UserName))
           // {
           //     var password = new PasswordHasher<IdentityUser>();
           //     var hashed = password.HashPassword(user, "Therapy123!");
           //     user.PasswordHash = hashed;

           //     var userStore = new UserStore<IdentityUser>(dbContext);
           //     var result = userStore.CreateAsync(user);
           //     dbContext.SaveChangesAsync();

           // }
            

           // string[] role = new string[] { "admin" };
        

           //AssignRoles(serviceProvider, "yokogrup@gmail.com", role );

           // dbContext.SaveChangesAsync();
        }

        public static async Task<IdentityResult> AssignRoles(IServiceProvider services, string email, string[] role)
        {
            UserManager<IdentityUser> _userManager = services.GetService<UserManager<IdentityUser>>();
            IdentityUser user = await _userManager.FindByEmailAsync(email);
            var result = await _userManager.AddToRolesAsync(user, role);

            return result;
        }

    }   
}
