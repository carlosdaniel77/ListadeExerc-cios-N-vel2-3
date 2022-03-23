using System;
using System.Collections.Generic;
using System.Text;

namespace Nível2
{
	class Exercício15
	{
        static void Main1(string[] args)
        {
            double primeiraNota;
            double segundaNota;
            double terceiraNota;
            double quartaNota;
            double recuperacaoNota;
            double media;
            bool aprovacao = false;
            Console.WriteLine("Programa Verificador de notas!\n\n");
            Console.WriteLine("Digite a primeira nota: ");
            primeiraNota = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            segundaNota = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            terceiraNota = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota: ");
            quartaNota = int.Parse(Console.ReadLine());

            media = (primeiraNota + segundaNota + terceiraNota + quartaNota) / 4;

            if (media >= 7) aprovacao = true;
            else{
                Console.WriteLine("O aluno ficou de recuperação, digite uma nota: ");
                recuperacaoNota = int.Parse(Console.ReadLine());
                media = (media + recuperacaoNota) / 2;
                if (media >= 7) aprovacao = true;
            }

            if (aprovacao == true)
            {
                Console.WriteLine("\n\nO Aluno foi aprovado com a média", media);
            }
            else {
                Console.WriteLine("\n\nO Aluno foi reprovado com a média", media);
            }
        }
    }
}
