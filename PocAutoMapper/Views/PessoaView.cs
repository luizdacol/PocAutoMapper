namespace PocAutoMapper.Views
{
    public class PessoaView
    {
        public string Nome { get; set; }
        public int Altura { get; set; }
        public TelefoneView Celular { get; set; }
    }

    public class TelefoneView
    {
        public int DDD { get; set; }
        public int Numero { get; set; }
    }
}