using Microsoft.AspNetCore.Mvc;
using MyStore.Data.Interfaces;
using MyStore.Data.Models;
using MyStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyStore.Controllers
{
    public class MotorcyclesController : Controller
    {
        private readonly IAllMotors _allMotors;
        private readonly IMotoCategory _allCategories;

        public MotorcyclesController(IAllMotors allMotors, IMotoCategory iMotoCat)
        {
            _allMotors = allMotors;
            _allCategories = iMotoCat;
        }

        [Route("Motorcycles/List")]
        [Route("Motorcycles/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Motorcycle> motorcycles = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                motorcycles = _allMotors.Motorcycles.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("Sport", category, StringComparison.OrdinalIgnoreCase))
                {
                    motorcycles = _allMotors.Motorcycles.Where(i => i.Category.categoryName.Equals("Sport")).OrderBy(i => i.id);
                    currCategory = "Sport";
                }
                if (string.Equals("Cross", category, StringComparison.OrdinalIgnoreCase))
                {
                    motorcycles = _allMotors.Motorcycles.Where(i => i.Category.categoryName.Equals("Cross")).OrderBy(i => i.id);
                    currCategory = "Cross";
                }
                if (string.Equals("Street", category, StringComparison.OrdinalIgnoreCase))
                {
                    motorcycles = _allMotors.Motorcycles.Where(i => i.Category.categoryName.Equals("Street")).OrderBy(i => i.id);
                    currCategory = "Street";
                }
                if (string.Equals("Traveling", category, StringComparison.OrdinalIgnoreCase))
                {
                    motorcycles = _allMotors.Motorcycles.Where(i => i.Category.categoryName.Equals("Traveling")).OrderBy(i => i.id);
                    currCategory = "Traveling";
                }               
            }

            var motorcycleObj = new MotorcyclesListViewModel
            {
                allMotorcycles = motorcycles,
                currCategory = category
            };

            ViewBag.Title = "Сторінка з мотоциклами";
            return View(motorcycleObj);
        }
    }
}
