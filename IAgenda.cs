using System.Collections.Generic;
namespace ProjetoWhats
{
    public interface IAgenda
    {
        void Listar(Contato cont);
        void AdicionarContato(Contato cont);
        void Deletar(string _nome);
    }
}