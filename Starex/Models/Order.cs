using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starex.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderCode { get; set; }
        public string Note { get; set; }
        public decimal Total { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public bool Deleted { get; set; }
        public virtual ICollection<Package>Packages { get; set; }
    }
}
