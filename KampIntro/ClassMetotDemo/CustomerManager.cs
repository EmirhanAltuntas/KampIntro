using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Ekle(Customer customer)
        {
            Console.WriteLine("Ad : "+customer.FirstName + "\nSoyad : " + customer.LastName + "\nSehir : " + customer.City+"\nMüşterisi Eklendi !");
            Console.WriteLine("\n");
        }
        
        public void Sil(Customer customer)
        {
            Console.WriteLine("Ad : " + customer.FirstName + "\nSoyad : " + customer.LastName + "\nSehir : " + customer.City + "\nMüşterisi Eklendi !");
            Console.WriteLine("\n");
        }

        public void Listele(Customer[] customers)
        {
            Console.WriteLine("\t\tMÜŞTERİLER\n");
            foreach (var customer in customers)
            {
                Console.WriteLine( customer.FirstName + " "+ customer.LastName+"-- "+customer.City );
                Console.WriteLine("\n");

            }

            // \t = bir tab boşluk bırakır --- \n bir satır boşluk bırakır.
        }
    }
}
