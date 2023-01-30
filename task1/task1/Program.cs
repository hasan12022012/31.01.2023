using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş iki ədədi toplayıb qaytaran metod

            var result =SumOfDigits(11, 66);
            Console.WriteLine(result);
        }

        static int SumOfDigits(int num1, int num2) 
        {
            var result=num1+ num2;
            return result;
        }
    }
}
