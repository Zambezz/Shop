using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class CarRepository : ICars
    {
        private readonly AppDBContext _context;
        public CarRepository(AppDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> Cars => _context.Car.Include(c => c.Category);
        public IEnumerable<Car> GetFavCars => _context.Car.Where(p => p.IsFavorite).Include(c => c.Category);

        public Car GetOneCar(int carId) => _context.Car.FirstOrDefault(p => p.Id == carId);
    }
}
