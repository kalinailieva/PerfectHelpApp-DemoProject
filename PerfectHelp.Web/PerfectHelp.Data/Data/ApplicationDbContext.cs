using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PerfectHelp.Data.Entity;
using System.Security.Claims;

namespace PerfectHelp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {

        }

        private readonly IHttpContextAccessor _httpContextAccessor;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public DbSet<Newsletter> Newsletters { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Newsletter>()
                .HasMany(x => x.SubscribedUsers)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);

            //seedData

            //var hasher = new PasswordHasher<IdentityUser>();
            //builder.Entity<IdentityUser>().HasData(
            //    new IdentityUser
            //    {
            //        Id = Guid.NewGuid().ToString(),
            //        UserName = "admin",
            //        NormalizedUserName = "ADMIN",
            //        PasswordHash = hasher.HashPassword(null, "Mypass123!"),
            //    }
            //    );
            //builder.Entity<IdentityRole>().HasData(
            //    new IdentityRole
            //    {
            //        Id = Guid.NewGuid().ToString(), // for admin
            //        Name = "Admin",
            //        NormalizedName = "ADMIN"
            //    },
            //    new IdentityRole
            //    {
            //        Id = Guid.NewGuid().ToString(), // for therapyst 
            //        Name = "Therapyst",
            //        NormalizedName = "THERAPYST"
            //    },
            //    new IdentityRole
            //    {
            //        Id = Guid.NewGuid().ToString(), // for user
            //        Name = "User",
            //        NormalizedName = "USER"
            //    }
            //);
        }



        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            OnBeforeSaving();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void OnBeforeSaving()
        {
            var entities = ChangeTracker
                .Entries()
                .Where(e => e.Entity is TrackableEntityBase && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                var userId = this._httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var dateNow = DateTime.UtcNow;

                if (entity.Entity is TrackableEntityBase entityBase)
                {
                    switch (entity.State)
                    {
                        case EntityState.Added:
                            entityBase.CreatedBy = userId ?? userId;
                            entityBase.CreatedAt = dateNow;
                            break;
                        case EntityState.Modified:
                            entityBase.ModifiedBy = userId ?? userId;
                            entityBase.ModifiedAt = dateNow;
                            break;
                    }
                }
            }
        }
    }
}