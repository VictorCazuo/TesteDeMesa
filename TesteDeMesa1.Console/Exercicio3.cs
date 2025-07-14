using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa1
{
    public class Exercicio3
    {
        public static void Teste3()
        {
            int a = 7;
            int b = a - 6;
            int[] v = new int[a];
            int count = 0;

            Console.WriteLine($"\n\nTeste De Mesa 1 - Exercício 3\n---------------------------------------------");

            Console.WriteLine($"O valor de A é: {a}");


            while (b < a)
            {
                v[b] = b + a;

                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"O contador está na posição: {count}");
                Console.WriteLine($"O valor de B é: {b}");
                Console.WriteLine($"O vetor tem o valor de: {v[b]}");
                b += 2;
                count++;
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Final:\nO contador se encontra na posição:{count}\nB vale: {b}\nvetor: {b + a}");
        }

    }
}
