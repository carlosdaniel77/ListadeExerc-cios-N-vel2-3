using System;
using System.Collections.Generic;
using System.Text;

namespace Nível2
{
	class Exercício21
	{
        static void Main1(string[] args)
        {
            int numero;
            Console.WriteLine("Programa Verificador de Números!\n\n");
            Console.WriteLine("Informe um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("O número digitado é positivo! ");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número digitado é negativo!");
            }
            else
                Console.WriteLine("\n");
        }
    }
}
