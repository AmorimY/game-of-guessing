using System;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um numero entre 1 - 100: ");
           int numeroEscolhido = Convert.ToInt32(Console.ReadLine());

            Random rdn = new Random();
            int numeroSorteado = rdn.Next(1, 5);
            int tentativas = 0;


            while (numeroEscolhido != numeroSorteado)
            {
                if(numeroEscolhido > numeroSorteado)
                {
                    Console.WriteLine("numero errado, " + numeroEscolhido + " muito alto!!");
                    numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                    tentativas++;
                }
                else if(numeroEscolhido < numeroSorteado)
                {
                    Console.WriteLine("numero errado, " + numeroEscolhido + " muito baixo!!");
                    numeroEscolhido = Convert.ToInt32(Console.ReadLine());
                    tentativas++;

                }


            }
            Console.WriteLine("Voce acertou com " + tentativas + " tentativas");
        }
    }
}