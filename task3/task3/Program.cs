using System;
using System.Globalization;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş ədədlər siyahısındaki ədədlərini cəmini qaytaran metod

            int[] numbers = { 10, 11, 52, 86, 95 };
            var sum=ArrayofNums(numbers);
            Console.WriteLine(sum); 

        }
        static int ArrayofNums(int[] numbers) 
        {
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
                sum += numbers[i];
            return sum; 

        }
            


    }
}
