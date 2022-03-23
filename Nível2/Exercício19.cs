using System;
using System.Collections.Generic;
using System.Text;

namespace Nível2
{
	class Exercício19
	{
        static void Main1(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Programa Verificador de Triãngulo!\n\n");
            Console.WriteLine("Digite o lado A: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado B: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado C: ");
            c = int.Parse(Console.ReadLine());

            if (a < b + c && b < a + c && c < a + b)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("O triângulo é Equilátero.");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("O triângulo é Isósceles.");
                }
                else
                {
                    Console.WriteLine("O triãngulo é Escaleno: ");
                }
            }
            else {
                Console.WriteLine("Os lados fornecidos não caracterizam um triângulo ");
            }

        }
    }
}
