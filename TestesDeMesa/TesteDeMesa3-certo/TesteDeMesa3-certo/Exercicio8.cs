using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa3_certo
{
    public class Exercicio8
    {
        public static void Teste8()
        {
            int continuar = 1;

            do
            {
                Console.WriteLine("== Simulação Personalizada de Rendimento com Resgate ==");

                Console.Write("Digite o valor presente (ex: 1000): ");
                double valorPresente = double.Parse(Console.ReadLine());

                Console.Write("Digite a taxa de juros mensal (%) (ex: 2,5): ");
                double taxa = double.Parse(Console.ReadLine());

                Console.Write("Digite o número total de meses para simulação: ");
                int mesesTotais = int.Parse(Console.ReadLine());

                Console.Write("Digite o mês em que deseja realizar o resgate: ");
                int mesResgate = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor que deseja resgatar: ");
                double valorResgate = double.Parse(Console.ReadLine());

                Formulas.ExibirSimulacaoComValorResgate(valorPresente, taxa, mesesTotais, mesResgate, valorResgate);

                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("Cálculo finalizado\nDigite 0 para sair ou 1 para fazer outro cálculo");
                continuar = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            }
            while (continuar == 1);
            Program.Main();
            Console.Clear();

        }
    }
}
