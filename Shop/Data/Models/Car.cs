namespace Shop.Data.Models
{
    public class Car
    {
        //int
        public int id { get; set; }
        public int categoryID { get; set; }

        //str
        public string longDesc { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string img { get; set; }

        //bool
        public bool isFavourite { get; set; }
        public bool available { get; set; }


        //other
        public virtual Category Category { get; set; }
        public ushort price { get; set; }
    }
}
