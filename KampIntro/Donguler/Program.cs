using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // array - dizi 

            string[] kurslar = { " Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya Başlagıç İçin Temel Kurs","JAVA" };


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

                
            }
            Console.ReadLine();
        }
    }
}
