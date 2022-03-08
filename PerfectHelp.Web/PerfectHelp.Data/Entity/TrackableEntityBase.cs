using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectHelp.Data.Entity
{
    public class TrackableEntityBase
    {
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        //public bool IsActive { get; set; }
    }
}
