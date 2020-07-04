namespace ProjetoWhats
{
    public class Mensagem
    {
        public string Texto { get; set; }
        public string Destinatario { get; set; }
        public void Enviar()
        {
            System.Console.WriteLine("Enviar mensagem para: "+ Destinatario );
        }
    }
}