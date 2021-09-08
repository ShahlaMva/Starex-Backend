using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starex.Models
{
    public class AppUser:IdentityUser
    {
       
        public string Surname { get; set; }
        public string CustomId { get; set; }
        public string Gender { get; set; }
        public string CardSeria { get; set; }
        public string CardFinCode { get; set; }
        public DateTime Age { get; set; }
        public string Address { get; set; }
        public ICollection<Order> Orders { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }

    }
}
