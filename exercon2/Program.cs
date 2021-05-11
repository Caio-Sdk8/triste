using System;

namespace exercon2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor a ser pago");

            Console.WriteLine("Qual combustivel você ira usar? (sendo g - gasolina e a - álcool)");
            string combustivel = Console.ReadLine().ToLower();

            Console.WriteLine("Quantos litros você vai abastecer?");
            int litros = int.Parse(Console.ReadLine());

            bool certo = false;

            while(certo == false){
            switch (combustivel)
            {
                case "a":
                if (litros <= 20){
                    var desconto = 1 * 0.97;
                    double preço = 4.90;
                    double conta = (desconto * preço) * litros;

                    Console.WriteLine($"O preço a ser pago é {conta}");
                }
                else if (litros > 20){
                    var desconto = 1 * 0.95;
                    double preço = 4.90;
                    double conta = (desconto * preço) * litros;

                    Console.WriteLine($"O preço a ser pago é {conta}");
                }
                certo = true;
                    break;
                case "g":
                if (litros <= 20){
                    var desconto = 1 * 0.96;
                    double preço = 5.30;
                    double conta = (desconto * preço) * litros;

                    Console.WriteLine($"O preço a ser pago é {conta}");
                }
                else if (litros > 20){
                    var desconto = 1 * 0.94;
                    double preço = 5.30;
                    double conta = (desconto * preço) * litros;

                    Console.WriteLine($"O preço a ser pago é {conta}");
                }
                certo = true;
                    break;
                default:
                certo = false;
                Console.WriteLine("O texto digitado é inválido, repita o processo");
                
                Console.WriteLine("Qual combustivel você ira usar? (sendo g - gasolina e a - álcool)");
                combustivel = Console.ReadLine().ToLower();

                Console.WriteLine("Quantos litros você vai abastecer?");
                litros = int.Parse(Console.ReadLine());
                    break;
            }
            }
            
        }
    }
}
