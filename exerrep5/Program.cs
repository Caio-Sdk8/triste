using System;

namespace exerrep5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuadas");

            Console.WriteLine("Digite o numero qual deseja saber a tabuada");
            int tab = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultados");

            for (var i = 1; i < 11; i++)
            {
                int conta = tab * i;
                Console.WriteLine($"{tab}x{i}={conta}");
            }
        }
    }   
}
