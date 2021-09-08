using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starex.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double DeliveryPrice { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
        public virtual ICollection<Depo> Depos { get; set; }
    }
}
