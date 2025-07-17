using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    internal class Exercicio5
    {
        public static void Teste5()
        {
            int continuar = 1;
            do
            {
                double VP = 0;
                double VF = 7390.61;
                double taxaJuros = 1.25;
                int n = 24;

                Console.WriteLine("Teste de mesa 2 - Exercício 5\n---------------------------------------------");
                Console.WriteLine("Cálculo para obter valor futuro do exercício 2 de 7.390,61");

                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("| Período(mês) | Taxa de Juros | Valor Presente | Valor Futuro |");
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine($"| {n,12} |{taxaJuros,14}%| {'?',14} |{VF.ToString("c"),15}|");

                VP = Formulas.VP(VF, taxaJuros, n);
                VF = Formulas.VF(VP, taxaJuros, n);

                Console.WriteLine($"| {n,12} |{taxaJuros,14}%| {VP.ToString("C"),14} |{VF.ToString("c"),15}|");

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
