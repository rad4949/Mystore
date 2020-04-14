using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int MotorcycleID { get; set; }
        public uint price { get; set; }
        public virtual Motorcycle motorcycle { get; set; }
        public virtual Order order { get; set; }
    }
}
