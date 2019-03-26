namespace PocAutoMapper.Entities.Negociacao
{
    public class Contrato
    {
        // public int Id { get; set; }
        public string Numero { get; set; }
        // public DateTime DataBase { get; set; }
        // public DateTime DataLiberacao { get; set; }
        public string CodigoProduto { get; set; }
        // public Cliente Cliente { get; set; }
        // public bool BlackList { get; set; }
        // public string Veiculo { get; set; }
        public int DiasAtraso { get; set; }

        public int QuantidadeParcelas { get; set; }
        public int QuantidadeParcelasPagas { get; set; }
        public int QuantidadeParcelasVencidas { get; set; }
        public int QuantidadeParcelasAVencer { get; set; }
    }
}