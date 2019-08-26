using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.Data.Repository;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class ShopCartController: Controller
    {
        private readonly ICars _carRep;
        private readonly ShopCart _shopCart;
        private readonly IAllOrders _allOrders;
        public ShopCartController(ICars carRep, ShopCart shopCart, IAllOrders allOrders)
        {
            _allOrders = allOrders; 
            _carRep = carRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.GetShopItems();
            _shopCart.ListShopItems = items;
            var obj = new ShopCartViewModel
            {
                ShopCart = _shopCart
            };
            return View(obj);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = _carRep.Cars.FirstOrDefault(x => x.Id == id);
            if(item != null)
             _shopCart.AddToCart(item);

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _shopCart.ListShopItems = _shopCart.GetShopItems();
            if (_shopCart.ListShopItems.Count == 0)
            {
                ModelState.AddModelError("", "У вас должны быть товары");
            }
            if (ModelState.IsValid)
            {
                _allOrders.CreateOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    }
}
