using System;

namespace PocAutoMapper.Entities.Negociacao
{
    public class Campanha
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataFim { get; set; }

        public Campanha(string nome, string descricao, DateTime dataFim)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.DataFim = dataFim;
        }

    }
}