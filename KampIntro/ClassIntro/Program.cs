using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiro";
            kurs1.IzlenmeOrani = 27;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "CSS";
            kurs2.Egitmen = "PROTOTURK";
            kurs2.IzlenmeOrani = 27;


            Kurs[] kurslar = new Kurs[] {kurs1,kurs2 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
         
            }
            Console.ReadLine();
        }
        
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
   
}
