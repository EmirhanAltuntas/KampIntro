using System;

namespace OutKeyword
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1;
            int number2 = 50;

            var result = Topla( out number1, number2);

            Console.WriteLine(result);
            Console.ReadKey();


        }

        static int Topla( out int number1,int number2)
        {
            number1 = 10;

            return number1 + number2;
        }
    }
}
