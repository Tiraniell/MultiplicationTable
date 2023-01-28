using System;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if (i > 0 && j > 0)
                    {
                        int result = j * i;

                        Console.Write($"{result, -4}" ); // - {переменная, спецификатор форматирования}
                    }
                }

                Console.WriteLine();
            }

        }
    }
}
