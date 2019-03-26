namespace PocAutoMapper.Views.Negociacao
{
    public class ContratoView
    {
         public string Numero { get; set; }
        public string CodigoProduto { get; set; }
        public int DiasAtraso { get; set; }

        public int QuantidadeParcelas { get; set; }
        public int QuantidadeParcelasPagas { get; set; }
        public int QuantidadeParcelasVencidas { get; set; }
        public int QuantidadeParcelasAVencer { get; set; }
    }
}