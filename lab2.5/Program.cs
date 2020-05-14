using System;

namespace lab2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            int y = int.Parse(Console.ReadLine());
            int[,] mas = new int[x, y];
            Console.WriteLine();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]: ");
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i == j)
                    {
                        mas[i, j] = 0;

                    }
                    else
                    {
                        mas[i, j] = mas[i, j]* mas[i, j];
                    }
                    Console.Write(" mas[" + i + "," + j + "]: " + mas[i, j] + "\t");
                }

                Console.WriteLine();
            }
           

        }
    }
}
