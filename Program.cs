using System;

namespace Logica_de_programacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados
            Console.WriteLine("Soma de dois números");
            Console.WriteLine("---------------------");
            Console.Write("Digite o primeiro valor: ");
            int valorUm = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int valorDois = int.Parse(Console.ReadLine());

            //Processamento
            int soma = valorUm + valorDois;

            //Exibir

            Console.WriteLine("A Soma de "+valorUm+" + "+valorDois+" = "+soma);
        }
    }
}
