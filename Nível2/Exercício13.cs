using System;
using System.Collections.Generic;
using System.Text;

namespace Nível2
{
    class Exercício13
    {
        static void Main1(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Programa de valores inteiros de forma decrescente!\n\n");
            Console.WriteLine("Informe um número de A: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe um número de B: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe um número de C: ");
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (b > c)
                {
                    Console.WriteLine("A ordem é: {0}", a, b, c);
                }
                else
                {
                    if (a > c)
                    {
                        Console.WriteLine("A ordem é: {0} ", a, c, b);
                    }
                    else
                    {
                        Console.WriteLine("A ordem é: {0} ", c, a, b);
                    }
                }

            }
            else {
                if (b > c)
                {
                    if (a > c)
                    {
                        Console.WriteLine("A ordem é: {0} ", b, a, c);
                    }
                    else
                    {
                        Console.WriteLine("A ordem é: {0} ", b, c, a);
                    }
                }
                else {
                    Console.WriteLine("A ordem decrescente é: {0},{1},{2} ", c, b, a);
                }
            }
        }
    }
}
