using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa3_certo
{
    public static class Exercicio6
    {
        public static void Teste6()
        {
            int continuar = 1;
            do
            {
                Console.WriteLine("== Cálculo de Valor Futuro para 3 investimentos ==");

                Console.Write("Quantos meses você deseja investir? ");
                int meses = int.Parse(Console.ReadLine());

                Console.Write("Quantos dias extras além dos meses? ");
                int dias = int.Parse(Console.ReadLine());

                DateTime dataInicial = DateTime.Now;
                DateTime dataFinal = Formulas.CalcularDataFinal(dataInicial, meses, dias);
                double periodo = Formulas.CalcularPeriodo(dataInicial, dataFinal);

                double[] valores = { 1000, 5500, 12000 };
                double[] taxas = { 3.00, 2.48, 2.00 };

                for (int i = 0; i < valores.Length; i++)
                {
                    double valorFuturo = Formulas.VF(valores[i], taxas[i], periodo);
                    Console.WriteLine($"\nInvestimento R$ {valores[i]:N2} com taxa {taxas[i]}% a.m:");
                    Console.WriteLine($"Período: {periodo:F1} meses");
                    Console.WriteLine($"Valor Futuro: R$ {valorFuturo:N2}");
                    Console.WriteLine("---------------------------------------------------------------");
                }

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
