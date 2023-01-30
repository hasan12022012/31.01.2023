using System;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş ədədlər siyahısındaki ən böyük ədədi qaytaran metod

            int[] numbers = { 15, 56, 89, 123, 65, 48 };
            var max=ArrayOfDigits(numbers);
            Console.WriteLine(max);

        }
        static int ArrayOfDigits(int[] numbers)
        {
            var max = numbers[0];
            for (int i=1;i<numbers.Length;i++)
            {
                if (numbers[i]>max)
                    max= numbers[i];
               
            }
            return max;
        }
    }
}
