using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    internal class Formulas
    {
        public static double VF(double valorPresente, double TaxaJuros, int n)
        {
            TaxaJuros = TaxaJuros / 100;
            double valorFuturo = valorPresente * (Math.Pow(1 + TaxaJuros, n));
            return valorFuturo;
        }

        public static double RL(double rendimentoAtual, double rendimentoAnterior)
        {
            double rendaLiquida;

            if (rendimentoAnterior == 0)
            {
                return rendaLiquida = 0;
            }
            else
            {
                rendaLiquida = rendimentoAtual - rendimentoAnterior;
                return rendaLiquida;
            }

        }

        public static double VP(double VF, double taxaJuros, int n)
        {
            taxaJuros = taxaJuros / 100;

            double VP = VF / (Math.Pow(1 + taxaJuros, n));
            return VP;
        }


    }
}
