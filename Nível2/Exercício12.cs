using System;
using System.Collections.Generic;
using System.Text;

namespace Nível2
{
    class Exercício12
    {
        static void Main1(string[] args)
        {
            int x;
            int modulo;
            Console.WriteLine("Programa que exiba seu módulo!\n\n");
            Console.WriteLine("Informe um numero: ");
            x = int.Parse(Console.ReadLine());
            if (x >= 0)
            {
                
            }
            else 
            {
                modulo = x * (-1);
            }
            Console.WriteLine("O módulo de x é : {0}", x);
        }
    }
}
