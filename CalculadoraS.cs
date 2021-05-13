using System;

namespace calculadora_de_soma
{
    class Calc
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número");
            var num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;
            Console.WriteLine("A soma é: " + soma);


            Console.ReadLine();
        }
    }
}
