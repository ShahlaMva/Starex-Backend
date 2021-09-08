using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starex.Models
{
    public class Depo
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string StartWorkOut { get; set; }
        public string EndWorkOut { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
