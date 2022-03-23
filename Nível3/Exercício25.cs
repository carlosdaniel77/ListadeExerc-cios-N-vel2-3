using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nível3
{
    class Exercício25
    {
        static void Main(string[] args)
        {
            double altura;
            double alturaxpeso = 0.0;
            string sexo;

            Console.WriteLine("Programa de Dados de altura e sexo de uma pessoa\n\n");
            Console.WriteLine("Digite sua Altura:");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o seu sexo (M para Masculino e F para Feminino):");
            sexo = Console.ReadLine();

            if ((sexo.Equals("M")) || (sexo.Equals("m")))
            {
                alturaxpeso += ((72.7 * altura) - 58);
                Console.WriteLine($"O seu peso ideal é: {alturaxpeso.ToString(("0.00"))}");
            }
            else
            {
                alturaxpeso += ((61.1 * altura) - 44.7);
                Console.WriteLine($"O seu peso ideal é: {alturaxpeso.ToString(("0.00"))}");
            }
            Console.ReadKey();
        }
    }
}
