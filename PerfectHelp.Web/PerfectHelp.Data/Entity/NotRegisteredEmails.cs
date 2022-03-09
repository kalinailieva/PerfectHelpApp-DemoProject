using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectHelp.Data.Entity
{
    public class NotRegisteredEmails
    {
        [Key]
        public Guid Id = Guid.NewGuid();

        [Required]
        public string Email { get; set; }
    }
}
