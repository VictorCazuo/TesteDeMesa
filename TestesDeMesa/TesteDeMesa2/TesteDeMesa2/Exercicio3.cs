using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    internal class Exercicio3
    {
        public static void Teste3()
        {
            double VP;
            double taxaJuros;
            int n;
            double VF;
            int continuar = 1;

            Console.WriteLine("Teste de mesa 2 - Exercício 3\n---------------------------------------------");
            Console.WriteLine("Cálculo de Valor Futuro(VF)");

            do
            {
                Console.WriteLine("Digite o seu valor presente R$: ");
                Console.Write("R$");
                VP = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("---------------------------------------------");

                Console.WriteLine("Digite a sua taxa de juros(i) %: ");
                Console.Write("");
                taxaJuros = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("---------------------------------------------");

                Console.WriteLine("Digite o período (n) em mes(es): ");
                Console.Write("");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------------------------");

                VF = Formulas.VF(VP, taxaJuros, n);

                Console.WriteLine($"O valor futuro é de R${VF:F2} no período de {n} mes(es)");

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
