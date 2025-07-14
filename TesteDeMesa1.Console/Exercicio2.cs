using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa1
{
    public class Exercicio2
    {
        public static void Teste2()
        {
            int a = 2;
            int[] v = new int[6];

            Console.WriteLine($"\n\nTeste De Mesa 1 - Exercício 2");

            while(a < 6)
            {
                Console.WriteLine("---------------------------------------------");
                v[a] = 10 * a;
                Console.WriteLine($"O valor de A é: {a}\nA operação do vetor é: {v[a]}");
                a += 1;
            }
        }
    }
}
