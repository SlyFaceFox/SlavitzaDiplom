namespace SlavitzaDiplom.Components.Models
{
    public class Product
    {
        public int ID;
        public string Name;
        public string Description;
        public int Count;
        public decimal Price;
        public int CountFree => Count - CountReserved;
        private int CountReserved_;
        public int CountReserved
        { get { return CountReserved_; } 
            set 
            { 
                int temp = CountReserved_; 
                CountReserved_ = value; 
                if(CountFree < 0)
                {
                    CountReserved_ = temp;
                }
            } 
        }
    }
}
