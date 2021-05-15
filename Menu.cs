using System;

namespace ConsoleApp1
{
    class Program
    { 
        enum Menu { Criar = 1, Atualizar, Deletar, Listar }
    
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("1 - Criar    2 - Atualizar    3 - Deletar    4 - Listar");

            int opcoes = int.Parse(Console.ReadLine());
            Menu opcaoSelecionada = (Menu)opcoes;


            switch(opcaoSelecionada)
            {
                case Menu.Criar:
                    Console.WriteLine("Criar um novo artigo?");
                    break;

                case Menu.Atualizar:
                    Console.WriteLine("Atualizar um artigo?");
                    break;

                case Menu.Deletar:
                    Console.WriteLine("Deletar um artigo?");
                    break;

                case Menu.Listar:
                    Console.WriteLine("Listar todos os artigos?");
                    break;

                default:
                    Console.WriteLine("Opção não encontrada");
                    break;

                    Console.ReadLine();
            }


        }
    }
}
