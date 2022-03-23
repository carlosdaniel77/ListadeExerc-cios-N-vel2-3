using System;
using System.Collections.Generic;
using System.Text;

namespace Nível2
{
	class Exercício16
	{
        static void Main1(string[] args)
        {
            int primeiroNumero;
            int segundoNumero;
            Console.WriteLine("Programa Verificador de números!\n\n");
            Console.WriteLine("Digite o primeiro número: ");
            primeiroNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            segundoNumero = int.Parse(Console.ReadLine());

            if (primeiroNumero > segundoNumero)
            {
                Console.WriteLine("\nO primeiro número é maior que o segundo número. ");
            }
            else if (primeiroNumero < segundoNumero)
            {
                Console.WriteLine("\nO primeiro número é menor que o segundo número. ");
            }
            else {
                Console.WriteLine("\nOs dois números são idênticos. ");
            }
        }
    }
}
