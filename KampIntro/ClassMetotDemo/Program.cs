using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                FirstName = "Buse",
                LastName = "Demir",
                City = "İzmir"
            };

            Customer customer2 = new Customer()
            {
                FirstName = "Atilla",
                LastName = "Gümüş",
                City = "Antalya"
            };
            Customer customer3 = new Customer()
            {
                FirstName = "Zeliha",
                LastName = "Altın",
                City = "İstanbul"
            };



            CustomerManager manager = new CustomerManager();

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            manager.Ekle(customer1);
            manager.Sil(customer2);
            manager.Listele(customers);


            Console.ReadKey();
        }
    }
}
