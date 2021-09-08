using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starex.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipCode { get; set; }
        public string Region { get; set; }
        public string Phone { get; set; }
        public string Direction { get; set; }
        public string  City { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
