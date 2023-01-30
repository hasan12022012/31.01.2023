using System;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş 3 ədəddən ən böyüyünü tapan proqram

            var num1 = 15;
            var num2 = 56;
            var num3 = 99;

            if (num1 > num2 && num1 > num3) 
            Console.WriteLine(num1);

            if (num2 > num1 && num2 > num3) 
            Console.WriteLine(num2);

            if (num3 > num1 && num3 > num2) 
            Console.WriteLine(num3);

            else
                Console.WriteLine("boyukEdedYoxdur");



        }
    }
}
