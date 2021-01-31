using System;

namespace GraphicsCardShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Gigabyte Aorus";
            product1.Chipset = "GeForce RTX 3090";
            product1.ProductPrice = "23.605 ";
            product1.InStock = 5;

            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductName = "Asus ROG STRIX";
            product2.Chipset = "GeForce RTX 3090";
            product2.ProductPrice = "25.275 ";
            product2.InStock = 3;

            Product product3 = new Product();
            product3.Id = 3;
            product3.ProductName = "Evga XC3 Ultra";
            product3.Chipset = "GeForce RTX 3090";
            product3.ProductPrice = "22.567 ";
            product3.InStock = 8;

            Product[] product = new Product[] { product1, product2, product3 };

            int a = 1;
            Console.WriteLine("****************************FOREACH****************************");
            foreach (var productt in product)
            {
                Console.WriteLine("----------PRODUCT " + (a++) + "----------");
                Console.WriteLine("Name = " + productt.ProductName);
                Console.WriteLine("Chipset = " + productt.Chipset);
                Console.WriteLine("Price = " + productt.ProductPrice);
                Console.WriteLine("InStock = " + productt.InStock);
            }
            Console.WriteLine("****************************FOR****************************");
            for (int b = 0; b < product.Length; b++)
            {
                Console.WriteLine("----------PRODUCT " + (b + 1) + "----------");
                Console.WriteLine("Name = " + product[b].ProductName);
                Console.WriteLine("Chipset = " + product[b].Chipset);
                Console.WriteLine("Price = " + product[b].ProductPrice);
                Console.WriteLine("InStock = " + product[b].InStock);
            }
            int c = 0;
            Console.WriteLine("****************************WHİLE****************************");
            while (c < product.Length)
            {
                Console.WriteLine("----------PRODUCT " + (c + 1) + "----------");
                Console.WriteLine("Name = " + product[c].ProductName);
                Console.WriteLine("Chipset = " + product[c].Chipset);
                Console.WriteLine("Price = " + product[c].ProductPrice);
                Console.WriteLine("InStock = " + product[c].InStock);
                c++;
            }
        }
    }
    class Product
    {
        public int Id { get; set; }
        public string Chipset { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public int InStock { get; set; }
    }
}
 