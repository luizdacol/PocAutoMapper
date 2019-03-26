namespace PocAutoMapper.Entities
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Telefone Celular { get; set; }
        
    }

    public class Telefone
    {
        public int DDD { get; set; }
        public int Numero { get; set; }
    }
}