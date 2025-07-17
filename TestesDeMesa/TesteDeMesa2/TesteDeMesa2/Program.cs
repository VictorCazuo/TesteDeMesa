using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    public class Program
    {
        public static void Main()
        {
            int opcao = 0;

            Console.WriteLine("Lista de exercicios\nDigite 0 - Sair\nDigite 1 - Exercicio 1\nDigite 2 - Exercicio 2\nDigite 3 - Exercicio 3\nDigite 4 - Exercicio 4\nDigite 5 - Exercicio 5");
            opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (opcao)
            {
                case 0: 
                    Console.WriteLine("Fechando...");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;

                case 1:
                    Exercicio1.Teste1();
                    break;

                case 2:
                    Exercicio2.Teste2();
                    break;

                case 3:
                    Exercicio3.Teste3();
                    break;
                
                case 4:
                    Exercicio4.Teste4();
                    break;
                case 5:
                    Exercicio5.Teste5();
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
