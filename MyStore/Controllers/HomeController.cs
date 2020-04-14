using Microsoft.AspNetCore.Mvc;
using MyStore.Data.Interfaces;
using MyStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Controllers
{
    public class HomeController : Controller
    {
        private IAllMotors _motorcycleRep;

        public HomeController(IAllMotors motorcycleRep)
        {
            _motorcycleRep = motorcycleRep;
        }
        public ViewResult Index()
        {
            var homeMotorcyles = new HomeViewModel
            {
                favMotorcycles = _motorcycleRep.getFavMotorcycles
            };
            return View(homeMotorcyles);
        }
    }
}
