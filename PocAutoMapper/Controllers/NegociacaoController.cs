using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PocAutoMapper.Entities.Negociacao;
using PocAutoMapper.Views.Negociacao;

namespace PocAutoMapper.Controllers
{
    [Route("negociacao")]
    public class NegociacaoController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetNegociacao()
        {
            var negociacao = new Negociacao()
            {
                Contrato = new Contrato()
                {
                    CodigoProduto = "123456",
                    DiasAtraso = 70,
                    Numero = "123456789",
                    QuantidadeParcelas = 24,
                    QuantidadeParcelasAVencer = 10,
                    QuantidadeParcelasPagas = 12,
                    QuantidadeParcelasVencidas = 2,
                },
                Campanha = new Campanha("NomeCampanha", "DescricaoCampanha", DateTime.Today.AddDays(10)),
                Orientacao = "Orientacoes",
                Honorarios = 100.00,
                Ofertas = new List<Oferta>()
                {
                    new Oferta()
                    {
                        Data = DateTime.Today,
                        Quitacao = new Pagamento()
                        {
                            ValorMinimo = 500.0,
                            ValorOferta = 1000.0,
                            ValorOriginal = 10000.0,
                            ValorParcela = 100.0,
                            DataUltimoVencimento = DateTime.Today.AddMonths(2),
                            ParcelasContrato=new string[1]{"001"}
                        },
                        TotalEmAtraso = new Pagamento()
                        {
                            ValorMinimo = 800.0,
                            ValorOferta = 2000.0,
                            ValorOriginal = 20000.0,
                            ValorParcela = 200.0,
                            DataUltimoVencimento = DateTime.Today.AddMonths(4),
                            ParcelasContrato=new string[1]{"002"}
                        },ParciaisAVencer=new List<Pagamento>(){
                            new Pagamento(){
                                ValorMinimo = 400.0,
                                ValorOferta = 500.0,
                                ValorOriginal = 5000.0,
                                ValorParcela = 50.0,
                                DataUltimoVencimento = DateTime.Today.AddMonths(1),
                                ParcelasContrato=new string[1]{"000"}
                            }
                        },
                        ParciaisEmAtraso=new List<Pagamento>(){
                            new Pagamento(){
                                ValorMinimo = 200.0,
                                ValorOferta = 300.0,
                                ValorOriginal = 3000.0,
                                ValorParcela = 30.0,
                                DataUltimoVencimento = DateTime.Today.AddMonths(3),
                                ParcelasContrato=new string[1]{"003"}
                            }
                        },
                        Parcelamento=new Parcelamento(){
                            ParcelasContrato= new string[1]{"001"},
                            OpcoesParcelamento=new List<OpcaoParcelamento>(){
                                new OpcaoParcelamento(){QuantidadeParcelas=3,ValorParcela=300},
                                new OpcaoParcelamento(){QuantidadeParcelas=6,ValorParcela=600},
                                new OpcaoParcelamento(){QuantidadeParcelas=9,ValorParcela=900}
                            }
                        }
                    },
                    new Oferta()
                    {
                        Data = DateTime.Today.AddMonths(1),
                        Quitacao = new Pagamento()
                        {
                            ValorMinimo = 500.0,
                            ValorOferta = 1000.0,
                            ValorOriginal = 10000.0,
                            ValorParcela = 100.0,
                            DataUltimoVencimento = DateTime.Today.AddMonths(2),
                            ParcelasContrato=new string[1]{"001"}
                        },
                        ParciaisAVencer=new List<Pagamento>(){
                            new Pagamento(){
                                ValorMinimo = 400.0,
                                ValorOferta = 500.0,
                                ValorOriginal = 5000.0,
                                ValorParcela = 50.0,
                                DataUltimoVencimento = DateTime.Today.AddMonths(1),
                                ParcelasContrato=new string[1]{"000"}
                            }
                        },
                        ParciaisEmAtraso=new List<Pagamento>(){
                            new Pagamento(){
                                ValorMinimo = 200.0,
                                ValorOferta = 300.0,
                                ValorOriginal = 3000.0,
                                ValorParcela = 30.0,
                                DataUltimoVencimento = DateTime.Today.AddMonths(3),
                                ParcelasContrato=new string[1]{"003"}
                            }
                        }
                    }
                }
            };

            var negociacaoView = Mapper.Map<Negociacao, NegociacaoView>(negociacao);

            return Ok(negociacaoView);
        }
    }
}

/*


 */
