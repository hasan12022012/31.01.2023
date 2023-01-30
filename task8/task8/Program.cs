using System;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş ədədin rəqəmləri cəmini qaytaran metod

            var sum = SumOfDigits();
            Console.WriteLine(sum);
        }
        static int SumOfDigits()
        {
            var num = 1596;
            var qaliq = 0;
            var sum = 0;
            while(num!=0)
            {
                qaliq = num % 10;
                num = num / 10;
                sum += qaliq;
            }
            return (sum);
            Console.WriteLine(sum);
            
        }
            
    }
}
