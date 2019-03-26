using System.Collections.Generic;

namespace PocAutoMapper.Views.Negociacao
{
    public class OfertaView
    {
        public string DataVencimento { get; set; }
        public PagamentoView Quitacao { get; set; }
        public List<PagamentoView> ParciaisEmAtraso { get; set; }
        public List<PagamentoView> ParciaisAVencer { get; set; }
        public PagamentoView TotalEmAtraso { get; set; }
        public ParcelamentoView Parcelamento { get; set; }
    }
}