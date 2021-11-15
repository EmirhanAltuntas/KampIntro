using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 3;
            product1.Info = "Amasya's Apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 7;
            product2.Info = "Diyarbakır's Watermelon";

            Product[] products = new Product[] { product1, product2 };

            foreach (var item in products)
            {
                Console.WriteLine("Name : "+item.Name+ "\nPrice : " + item.Price+ "\nInfo : " + item.Info+"\n");
            }



            Console.WriteLine("-----------Methods----------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
            Console.ReadKey();
        }
    }
}
