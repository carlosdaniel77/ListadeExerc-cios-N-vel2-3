using System;

namespace Nível2
{
    class Exercício11
    {
        static void Main1(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Programa de valores inteiros!\n\n");
            Console.WriteLine("Informe o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B: ");
            b = int.Parse(Console.ReadLine());

            c = a;
            a = b;
            b = c;

            Console.WriteLine("\nO valor de A é: {0}", a);
            Console.WriteLine("\nO valor de B é: {0}", b);
        }
    }
}
