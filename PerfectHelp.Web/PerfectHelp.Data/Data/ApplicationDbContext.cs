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
        public DbSet<Subscribers> Subscribers { get; set; }

        public DbSet<NotRegisteredEmails> NotRegisteredEmails { get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Newsletter>()
                .HasKey(x => x.Id);

            builder.Entity<NotRegisteredEmails>()
                .HasKey(x => x.Id);



            //seedData

            var hasher = new PasswordHasher<IdentityUser>();
            builder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                    UserName = "yokogrup@gmail.com",
                    Email = "yokogrup@gmail.com",
                    NormalizedEmail = "YOKOGRUP@GMAIL.COM",
                    NormalizedUserName = "YOKOGRUP@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Mypass123!"),
                    LockoutEnabled = true,
                },
                new IdentityUser
                {
                    Id = "2c5e174e-3y0e-446f-86af-483d56fc7211",
                    UserName = "therapyst@gmail.com",
                    Email = "therapyst@gmail.com",
                    NormalizedEmail = "THERAPYST@GMAIL.COM",
                    NormalizedUserName = "THERAPYST@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Mypass123!"),
                    LockoutEnabled = true,
                },
                new IdentityUser
                {
                    Id = "2c5e174e-3b0e-446f-86af-483d56fc7211",
                    UserName = "user@gmail.com",
                    Email = "user@gmail.com",
                    NormalizedEmail = "USER@GMAIL.COM",
                    NormalizedUserName = "USER@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Mypass123!"),
                    LockoutEnabled = true,
                }
            );
            builder.Entity<IdentityRole>()
                .HasData(new IdentityRole { 
                    Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", 
                    Name = "Admin", NormalizedName = "ADMIN".ToUpper() 
                },
                new IdentityRole
                {
                    Id = "2c5e174e-3b0e-446f-86af-483d56fd7214",
                    Name = "Therapyst",
                    NormalizedName = "THERAPYST".ToUpper()
                },
                new IdentityRole
                {
                    Id = "2c5e174e-3b0e-446f-86af-3d56fd7217",
                    Name = "User",
                    NormalizedName = "USER".ToUpper()
                });

            builder.Entity<IdentityUserRole<string>>()
                .HasData(new IdentityUserRole<string>()
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    UserId = "2c5e174e-3b0e-446f-86af-483d56fd7211"
                },
                new IdentityUserRole<string>()
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7214",
                    UserId = "2c5e174e-3y0e-446f-86af-483d56fc7211"
                },
                    new IdentityUserRole<string>()
                    {
                        RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                        UserId = "2c5e174e-3b0e-446f-86af-483d56fc7211"
                    });
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