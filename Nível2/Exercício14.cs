using System;
using System.Collections.Generic;
using System.Text;

namespace Nível2
{
	class Exercício14
	{
        static void Main1(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Programa de Valores inteiros!\n\n");
            Console.WriteLine("Digite o primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("A diferença entre os números analisado é:{0} ", (a - b));
            }
            else {
                Console.WriteLine("A diferença entre os números analisado é:{0} ", (b - a));
            }

        }
    }
}
