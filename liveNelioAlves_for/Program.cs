using System;

namespace liveNelioAlves_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, soma, var;
            Console.WriteLine("Entre com o numero de vezes: ");
            N = int.Parse(Console.ReadLine());
            soma = 0;

            for (int i=1; i<=N; i++)
            {
                var = int.Parse(Console.ReadLine());
                soma += var;                
            }
            Console.WriteLine(soma);
        }
    }
}
