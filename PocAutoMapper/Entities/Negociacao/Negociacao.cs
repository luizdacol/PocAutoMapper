using System.Collections.Generic;

namespace PocAutoMapper.Entities.Negociacao
{
    public class Negociacao
    {
        public Negociacao()
        {
            this.Ofertas = new List<Oferta>();
        }
        public Contrato Contrato { get; set; }
        public List<Oferta> Ofertas { get; set; }
        public Campanha Campanha { get; set; }
        public string Orientacao { get; set; }
        public double Honorarios { get; set; }
    }
}