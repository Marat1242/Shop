using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public MockCategory() { }

        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName="Электромобили", desc="Элетрический двигатель"},
                    new Category{CategoryName="Автомобили", desc=" Двигатель внутреннего сгорания"}
                };
            }
        }
       
    }
}
