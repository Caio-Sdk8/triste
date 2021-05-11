using System;

namespace exercon1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eleição ");

            Console.WriteLine("Em qual ano você nasceu?");
            int nascimento = int.Parse(Console.ReadLine());

            var anoatual = DateTime.Now.Year;
            int votar = anoatual - nascimento;

            if (votar < 16)
            {
                Console.WriteLine("Cara, tu é muito jovem, felizmente não pode votar");
            }
            else if (votar >= 18)
            {
                Console.WriteLine("Você não só pode como deve votar");
            }
            else if (votar >= 16)
            {
                Console.WriteLine("Você pode votar, mas é opcional");
            }
        }

    }
}
