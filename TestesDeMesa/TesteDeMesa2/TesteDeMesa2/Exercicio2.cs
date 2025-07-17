using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    internal class Exercicio2
    {
        public static void Teste2()
        {
            Console.WriteLine("Teste de mesa 2 - Exercício 2\n--------------------------------------------------------------------");
            Console.WriteLine("Tabela de Rendimento para 6 meses:\n");
            int continuar = 1;

            do
            {
                decimal VP = 3800.00m;
                decimal TaxaJuros = 1.25m;
                int totalDeMeses = 6;
                decimal taxaDecimal = TaxaJuros / 100;
                decimal rendimentoAcumulado = 0;

                Console.WriteLine($"Valor inicial: {VP:C}\n");

                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("| Mês | Valor no Inicio | Rendimento do Mês | Rendimento Acumulado |");
                Console.WriteLine("--------------------------------------------------------------------");

                for (int mesAtual = 1;  mesAtual <= totalDeMeses; mesAtual++)
                {
                    decimal rendimentoMes = VP * taxaDecimal;
                    rendimentoAcumulado += rendimentoMes;
                    Console.WriteLine($"| {mesAtual, -3} | {VP, -15:C} | {rendimentoMes, -17:C} | {rendimentoAcumulado, -20:C} |");

                    VP += rendimentoMes;
                }

                Console.WriteLine("Cálculo finalizado\nDigite 0 para sair");
                continuar = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            while (continuar == 1);
            Program.Main();
            Console.Clear();


        }
    }
}
