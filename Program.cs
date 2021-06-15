using System;

namespace Calculadora
{
    class Program
    { 
        
        enum Menu { Soma = 1, Subtracao, Multiplicacao, Divisao, Potencia, Raiz, Sair }  //Criação do menu e seus parâmetros. Enum começa do num 0, para mudar isso precisa atribuir um numero a ele.

        static void Main(string[] args)         
        {
            bool botaoSair = false;
                while (!botaoSair) //Lê-se como: enquanto o usuario NÃO(!) escolher botaoSair, exiba o menu
                {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1-Soma   2-Subtração   3-Multiplicação   4-Divisão   5-Potência   6-Raiz   7-Sair");

                
                Menu opcao = (Menu)int.Parse(Console.ReadLine());  //Captura entrada do usuário. Declara var, transforma a entrada em int e a aplica no Menu (Cast).


                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;

                    case Menu.Subtracao:
                        Subtracao();
                        break;

                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;

                    case Menu.Divisao:
                        Divisao();
                        break;

                    case Menu.Potencia:
                        Potencia();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        botaoSair = true;
                        {
                             Environment.Exit(0);  // é uma instrução de fechamento, embora não seja necessaria aqui.
                        }
                        break;
                }
                Console.WriteLine(opcao);
                Console.Clear();
                }
        }

        static void Soma()
        {
            Console.WriteLine("SOMA DE DOIS NÚMEROS");

            Console.WriteLine("Digite um número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = num1 + num2;

            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Tecle ENTER para voltar");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("SUBTRAÇÃO DE DOIS NÚMEROS");

            Console.WriteLine("Digite um número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = num1 - num2;

            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Tecle ENTER para voltar");
            Console.ReadLine();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("MULTIPLICAÇÃO DE DOIS NÚMEROS");

            Console.WriteLine("Digite um número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = num1 * num2;

            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Tecle ENTER para voltar");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("DIVISÃO DE DOIS NÚMEROS");

            Console.WriteLine("Digite um número: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = num1 / num2;

            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Tecle ENTER para voltar");
            Console.ReadLine();     
        }

        static void Potencia()
        {
            Console.WriteLine("POTÊNCIA DE UM NÚMERO");

            Console.WriteLine("Digite a base: ");
            int basepot = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());

            double resultado = Math.Pow(basepot, expo);  // Pow é o nome do cálculo de potencia dentro da biblioteca MATH.

            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Tecle ENTER para voltar");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("RAIZ DE UM NÚMERO");

            Console.WriteLine("Digite o número: ");
            int raiz = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(raiz);

            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Tecle ENTER para voltar");
            Console.ReadLine();
        }
    }
}
