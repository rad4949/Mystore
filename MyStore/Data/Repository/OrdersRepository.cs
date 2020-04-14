using MyStore.Data.Entities;
using MyStore.Data.Interfaces;
using MyStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDbContent _appDbContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDbContent appDbContent, ShopCart shopCart)
        {
            _appDbContent = appDbContent;
            this.shopCart = shopCart;
        }
        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            _appDbContent.Order.Add(order);

            //var items = shopCart.listShopItems;
            var items = _appDbContent.ShopCartItem.Include(x => x.motorcycle).AsQueryable();
            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    MotorcycleID = el.motorcycleId,
                    orderID = order.id,
                    price = el.price
                };
                _appDbContent.OrderDetail.Add(orderDetail);
            }
            _appDbContent.SaveChanges();
        }
    }
}
