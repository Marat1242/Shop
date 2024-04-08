using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Reflection.Metadata.Ecma335;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car> {

                     new Car
                       { name = "Tesla",
                         shortDesc = "mask car",
                         longDesc = "dsf",
                         img = "",
                         price = 45000,
                         isFavourite = true,
                         available = true,
                         Category= _categoryCars.AllCategories.First()
                        },
                    new Car
                    {
                        name = "Audi",
                        shortDesc = "TT fuck all of them",
                        longDesc = "The best car Without comments",
                        img = "",
                        price = 30000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()

                    }
                };
        }
    }
        public IEnumerable<Car> getFavCars { get;set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
