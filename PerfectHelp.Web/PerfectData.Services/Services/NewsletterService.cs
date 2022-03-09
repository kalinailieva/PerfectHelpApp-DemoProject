using Microsoft.AspNetCore.Identity;
using PerfectData.Services.Interfaces;
using PerfectData.Services.Repository;
using PerfectHelp.Data;
using PerfectHelp.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectData.Services.Services
{
    public class NewsletterService : INewsletterService
    {
        private readonly ApplicationDbContext dbContext;

        private readonly IGenericRepository<Subscribers> subscribersRepository;
        private readonly IGenericRepository<Newsletter> newsletterRepository;
        private readonly UserManager<IdentityUser> userManager;
        public NewsletterService(ApplicationDbContext dbContext, UserManager<IdentityUser> userManager, IGenericRepository<Subscribers> subscribersRepository,IGenericRepository<Newsletter> newsletterRepository)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
            this.subscribersRepository = subscribersRepository;
            this.newsletterRepository = newsletterRepository;
        }



        public void GetSubscribed(string name, string email)
        {
            if (name !=null && email != null)
            {
                var group = subscribersRepository.FindAll(x => x.Name == name).FirstOrDefault();
                //does user exist
                var user = this.userManager.FindByEmailAsync(email).Result;
                if (user != null && !group.Users.Contains(user))
                {
                    group.Users.Add(user);
                }
                else
                {
                    if (dbContext.NotRegisteredEmails.FirstOrDefault(x => x.Email == email) == null)
                    {
                        dbContext.NotRegisteredEmails.Add(new NotRegisteredEmails() { Email = email });
                    }                   
                }
               dbContext.SaveChanges();
            }                    
        }

        public Newsletter? AddNewsletter(string title, string text)
        {
            var id = Guid.NewGuid();
            newsletterRepository.Insert(new Newsletter()
            {
                Id = id,
                Title = title,
                Text = text
            });
            var entity = newsletterRepository.GetById(id);

            return entity;
        }
    }
}
