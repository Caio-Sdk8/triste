using System;

namespace exervet7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 15 numeros");

            int[] numeros = null;
            numeros = new int[15];

            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite o proximo numero");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (var i = (15 -1); i >= 0; i--)
            {
                Console.WriteLine("Toma sua lista \n" + numeros[i]);
            }
            
            
        }
    }
}
