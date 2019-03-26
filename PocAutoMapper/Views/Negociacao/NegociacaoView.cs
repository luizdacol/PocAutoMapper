using System.Collections.Generic;

namespace PocAutoMapper.Views.Negociacao
{
    public class NegociacaoView
    {
        public NegociacaoView()
        {
            this.Ofertas = new List<OfertaView>();
        }

        public ContratoView Contrato { get; set; }
        public CampanhaView Campanha { get; set; }
        public List<OfertaView> Ofertas { get; set; }
        public string Orientacao { get; set; }
        public double Honorarios { get; set; }
    }
}