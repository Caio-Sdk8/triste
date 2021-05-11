using System;

namespace exerrep4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = null;
            valores = new int[10]; 
            
            Console.WriteLine("Digite em ordem crescente 10 valores");

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite os valores");
                valores [i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"O menor numero é o {valores[0]}");
            Console.WriteLine($"O maior numero é o {valores[9]}");


        }
    }
}
