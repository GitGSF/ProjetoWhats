using System.Collections.Generic;
namespace ProjetoWhats
{
    public interface IAgenda
    {
        void AdicionarContato(Contato cont);
        void Deletar(string _nome);
        void Listar(Contato cont);
    }
}