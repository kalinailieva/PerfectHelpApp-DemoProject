

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PerfectHelp.Data.Entity
{
    public class Subscribers
    {
        public Subscribers()
        {
            this.Users = new List<IdentityUser>();
        }
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<IdentityUser> Users{ get; set; }
        
    }
}
