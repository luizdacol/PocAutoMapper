using System;

namespace PocAutoMapper.Entities.Negociacao
{
    public class OpcaoParcelamento
    {
        public double ValorParcela { get; set; }
        public int QuantidadeParcelas { get; set; }
        public double ValorTotal
        {
            get
            {
                return Math.Round(this.ValorParcela * this.QuantidadeParcelas, 2);
            }
        }
    }
}