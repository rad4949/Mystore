using MyStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.ViewModels
{
    public class ShopCartViewModel
    {
        public List<ShopCart1ViewModel> shopCart { get; set; }
    }

    public class ShopCart1ViewModel
    {
        public string name { get; set; }
        public int price { get; set; }
    }
}
