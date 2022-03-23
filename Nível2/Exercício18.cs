using System;
using System.Collections.Generic;
using System.Text;

namespace Nível2
{
	class Exercício18
	{
        static void Main1(string[] args)
        {
            int codigo;
            Console.WriteLine("Programa Verificador de Código!\n\n");
            Console.WriteLine("Digite o código: ");
            codigo = int.Parse(Console.ReadLine());

            switch (codigo) 
            {
                case 1:
                    Console.WriteLine("\n Um! ");
                    break;
                case 2:
                    Console.WriteLine("\n Dois! ");
                    break;
                case 3:
                    Console.WriteLine("\n Três! ");
                    break;
                default:
                    Console.WriteLine("\n Código Inválido!!! ");
					break;
            }

        }
    }
}
