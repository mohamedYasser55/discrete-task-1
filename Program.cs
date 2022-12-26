using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, v, j;
            Console.WriteLine("max:");
            v = int.Parse(Console.ReadLine());
            Console.WriteLine("min:");
            for (i = int.Parse(Console.ReadLine()); i <= v; i++)
            {
                for(j =2; j <=i; j++)
                    if (i % j == 0)
                    {
                        break;
                        if(i == j)
                        {
                            Console.WriteLine(i);
                        }
                    }
            }

        }
    }
}
