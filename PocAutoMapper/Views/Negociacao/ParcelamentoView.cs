using System.Collections.Generic;

namespace PocAutoMapper.Views.Negociacao
{
    public class ParcelamentoView
    {
         public ParcelamentoView()
        {
            this.OpcoesParcelamento = new List<OpcaoParcelamentoView>();
        }

        public string[] ParcelasContrato { get; set; }
        public List<OpcaoParcelamentoView> OpcoesParcelamento { get; set; }
    }
}