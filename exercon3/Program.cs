using System;

namespace exercon3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total a se pagar");

            Console.WriteLine("Qual produto você vai comprar?");
            string produto = Console.ReadLine();

            Console.WriteLine("quantos vai comprar?");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preço dele?");
            double preço = double.Parse(Console.ReadLine());

            if (quantidade <= 5)
            {
                double pb = preço * quantidade;
                double valor = pb * 0.98;
            }
            else if (quantidade > 10){
                double pb = preço * quantidade;
                double valor = pb * 0.95;

                Console.WriteLine($"Olá você terá que pagar {valor}R$ em {quantidade} {produto}");
            }
            else if (quantidade > 5){
                double pb = preço * quantidade;
                double valor = pb * 0.97;
            }
        }
    }
}
