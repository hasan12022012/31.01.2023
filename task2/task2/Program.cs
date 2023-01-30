using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Veirlmiş iki ədədi toplayıb console-a yazdıran metod

            SumOfDigits(45, 54);
        }
        static void SumOfDigits(int a, int b)
        {
            var result = a + b;
            Console.WriteLine(result);
        }
    }
}
