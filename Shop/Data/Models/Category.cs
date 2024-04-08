namespace Shop.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string CategoryName{get; set; }
        public string  desc{ get; set; }
        public List<Car> Cars { get; set; }

    }
}
