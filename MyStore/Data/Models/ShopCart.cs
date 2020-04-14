using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MyStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Data.Models
{
    public class ShopCart
    {
      
        private readonly AppDbContent _appDbContent;
        public ShopCart(AppDbContent appDbContent)
        {
            this._appDbContent = appDbContent;
        }
        public string ShopCartId { get; set; }
        public List<ShopCartItem> listShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDbContent>();

            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", shopCartId);
            return new ShopCart(context) { ShopCartId = shopCartId };
        }
        public void AddToCart(Motorcycle motorcycle)
        {
            _appDbContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                motorcycle = motorcycle,
                price = motorcycle.price
            });
            _appDbContent.SaveChanges();
        }
        public List<ShopCartItem> getShopItems()
        {
            return _appDbContent.ShopCartItem.Where(c => c.ShopCartId == ShopCartId).Include(s => s.motorcycleId).ToList();
        }
    }
}
