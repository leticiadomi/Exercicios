using System;

namespace ConsoleApp2
{
    class Program
    {
        public enum status { Aguardando=1 , execução , Finalizado, Cancelado}

        struct Processo
        {
            public string nome;
            public string hora;
            public dynamic status;

            public Processo(string nome, string hora, dynamic status)
            {
                this.nome = nome;
                this.hora = hora;
                this.status = status;
            }
            public void ExibirProcesso()
            {
                Console.WriteLine($"Nome: {this.nome}");
                Console.WriteLine($"Hora: {this.hora}");
                Console.WriteLine($"Status: {this.status}");
            }
        }

        static void Main(string[] args)
        {
            Processo limpar = new Processo("Limpar a Sala", "14:40", status.Aguardando);
            Processo cachorro = new Processo("Dar comida para o cachorro", "09:00", status.Finalizado);

            limpar.ExibirProcesso();
            Console.WriteLine("--------------------------------------------------------------------");
            cachorro.ExibirProcesso();
            
        }

       
    }
}
