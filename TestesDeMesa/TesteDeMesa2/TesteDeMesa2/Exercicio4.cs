using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    internal class Exercicio4
    {
        public static void Teste4()
        {
            int continuar = 1;
            double valorPresente;
            double taxaJuros;
            int n = 0;
            double valorFuturo = 0;
            double rendaLiquida;
            double rendaAcumulada = 0;
            double rendimentoAtual = 0;
            double rendimentoAnterior = 0;
            double resgate = 0;
            double saldo = 0;

            Console.WriteLine("Teste de mesa 2 - Exercício 4\n---------------------------------------------");
            Console.WriteLine("Cálculo de Valor Futuro(VF) com saque no quinto mês");

            do
            {
                Console.WriteLine("Digite o seu valor presente R$: ");
                Console.Write("R$");
                valorPresente = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("---------------------------------------------");

                Console.WriteLine("Digite a sua taxa de juros(i) %: ");
                Console.Write("");
                taxaJuros = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("---------------------------------------------");

                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                Console.WriteLine("| Período(mês) | Taxa de Juros | Rendimento | Renda Liquida | Renda Acumulada | Resgate | Saldo |");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                
                for (int i = 0; i <=6; i++)
                {
                    valorFuturo = Formulas.VF(valorPresente, taxaJuros, n);
                    rendaLiquida = Formulas.RL(valorFuturo, rendimentoAnterior);
                    rendaAcumulada += rendaLiquida;
                    rendimentoAtual = valorFuturo;

                    resgate = 0;

                    if (i == 5)
                    {
                        resgate = 1000d;
                        saldo = rendimentoAtual - resgate;
                        valorPresente = saldo;
                        n = 0;


                        Console.WriteLine($"| {i,12} | {taxaJuros,12} | {rendimentoAtual,12:C} | {rendaLiquida,12:C} | {rendaAcumulada,12:C} | {resgate,12:C} | {saldo,12:C} |");
                        valorFuturo = Formulas.VF(valorPresente, taxaJuros, n);
                    }
                    else
                    {

                        saldo = valorFuturo - resgate;
                        Console.WriteLine($"| {i,12} | {taxaJuros,12} | {rendimentoAtual,12:C} | {rendaLiquida,12:C} | {rendaAcumulada,12:C} | {resgate,12:C} | {saldo,12:C} |");
                    }

                    rendimentoAnterior = valorFuturo;
                    n++;
                }

                Console.WriteLine("Cálculo finalizado\nFazer outro cálculo?\nDigite 1 para continuar ou 0 para sair");
                continuar = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


            } 
            while (continuar == 1);
            Program.Main();
            Console.Clear();



        }
    }
}
