using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCars : ICars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car { Name = "Tesla", ShortDesc = "best car", LongDesc="best car i have ever seen, i dont know what tp write", Img = "/img/tesla.jpg", Price = 45000, IsFavorite = true, IsAvailable = true, Category = _carsCategory.AllCategories.First()},
                    new Car { Name = "Tesla1", ShortDesc = "best car", LongDesc="best car i have ever seen, i dont know what tp write", Img = "/img/tesla1.jpg", Price = 35000, IsFavorite = true, IsAvailable = true, Category = _carsCategory.AllCategories.First()},
                    new Car { Name = "Tesla2", ShortDesc = "best car", LongDesc="best car i have ever seen, i dont know what tp write", Img = "/img/tesla2.jpg", Price = 15000, IsFavorite = true, IsAvailable = true, Category = _carsCategory.AllCategories.First()},
                    new Car { Name = "Tesla3", ShortDesc = "best car", LongDesc="best car i have ever seen, i dont know what tp write", Img = "/img/tesla.jpg", Price = 25000, IsFavorite = true, IsAvailable = true, Category = _carsCategory.AllCategories.First()},
                    new Car { Name = "Tesla4", ShortDesc = "best car", LongDesc="best car i have ever seen, i dont know what tp write", Img = "/img/tesla1.jpg", Price = 65000, IsFavorite = true, IsAvailable = true, Category = _carsCategory.AllCategories.First()},
                    new Car { Name = "Tesla5", ShortDesc = "best car", LongDesc="best car i have ever seen, i dont know what tp write", Img = "/img/tesla2.jpg", Price = 27000, IsFavorite = true, IsAvailable = true, Category = _carsCategory.AllCategories.First()},
                    new Car { Name = "Tesla6", ShortDesc = "best car", LongDesc="best car i have ever seen, i dont know what tp write", Img = "/img/tesla.jpg", Price = 41000, IsFavorite = true, IsAvailable = true, Category = _carsCategory.AllCategories.First()},
                    new Car { Name = "Tesla7", ShortDesc = "best car", LongDesc="best car i have ever seen, i dont know what tp write", Img = "/img/tesla1.jpg", Price = 48000, IsFavorite = true, IsAvailable = true, Category = _carsCategory.AllCategories.First()},
                    new Car { Name = "Tesla8", ShortDesc = "best car", LongDesc="best car i have ever seen, i dont know what tp write", Img = "/img/tesla2.jpg", Price = 17000, IsFavorite = true, IsAvailable = true, Category = _carsCategory.AllCategories.First()},
                    new Car { Name = "Tesla9", ShortDesc = "best car", LongDesc="best car i have ever seen, i dont know what tp write", Img = "/img/tesla.jpg", Price = 33000, IsFavorite = true, IsAvailable = true, Category = _carsCategory.AllCategories.First()}
                };
            }
            set
            {

            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car GetOneCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
