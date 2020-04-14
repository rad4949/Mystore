using MyStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Motorcycle> favMotorcycles { get; set; }
    }
}
