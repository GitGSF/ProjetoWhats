namespace ProjetoWhats
{
    public class Contato
    {
        public string Ident { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Contato(){

        }

        public Contato(string _nome, string _telefone , string _ident){
            this.Nome  = _nome;
            this.Telefone = _telefone;
            this.Ident =_ident;
        
        }
    }
}