using System;
using System.Collections.Generic;
using System.IO;

namespace RecursionTree
{
    class Program
    {
        public static List<string> str = new List<string>();

        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter number: (Tree depth)");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine();
                int bits = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.ResetColor();

                int[] vectors = new int[bits];

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Output:");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                VectorRecursion(vectors, 0);
                Console.ResetColor();

                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    foreach (var item in str)
                    {
                        writer.WriteLine(item);
                    }

                    writer.Close();
                }
            }
            catch (Exception exp)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("Input must be an integer number!");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(exp.ToString());
                Console.WriteLine();

                Main(args);
            }
        }

        static void VectorRecursion(int[] vectors, int index)
        {
            if (index == vectors.Length)
            {
                Console.WriteLine(String.Join("", vectors));

                str.Add(String.Join("", vectors));
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                vectors[index] = i;
                VectorRecursion(vectors, index + 1);
            }
        }
    }
}
