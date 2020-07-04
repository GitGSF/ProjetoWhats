using System;

namespace ProjetoWhats
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem mensagem1 = new Mensagem();
            Agenda agenda = new Agenda();
            
            Contato contato1 = new Contato();
            contato1.Ident = "1";
            contato1.Nome = "Bot1";
            contato1.Telefone = "number1234";
            agenda.AdicionarContato(contato1);
            
            Contato contato2 = new Contato();
            contato2.Ident = "2";

            contato2.Nome = "Bot2";

            contato2.Telefone = "number5678";  
            
            agenda.AdicionarContato(contato2);   
            
            System.Console.WriteLine("para quem deseja enviar uma mensagem?");
            agenda.Listar(contato2);
            

            
            mensagem1.Destinatario = Console.ReadLine();
            mensagem1.Enviar();
            

        }
    }
}
