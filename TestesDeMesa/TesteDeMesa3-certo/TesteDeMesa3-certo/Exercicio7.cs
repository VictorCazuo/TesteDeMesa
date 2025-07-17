using System;
using System.Threading;

namespace TesteDeMesa3_certo
{
    public class Exercicio7
    {
        public static void Teste7()
        {
            int continuar = 1;

            do
            {
                Console.WriteLine("== Simulação de Rendimento com Resgate ==");

                Console.Write("Quantos meses totais você deseja simular? ");
                int meses = int.Parse(Console.ReadLine());

                Console.Write("Em qual mês você deseja fazer o resgate (ex: 5)? ");
                int mesResgate = int.Parse(Console.ReadLine());

                double[] valores = { 1000.00, 5500.00, 12000.00 };
                double[] taxas = { 3.00, 2.48, 2.00 };


                for (int i = 0; i < valores.Length; i++)
                {
                    Formulas.ExibirSimulacaoComResgate(valores[i], taxas[i], meses, mesResgate);
                }

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