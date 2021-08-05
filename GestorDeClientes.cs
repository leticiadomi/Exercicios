using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GestorDeClientes
{
    class Program
    {
        [System.Serializable]  //Permitirá que os dados da lista sejam salvos em arquivos
        struct Cliente
        {
            public string nome;
            public string email;              //semelhante ao interface
            public int cpf; //******
        }
        static List<Cliente> clientes = new List<Cliente>();

        enum Menu { Listagem = 1, Adicionar, Remover, Sair }
        static void Main(string[] args)
        {
            Carregar();
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Sistema de Clientes");
                Console.WriteLine("1 - Listagem     2 - Adicionar    3 - Remover     4 - Sair");
                int opcao = int.Parse(Console.ReadLine());
                Menu opcaoEscolhida = (Menu)opcao;

                switch (opcaoEscolhida)
                {
                    case Menu.Listagem:
                        Listagem();
                        break;
                    case Menu.Adicionar:
                        Adicionar();
                        break;
                    case Menu.Remover:
                        Remover();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                Console.Clear();
            }
        }

        static void Adicionar()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Cadastro de cliente");
            Console.WriteLine("Nome do cliente: ");
            cliente.nome = Console.ReadLine();
            Console.WriteLine("Email do cliente: ");
            cliente.email = Console.ReadLine();
            Console.WriteLine("CPF: ");
            cliente.cpf = int.Parse(Console.ReadLine());

            if (cliente.email.Contains("@") && cliente.email.Contains(".com") && cliente.cpf.ToString().Length == 11)
            {
                //adiciona à lista clientes a variavel cliente
                clientes.Add(cliente);
                Salvar();
                Console.WriteLine("Cadastro Realizado!");
                Console.WriteLine("Tecle ENTER para sair");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Dados inválidos, tente novamente");
                Console.WriteLine("Tecle ENTER para sair");
                Console.ReadLine();

            }
        }

        static void Listagem()
        {
            // se a quantidade de elementos de clientes for maior que zero...
            if (clientes.Count > 0)  //Count pode ser usado apenas em listas
            {
                int id = 0;
                Console.WriteLine("Lista de Clientes");
                foreach (Cliente cliente in clientes)
                {

                    Console.WriteLine($"ID: {id}");
                    Console.WriteLine($"Nome: {cliente.nome}");
                    Console.WriteLine($"Email: {cliente.email}");
                    Console.WriteLine($"CPF: {cliente.cpf}");
                    Console.WriteLine("--------------------------------------------------------------------");
                    id++;
                }
            }
            else
            {
                Console.WriteLine("Nenhum cliente cadastrado");
            }
            Console.WriteLine("Aperte ENTER para sair");
            Console.ReadLine();
        }

        static void Salvar()
        {
            // cria um novo fileStream chamado stream, que terá extensão .bat, e o modo de arquivo é "abrir ou criar"
            FileStream stream = new FileStream("clientes.bat", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, clientes);
            stream.Close();
        }

        static void Carregar()
        {
            FileStream stream = new FileStream("clientes.bat", FileMode.OpenOrCreate);

            try
            {
                BinaryFormatter encoder = new BinaryFormatter();

                clientes = (List<Cliente>)encoder.Deserialize(stream);
                if (clientes == null)
                {
                    clientes = new List<Cliente>();
                }
            }
            catch (Exception e)
            {
                clientes = new List<Cliente>();
            }
            stream.Close();
        }

        static void Remover()
        {
            Console.WriteLine("Digite o ID do cliente que você deseja remover ");
            int id = int.Parse(Console.ReadLine());

            if (id >= 0 && id < clientes.Count)
            {
                clientes.RemoveAt(id);

                Salvar();
                Console.WriteLine($"ID {id} removido com sucesso!");
                Console.WriteLine("Aperte ENTER para voltar");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("ID inválido, tente novamente");
                Console.ReadLine();
            }



        }
    }
}
