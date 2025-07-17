using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TesteDeMesa3_certo
{
    public class Program
    {
        public static void Main()
        {
            int opcao = 0;
            Console.WriteLine("Lista de exercicios\nDigite 0 - Sair\nDigite 6 - Exercicio 6\nDigite 7 - Exercicio 7\nDigite 8 - Exercicio 8\n");
            opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("Fechando...");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;

                case 6:
                    Exercicio6.Teste6();
                    break;

                case 7:
                    Exercicio7.Teste7();
                    break;

                case 8:
                    Exercicio8.Teste8();
                    break;

                default:
                    Console.WriteLine("Escolha um exercicio");
                    Thread.Sleep(1000);
                    Program.Main();
                    break;
            }
        }
    }
}
