using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nível3
{
	class Exercício23
	{
		static void Main1(string[] args)
		{
            double primeiroNumero;
            double segundoNumero;
            double resultado;
            int menu;
            Console.WriteLine("Programa Menu de Calculadora!\n\n");
            Console.WriteLine("Digite uma das operações a seguir: \n\t 1 - Adição \n\t 2 - Subtração \n\t 3 - Multiplicação \n\t 4 - Divisão \n");
            menu = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o primeiro número: ");
            primeiroNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            segundoNumero = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    resultado = primeiroNumero + segundoNumero;
                    Console.WriteLine("%f + %f = %f", primeiroNumero + segundoNumero);
                    break;
                case 2:
                    resultado = primeiroNumero - segundoNumero;
                    Console.WriteLine("%f - %f = %f", primeiroNumero - segundoNumero);
                    break;
                case 3:
                    resultado = primeiroNumero * segundoNumero;
                    Console.WriteLine("%f * %f = %f");
                    break;
                case 4:
                    resultado = primeiroNumero / segundoNumero;
                    Console.WriteLine("%f / %f = %f");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            
        }
	}
}
