namespace SlavitzaDiplom.Components.Models
{
    public class Order
    {
        public int ID;
        public string Date;
        //public Cashier;
        public bool Aprruved;
        public bool Completed;
        public string Address;
        public string Comments;
        public List<Product> Products = new ();

    }

}
