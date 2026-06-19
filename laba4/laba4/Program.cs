using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[15];
            int count = 0;
            Console.WriteLine("Сгенерированные числа:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(10, 100);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                int firstDigit = numbers[i] / 10;
                int secondDigit = numbers[i] % 10; 
                if (firstDigit <= secondDigit)
                {
                    count++;
                }
            }
            Console.WriteLine("\nКоличество чисел, где первая цифра больше второй: " + count);
            Console.ReadKey();
        }
    }
}
