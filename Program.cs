using System;

namespace Aula1jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sorteiro = new Random().Next(-10, 8);
            Console.WriteLine("digite um numero: ");
            float numeroUsuario = float.Parse(Console.ReadLine());
            int tentativas = 0;
            while (tentativas < 5)
            {
                if (numeroUsuario == sorteiro)
                {
                    Console.WriteLine("você acertou o numero é: " + sorteiro);
                    tentativas = 5;
                }
                else
                {
                    Console.WriteLine($"voce errou o numero era: {sorteiro}");
                    tentativas++;
                    Console.WriteLine("{0} de 5 chances. ", tentativas);

                    sorteiro = new Random().Next(-10, 8);
                    Console.WriteLine("digite um numero: ");
                    numeroUsuario = float.Parse(Console.ReadLine());
                }
                
            }
            
        }
    }
}
