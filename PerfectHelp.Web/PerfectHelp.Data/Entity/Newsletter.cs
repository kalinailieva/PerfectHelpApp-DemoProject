using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PerfectHelp.Data.Entity
{
    public class Newsletter: TrackableEntityBase
    {
        public Newsletter()
        {
            this.SubscribedUsers = new HashSet<IdentityUser>();
        }

        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }

        public ICollection<IdentityUser> SubscribedUsers { get; set; }
    }

    
   
}
