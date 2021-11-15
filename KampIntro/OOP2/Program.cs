using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer ındividualCustomer1 = new IndividualCustomer()
            {
                Id = 1,
                MusteriNo = "101",
                Adi = "Buket",
                Soyadi = "Çiçek",
                TcNo = "11122233344",
            
            };

            CorporateCustomer corporateCustomer1 = new CorporateCustomer() 
            {
                Id = 1,
                MusteriNo = "101",
                SirketAdi = "Buket",
                VergiNo = "212121",

            };



            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(corporateCustomer1);
            customerManager.Add(ındividualCustomer1);
            customerManager.Add(customer3);
            customerManager.Add(customer4);






        }
    }
}
