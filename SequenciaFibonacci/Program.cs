using System;
using System.Drawing;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Digite quantos numero deseja gerar!");

            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Digite um numero maior que 0!");
            }

            int[] Sequencia = new int[n];

            Sequencia[0] = 0;
            Sequencia[1] = 1;

            for (int i = 2; i < n; i++)
            {
                Sequencia[i] = Sequencia[i - 1] + Sequencia[i - 2];
            }

            // Exibição dos elementos da sequência
            Console.WriteLine($@"Os {n} primeiros elementos da sequência Fibonacci são:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Sequencia[i]);
            }

        }
        catch (Exception ex) { 
            Console.WriteLine("Voce tem que digitar um numero !!! Erro :" + ex.ToString());
        }
        
    }
}
