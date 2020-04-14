using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Data.Models
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public Motorcycle motorcycle { get; set; }
        public ushort price { get; set; }
        public string ShopCartId { get; set; }
        [ForeignKey("motorcycle")]
        public int motorcycleId { get; set; }
    }
}
