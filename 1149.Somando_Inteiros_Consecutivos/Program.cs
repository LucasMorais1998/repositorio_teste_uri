﻿using System;

namespace _1149.Somando_Inteiros_Consecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Entrada = Console.ReadLine().Split(' ');

            int A = int.Parse(Entrada[0]);
            int N = int.Parse(Entrada[1]);

            if (N <= 0)
            {
                N = int.Parse(Entrada[1]);

                while (N <= 0)
                {
                    N = int.Parse(Console.ReadLine());
                    Entrada[1] = N.ToString();
                }
            }

            int cont = 0;

            for (int i = 0; i <= N - 1; i++)
            {

                cont = cont + (i + A);
            }
            Console.WriteLine(cont);



        }
    }
}
