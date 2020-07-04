using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjetoWhats
{
    public class Agenda : IAgenda
    {
        List<Contato> contatos = new List<Contato>();
        public string Nome { get; set; }
        public string Telefone { get; set; }
        private string PATH = @"Database/Agenda.csv";

        public Agenda()
        {
           string pasta = PATH.Split('/')[0];
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            } 
            
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }


        //Adicionar Novo Contato
        public void AdicionarContato(Contato cont)
        {
            contatos.Add(cont);
            string[] linhas = new string[] { prepararLinhaCSV(cont) };
            File.AppendAllLines(PATH, linhas);

        }

    
        //Deletar Contato
        public void Deletar(string _Nome)
        {
            List<string> linhas = new List<string>();
            using (StreamReader arquivo = new StreamReader(PATH))
            {
                string linha;
                while ((linha = arquivo.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
            }

            linhas.RemoveAll(z => z.Split(";")[1].Contains(_Nome));

        }

        //Listar Contatos
        public void Listar(Contato cont)
        {
            List<Contato> agenda = new List<Contato>();

            foreach(Contato c in contatos)
            {

                System.Console.WriteLine($"{cont.Nome} - {cont.Telefone}");

                agenda.Add(c);
            }
            agenda = agenda.OrderBy(z => z.Nome).ToList();
        }


        //Preparar LinhaCSV
        private string prepararLinhaCSV( Contato c)
        {
            return $"Nome do contato :{c.Nome} \n - Telefone do contato {c.Telefone}"; 
        }
    }
}