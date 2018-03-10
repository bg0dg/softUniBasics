﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col <= n; col++)
                {
                    Console.Write(col + " ");

                    if (col == n)
                    {
                        for (int i = n - 1; i >= n - row + 1; i--) 
                        Console.Write(i + " ");
                    }                   
                }
                Console.WriteLine();
            }
        }
    }
}
