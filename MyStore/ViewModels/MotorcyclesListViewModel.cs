using MyStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.ViewModels
{
    public class MotorcyclesListViewModel
    {
        public IEnumerable<Motorcycle> allMotorcycles { get; set; }
        public string currCategory { get; set; }
    }
}
