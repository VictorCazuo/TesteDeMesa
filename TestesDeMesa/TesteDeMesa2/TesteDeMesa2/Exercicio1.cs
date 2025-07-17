using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    public class Exercicio1
    {
        public static void Teste1()
        {
            double VP;
            double TaxaJuros;
            double valorFuturo;
            int n;
            int continuar = 1;

            Console.WriteLine("Teste de mesa 2 - Exercício 1\n---------------------------------------------");
            Console.WriteLine("Cálculo de Valor Futuro(VF)");

            do
            {
                Console.WriteLine("Digite o seu valor presente R$: ");
                Console.Write("R$");
                VP = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("---------------------------------------------");

                Console.WriteLine("Digite a sua taxa de juros(i) %: ");
                Console.Write("");
                TaxaJuros = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("---------------------------------------------");

                Console.WriteLine("Digite o período (n) em mes(es): ");
                Console.Write("");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------------------------");

                valorFuturo = Formulas.VF(VP, TaxaJuros, n);

                Console.WriteLine($"O valor futuro é de R${valorFuturo:F2} no período de {n} mes(ses)");

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
