using Microsoft.EntityFrameworkCore;
using MyStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Data.Entities
{
    public class AppDbContent : DbContext
    {
        public AppDbContent(DbContextOptions<AppDbContent> options): base(options)
        {

        }
        public virtual DbSet<Motorcycle> Motorcycle { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<ShopCartItem> ShopCartItem { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
    }
}
