using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PerfectHelp.Data.Entity
{
    public class Newsletter: TrackableEntityBase
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        
    }

    
   
}
