using System;
using System.Linq;

namespace PocAutoMapper.Entities.Negociacao
{
    public class Pagamento
    {
        public Pagamento()
        {
        }

        public Pagamento(double valorCobrado, double valorOriginal, double valorParcela, DateTime dataUltimoVencimento, string[] parcelas, double valorMinimo)
        {
            this.ValorOferta = valorCobrado;
            this.ValorOriginal = valorOriginal;
            this.ValorParcela = valorParcela;
            this.DataUltimoVencimento = dataUltimoVencimento;
            this.ParcelasContrato = parcelas;
            this.ValorMinimo = valorMinimo;
        }

        public int QuantidadeParcelas { get { return Convert.ToInt32(this.ParcelasContrato?.Count() ?? 0); } }
        public double ValorOferta { get; set; }
        public double ValorOriginal { get; set; }
        public double ValorParcela { get; set; }
        public double ValorMinimo { get; set; }
        public string[] ParcelasContrato { get; set; }
        public DateTime DataUltimoVencimento { get; set; }
        public string Situacao { get { return DataUltimoVencimento < DateTime.Today ? "Atrasada" : "AVencer"; } }

        public double Desconto
        {
            get
            {
                if (this.ValorOferta < this.ValorOriginal)
                    return 1 - (this.ValorOferta / this.ValorOriginal);

                return 0;
            }
        }
    }
}