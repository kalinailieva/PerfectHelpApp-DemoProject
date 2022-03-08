using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
        public DataSeeder(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Seed()
        {
            if (!dbContext.UserRoles.Any())
            {
                string[] roles = new string[] { "Admin", "Therapyst", "Client" };
                foreach (string role in roles)
                {
                    var roleStore = new RoleStore<IdentityRole>(dbContext);
                    roleStore.CreateAsync(new IdentityRole(role));
                    dbContext.SaveChangesAsync();
                }
            }

            if (!dbContext.Users.Any())
            {
                var administrator = new IdentityUser();
            };
        }
    }
}
