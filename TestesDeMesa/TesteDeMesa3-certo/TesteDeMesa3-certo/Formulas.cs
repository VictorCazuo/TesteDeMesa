using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa3_certo
{
    internal class Formulas
    {
        public static double VF(double valorPresente, double taxaJuros, double n)
        {
            taxaJuros = taxaJuros / 100;
            return valorPresente * Math.Pow(1 + taxaJuros, n);
        }

        // Meses entre as datas
        public static double CalcularPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            int dias = (dataFinal - dataInicial).Days;
            return dias / 30.0;
        }

        public static DateTime CalcularDataFinal(DateTime dataInicial, int meses, int dias)
        {
            return dataInicial.AddMonths(meses).AddDays(dias);
        }

        public static void ExibirSimulacaoComResgate(double valorPresente, double taxa, int mesesTotais, int mesResgate)
        {
            Console.WriteLine($"\nSimulacao: R$ {valorPresente:N2} com {taxa}% a.m (Resgate fixo de R$1000,00 no mes {mesResgate})");

            double saldo = valorPresente;
            double baseParaRendimento = valorPresente;

            Console.WriteLine("\nMes | Rendimento | Renda Liquida | Resgate | Saldo");

            for (int mes = 0; mes <= mesesTotais; mes++)
            {
                double rendimento;
                double rendaLiquida;
                double resgate = 0;

                if (mes == 0)
                {
                    rendimento = baseParaRendimento;
                    rendaLiquida = 0;
                }
                else if (mes == mesResgate)
                {
                    rendimento = VF(baseParaRendimento, taxa, mes);
                    rendaLiquida = rendimento - VF(baseParaRendimento, taxa, mes - 1);
                    resgate = 1000;
                    rendimento -= resgate;
                    baseParaRendimento = rendimento; // Novo VP depois de resgatar
                }
                else if (mes > mesResgate)
                {
                    rendimento = VF(baseParaRendimento, taxa, 1);
                    rendaLiquida = rendimento - baseParaRendimento;
                    baseParaRendimento = rendimento;
                }
                else
                {
                    rendimento = VF(baseParaRendimento, taxa, mes);
                    rendaLiquida = rendimento - VF(baseParaRendimento, taxa, mes - 1);
                }

                Console.WriteLine($"{mes,3} | R$ {rendimento + resgate,10:N2} | R$ {rendaLiquida,12:N2} | R$ {resgate,7:N2} | R$ {rendimento,10:N2}");

            }
        }

        public static void ExibirSimulacaoComValorResgate(double valorPresente, double taxa, int mesesTotais, int mesResgate, double valorResgate)
        {
            Console.WriteLine($"\nSimulacao: R$ {valorPresente:N2} com {taxa}% a.m (Resgate de R${valorResgate:N2} no mes {mesResgate})");

            double saldo = valorPresente;
            double baseParaRendimento = valorPresente;

            Console.WriteLine("\nMes | Rendimento | Renda Liquida | Resgate | Saldo");

            for (int mes = 0; mes <= mesesTotais; mes++)
            {
                double rendimento;
                double rendaLiquida;
                double resgate = 0;

                if (mes == 0)
                {
                    rendimento = baseParaRendimento;
                    rendaLiquida = 0;
                }
                else if (mes == mesResgate)
                {
                    rendimento = VF(baseParaRendimento, taxa, mes);
                    rendaLiquida = rendimento - VF(baseParaRendimento, taxa, mes - 1);
                    resgate = valorResgate;
                    rendimento -= resgate;
                    baseParaRendimento = rendimento; // Novo VP depois de resgatar
                }
                else if (mes > mesResgate)
                {
                    rendimento = VF(baseParaRendimento, taxa, 1);
                    rendaLiquida = rendimento - baseParaRendimento;
                    baseParaRendimento = rendimento;
                }
                else
                {
                    rendimento = VF(baseParaRendimento, taxa, mes);
                    rendaLiquida = rendimento - VF(baseParaRendimento, taxa, mes - 1);
                }

                Console.WriteLine($"{mes,3} | R$ {rendimento + resgate,10:N2} | R$ {rendaLiquida,12:N2} | R$ {resgate,7:N2} | R$ {rendimento,10:N2}");
            }

        }
    }
}
