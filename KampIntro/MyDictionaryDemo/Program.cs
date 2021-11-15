using System;
using System.Collections.Generic;

namespace MyDictionaryDemo
{
    class Program
    {
        
       
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1881, "Mustafa Kemal Atatürk");

            
            Console.ReadLine();

        }

      
    }
}
