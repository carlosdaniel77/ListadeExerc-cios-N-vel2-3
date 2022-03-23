using System;
using System.Collections.Generic;
using System.Text;

namespace Nível2
{
	class Exercício22
	{
        static void Main1(string[] args)
        {
            double a = 0;
            double b = 0;
            double numero;
            Console.WriteLine("Programa Organizador de Números!\n\n");

            Console.WriteLine("Digite um número, digite 0 para sair: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                a += numero;
            }
            else {
                b += numero;
            }

            Console.WriteLine("O resultado da variável A é: {0} ", a);
            Console.WriteLine("O resultado da variável B é: {0}", b);
        }
    }
}
