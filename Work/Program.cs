using System;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Buzdolabı";
            product1.ProductPrice = 8000;
            product1.Aproved = true;


            Product product2 = new Product();
            product2.ProductName = "Çamaşır Makinası";
            product2.ProductPrice = 6000;
            product2. Aproved = false;

            Product[] products = new Product[] { product1, product2, };

            Console.WriteLine("For Döngüsü");

            for (int i = 0; i < products.Length; i++)
            {

                Console.WriteLine(products[i].ProductName + "adlı ürün fiyatı:" + products[i].ProductPrice +"adlı ürün fiyatı:" + products[i].Aproved +"onaylı durumu:" );
            }

            Console.WriteLine("While Döngüsü");

            int x = 0;
            while (x<products.Length)
            {
                Console.WriteLine(products[x].ProductName + "adlı ürün fiyatı:" + products[x].ProductPrice +   products[x].Aproved + "onaylı durumu:");
                x++;
            }
            Console.WriteLine("Foreach Döngüsü");
            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName + "adlı ürün fiyatı:" + product.ProductPrice + "adlı ürün fiyatı:"+ product.Aproved + "onaylı durumu:");
            }
            Console.ReadKey();
        }
    }
    class Product
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }

        public bool Aproved { get; set; }


    }

}
