using System;

namespace RefKeyword
{
    class Program
    {
        static void Main(string[] args)
        {

            // ref keyword : referans olarak göndermek istediğimiz değerin değişmemesi için kullanılan anahtar kelimedir.

            int number1 = 10;

            int number2 = 7;


            var result = Topla(ref number1 , number2);
            Console.WriteLine(result);
            Console.WriteLine(number1);

        }

        static int Topla(ref int number1, int number2) {

            number1 = 25;

            return number1 + number2;
        }
    }
}
