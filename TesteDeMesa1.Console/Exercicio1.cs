using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa1
{
    public class Exercicio1
    {
        public static void Teste1()
        {
            int a = 10;
            int b = 20;
            int c = (a + b) / 2;
            int c_resultado = c - 40;
            int[] v = new int[4];


            Console.WriteLine($"Teste De Mesa 1 - Exercício 1\n---------------------------------------------");
            Console.WriteLine($"O valor de A é: {a}");
            Console.WriteLine($"O valor de B é: {b}");
            Console.WriteLine($"O valor de C é: {c}");
            Console.WriteLine($"O valor de C_resultado é: {c_resultado}");

            for (int i = 0; i < v.Length; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("---------------------------------------------");
                    v[i] = a + b + c_resultado;
                    Console.WriteLine($"O vetor (v) se encontra na posição {i}\nValor do vetor = {v[i]}\nCondição: V");
                }
                else
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine($"O vetor (v) se encontra na posição {i}\nValor do vetor = {v[i]}\nCondição: F");
                }
            }
        }

    }
}
