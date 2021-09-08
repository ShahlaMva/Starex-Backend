using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starex.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
