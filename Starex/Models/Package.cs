using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starex.Models
{
    public class Package
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public decimal DeliveryPrice { get; set; }
        public bool Ordered { get; set; }
        public bool Delivered { get; set; }
        public string ShopName { get; set; }
        public string Link { get; set; }
        public decimal Price { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public decimal TurkeyCargo { get; set; }
        public string ProductType { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
