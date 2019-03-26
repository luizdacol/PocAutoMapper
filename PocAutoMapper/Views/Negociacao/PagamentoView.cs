namespace PocAutoMapper.Views.Negociacao
{
    public class PagamentoView
    {
        public int QuantidadeParcelas { get; set; }
        public double ValorOferta { get; set; }
        public double ValorOriginal { get; set; }
        public double ValorMinimo { get; set; }
        public string[] ParcelasContrato { get; set; }
        public double Desconto { get; set; }
    }
}