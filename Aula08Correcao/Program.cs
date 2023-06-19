using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08Correcao
{
    class Program
    {
        static void Main(string[] args)
        {


            int pontos = 0;
            Random sorteador = new Random();


            Console.WriteLine("Bem-vindo ao jogo do 21");
            Console.WriteLine("Seu objetivo é chegar próximo de 21 pontos");

            while (true)
            {



                Console.WriteLine($"Você tem {pontos} pontos");
                Console.WriteLine("Deseja continuar? 1 para sim ou 2 para não:");
                int opcao = int.Parse(Console.ReadLine());

               

                if (opcao == 2)
                {

                    Console.WriteLine(" - FIM DE JOGO");
                    break;
                }

                int numero = sorteador.Next(1, 11);


                Console.WriteLine("Você tirou um número" + numero);

                pontos += numero;

                if (pontos > 21)
                {
                    Console.WriteLine("Ah que pena, você estourou a pontuação");
                    break;
                }

                Console.WriteLine("Fim de jogo");
                Console.WriteLine("Sua pontuação final foi de" + pontos);

                Console.ReadKey();
            }

        }
    }
}
