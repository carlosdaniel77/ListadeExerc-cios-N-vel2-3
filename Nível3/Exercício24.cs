using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nível3
{
    class Exercício24
    {
        static void Main1(string[] args)
        {
            double primeiroNumero;
            double segundoNumero;
            int menu;
            bool loopMenu = true;

            Console.WriteLine("Programa de Escolhas\n\n");
            Console.WriteLine("Informe o primeiro número:");
            primeiroNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme o segundo número:");
            segundoNumero = int.Parse(Console.ReadLine());

            while (loopMenu)
            {
                Console.WriteLine("\n Você deseja verificar se...\n\t 1 - Um dos números lidos é ou não múltiplo do outro \n\t 2 - Os dois números lidos são pares \n\t 3 - A média dos dois números é maior ou igual a 7 \n\t 4 - Sair \n ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        if ((primeiroNumero % segundoNumero == 0) || (segundoNumero % primeiroNumero == 0))
                        {
                            Console.WriteLine("Sim, um dos números é múltiplo do outro!");
                        }
                        else
                        {
                            Console.WriteLine("Não, nenhum dos números é múltiplos do outro!");
                        }
                        break;

                    case 2:
                        if ((primeiroNumero % 2 == 0 && segundoNumero % 2 == 0))
                        {
                            Console.WriteLine("Sim, um dos números é pares!");
                        }else
                        {
                            Console.WriteLine("Não, um dos números não é par!");
                        }
                        break;

                    case 3:
                        if((primeiroNumero + segundoNumero)/2 >= 7)
                        {
                            Console.WriteLine("Sim, a média dos dois números é maior ou igual 7!");
                        }
                        else
                        {
                            Console.WriteLine("Não, a média dos dois números não é maior ou igual a 7 ");
                        }
                        break;
                    
                    case 4:
                        loopMenu = false;

                        Console.WriteLine("Saindo...\n");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
