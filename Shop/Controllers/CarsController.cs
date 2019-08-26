using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICars _cars;
        private readonly ICarsCategory _carsCategory;

        public CarsController(ICars cars, ICarsCategory carsCategory)
        {
            _cars = cars;
            _carsCategory = carsCategory; 
        }

        public ViewResult List()
        {
            ViewBag.Title = "Page with cars";
            CarsListViewModel cars = new CarsListViewModel();
            cars.Cars = _cars.Cars;
            cars.CurrCategory = "Cars";
            return View(cars);
        }
    }
}
