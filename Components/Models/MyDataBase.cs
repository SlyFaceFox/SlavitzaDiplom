namespace SlavitzaDiplom.Components.Models
{
    public static class MyDataBase
    {
        public static List<Order> BaseOrder = new(){
        new Order() {ID =1, Date = "01.01.2025", Aprruved =  false, Completed = false, Address = "Г. Москва"},
        new Order() {ID =2, Date = "01.01.2025", Aprruved =  false, Completed = false, Address = "Г. Москва"},
        new Order() {ID =3, Date = "01.01.2025", Aprruved =  false, Completed = false, Address = "Г. Москва"},
        new Order() {ID =4, Date = "01.01.2025", Aprruved =  false, Completed = false, Address = "Г. Москва"}
        };

        public static List<Product> BaseProduct = new()
        {
            new Product() {ID = 1, Name = "Косичка пломбирная 550 гр", Count = 3, Description = "Тралялялял", Price = 500},
            new Product() {ID = 2, Name = "Косичка еживичная 550 гр", Count = 3, Description = "Тралялялял", Price = 500},
            new Product() {ID = 3, Name = "Косичка банановая 550 гр", Count = 3, Description = "Тралялялял", Price = 500}

        };

    }
}
