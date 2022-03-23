using System;
using System.Collections.Generic;
using System.Text;

namespace Nível2
{
    class Exercício20
    {
        static void Main1(string[] args)
        {
            int[] valores = new int[3];
            Console.WriteLine("Programa Verificador de variáveis!\n\n");
            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine("Digite o valor", (x + 1), ":");
                valores[x] = int.Parse(Console.ReadLine());
                while (valores[x] <= 0)
                {
                    Console.WriteLine("Digite um valor válido no valor", (x + 1), ":");
                    valores[x] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine(" Exibe o menor valor lido multiplicado pelo maior: {0} ", (valores[0] * valores[2]), "   E o maior valor dividido pelo menor: {0} ", (valores[2] / valores[0]));
        }
    }
}
