using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyStore.Data.Entities;
using MyStore.Data.Interfaces;
using MyStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Controllers
{
    public class OrderController:Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;
        private readonly AppDbContent _appDbContent;
        public OrderController(IAllOrders allOrders, ShopCart shopCart, AppDbContent appDbContent)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
            _appDbContent = appDbContent;
        }
        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            //shopCart.listShopItems = shopCart.getShopItems();

            var listShopCart = _appDbContent.ShopCartItem.Include(x => x.motorcycle).AsQueryable();

            //if (shopCart.listShopItems.Count==0)
            //{
            //    ModelState.AddModelError("", "Увас мають бути вибрані товари");
            //}
            //if(ModelState.IsValid)
            //{
            //    allOrders.createOrder(order);
            //    return RedirectToAction("Complete");
            //}

            if (listShopCart == null)
            {
                ModelState.AddModelError("", "Увас мають бути вибрані товари");
            }
            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Замовлення успішно виконано";
            return View();
        }
    }
}
