using System.Collections.Generic;

namespace PocAutoMapper.Entities.Negociacao
{
    public class Parcelamento
    {
        public Parcelamento()
        {
            this.OpcoesParcelamento = new List<OpcaoParcelamento>();
        }

        public Parcelamento(string[] parcelasContrato, List<OpcaoParcelamento> opcoes)
        {
            this.ParcelasContrato = parcelasContrato;
            this.OpcoesParcelamento = opcoes;
        }

        public string[] ParcelasContrato { get; set; }
        public List<OpcaoParcelamento> OpcoesParcelamento { get; set; }
    }
}