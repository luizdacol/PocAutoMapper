using System;
using System.Collections.Generic;

namespace PocAutoMapper.Entities.Negociacao
{
    public class Oferta
    {
        public Oferta()
        {
            this.ParciaisEmAtraso = new List<Pagamento>();
            this.ParciaisAVencer = new List<Pagamento>();
        }
        public DateTime Data { get; set; }
        public Pagamento Quitacao { get; set; }
        public List<Pagamento> ParciaisEmAtraso { get; set; }
        public List<Pagamento> ParciaisAVencer { get; set; }
        public Pagamento TotalEmAtraso { get; set; }
        public Parcelamento Parcelamento { get; set; }
    }
}