using System;

namespace PocAutoMapper.Entities
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
        public char Genero { get; set; }
        public DateTime Nascimento { get; set; }
    }

    public class Endereco
    {
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public string Cep { get; set; }

    }
}



