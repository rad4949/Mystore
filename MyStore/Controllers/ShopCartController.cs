using Microsoft.AspNetCore.Mvc;
using MyStore.Data.Entities;
using MyStore.Data.Interfaces;
using MyStore.Data.Models;
using MyStore.ViewModels;
using System.Data.Entity;
using System.Linq;

namespace MyStore.Controllers
{
    public class ShopCartController : Controller
    {
        private IAllMotors _motorcycleRep;
        private readonly ShopCart _shopCart;
        private readonly AppDbContent _appDbContent;
        public ShopCartController(IAllMotors motorcycleRep, ShopCart shopCart, AppDbContent appDbContent)
        {
            _motorcycleRep = motorcycleRep;
            _shopCart = shopCart;
            _appDbContent = appDbContent;
        }
        public ViewResult Index()
        {
            var list = _appDbContent.ShopCartItem.Include(x => x.motorcycle).AsQueryable();
            ShopCartViewModel obj = new ShopCartViewModel();
            obj.shopCart = list.Select(x => new ShopCart1ViewModel
            {
                name = x.motorcycle.name,
                price = x.price
            }).ToList();


            //var shopCart = _shopCart.getShopItems();
            //_shopCart.listShopItems = shopCart;

            //var obj = new ShopCartViewModel
            //{
            //    shopCart = _shopCart
            //};
            return View(obj);
        }
        public RedirectToActionResult addToCart(int id)
        {
            var _item = _motorcycleRep.Motorcycles.FirstOrDefault(i => i.id == id);
            if (_item != null)
            {
                _shopCart.AddToCart(_item);
            }
            //_appDbContent.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
