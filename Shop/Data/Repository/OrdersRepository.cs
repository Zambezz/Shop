using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContext _context;
        private readonly ShopCart _shopCart;

        public OrdersRepository(AppDBContext context, ShopCart shopCart)
        {
            _context = context;
            _shopCart = shopCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            _context.Order.Add(order);

            var items = _shopCart.ListShopItems;
            foreach(var item in items)
            {
                var orderDetails = new OrderDetail()
                {
                    CarId = item.Car.Id,
                    OrderId = order.Id,
                    Price = item.Car.Price
                };
                _context.OrderDetail.Add(orderDetails);
            }
            _context.SaveChanges();
        }
    }
}
