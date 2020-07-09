namespace ProjetoWhats
{
    public class Mensagem
    {
        public string Texto { get; set; }
        public string Destinatario { get; set; }
        public void Enviar()
        {
            System.Console.WriteLine("Olá "+ Destinatario +",Programação Orientada a Ódio." );
            
        }
    }
}