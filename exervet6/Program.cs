using System;

namespace exervet6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nomes");

            Console.WriteLine("Digite 10 nomes");

            string[] nomes = null;
            nomes = new string[10];

            bool achei = false;

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o nome:");
                nomes[i] = Console.ReadLine();
            }
            
            Console.WriteLine("qual nome deseja procurar?");
            string nomad = Console.ReadLine();

            foreach (var item in nomes)
            {
                if (nomad == item)
                {
                    achei = true;
                } else {
                }
            }
            
                if (achei == true)
                {
                    Console.WriteLine("ACHEI");
                } else {
                    Console.WriteLine("NÃO ACHEI");
                }
            

        }
    }
}
