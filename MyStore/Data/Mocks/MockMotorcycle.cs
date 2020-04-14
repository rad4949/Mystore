using MyStore.Data.Interfaces;
using MyStore.Data.Mocks;
using MyStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MotoShop.Data.Mocks
{
    public class MockMotorcycle : IAllMotors
    {
        private readonly IMotoCategory _motoCategory = new MockCategory();
        public IEnumerable<Motorcycle> Motorcycles
        {
            get
            {
                return new List<Motorcycle> {
                  new Motorcycle {
                    name="Ducati",
                    shortDesc="Streetfighter",
                    longDesc="Зручний у використанні.",
                    img="/img/Streetfighter.jpg",
                    price=15000,
                    isFavorite=true,
                    availabel=true,
                    Category= _motoCategory.AllCategories.ElementAt(3)
                  },
                  new Motorcycle {
                    name="Ducati",
                    shortDesc="Hypermotard",
                    longDesc="Зручний у використанні.",
                    img="/img/Hypermotard.jpg",
                    price=14000,
                    isFavorite=true,
                    availabel=true,
                    Category= _motoCategory.AllCategories.ElementAt(3)
                  },
                  new Motorcycle {
                    name="ВMW",
                    shortDesc="GS 1200",
                    longDesc="Приємно подорожувати.",
                    img="/img/GS 1200.jpg",
                    price=16000,
                    isFavorite=true,
                    availabel=true,
                    Category= _motoCategory.AllCategories.Last()
                  },
                  new Motorcycle {
                    name="Honda",
                    shortDesc="250 CRF",
                    longDesc="Підходить для ралі, надійний.",
                    img="/img/250 CRF.jpg",
                    price=14000,
                    isFavorite=true,
                    availabel=true,
                    Category= _motoCategory.AllCategories.ElementAt(2)
                  },
                  new Motorcycle {
                    name="Ducati",
                    shortDesc="Panigale R",
                    longDesc="Неймовірно швидкий, підходить для шосейних треків.",
                    img="/img/Panigale R.jpg",
                    price=27000,
                    isFavorite=true,
                    availabel=true,
                    Category= _motoCategory.AllCategories.First()
                  },
                  new Motorcycle {
                    name="Kawasaki ",
                    shortDesc="H2r",
                    longDesc="Має найбільшу швидкість.",
                    img="/img/H2r.jpg",
                    price=39000,
                    isFavorite=true,
                    availabel=true,
                    Category= _motoCategory.AllCategories.First()
                  },
                  new Motorcycle {
                    name="Ducati",
                    shortDesc="Diavel",
                    longDesc="Неймовірно комфортний та надійний",
                    img="/img/Diavel.jpg",
                    price=25000,
                    isFavorite=true,
                    availabel=true,
                    Category= _motoCategory.AllCategories.Last()
                  }
                };

            }
        }
        public IEnumerable<Motorcycle> getFavMotorcycles { get; set; }

        public Motorcycle getObjectMotorcycle(int motorcycleId)
        {
            throw new NotImplementedException();
        }
    }
}
