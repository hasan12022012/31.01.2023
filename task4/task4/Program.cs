using System;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş ədədlər siyahısındaki ədədlərin cəmini console-a yazdıran metod

            int[] numbers = { 10, 50, 55, 65 };
            ArrayOfNums(numbers);



        }
        static void ArrayOfNums(int[] numbers)
        {
            var sum = 0;
            for (int i=0;i<numbers.Length;i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
