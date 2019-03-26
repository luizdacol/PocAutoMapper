using System;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using PocAutoMapper.Entities;
using PocAutoMapper.Entities.Negociacao;
using PocAutoMapper.Views;
using PocAutoMapper.Views.Negociacao;

namespace PocAutoMapper
{
    public static class AutoMapperExtensions
    {
        // public static void ConfigureAutoMapper(IMapperConfigurationExpression c)
        // {
        //     c.MapAlunoToAlunoView();
        //     c.MapPessoaToPessoaView();
        // }
        // public static void ConfigureAutoMapper(this IServiceCollection service)
        // {
        // Mapper.Initialize(teste);

        // Mapper.Initialize(cfg =>
        // {
        //     cfg.MapAlunoToAlunoView();
        //     cfg.MapPessoaToPessoaView();
        // });
        // }

        public static void MapAlunoToAlunoView(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Aluno, AlunoView>()
                .ForMember(av => av.Endereco, m => m.MapFrom(a => $"{a.Endereco.Rua} {a.Endereco.Cidade} - {a.Endereco.Pais}"))
                .ForMember(av => av.Genero, m => m.MapFrom(a => (a.Genero.Equals('M') ? "Masculino" : "Feminino")))
                .ForMember(av => av.Idade, a => a.MapFrom(m => DateTime.Now.Year - m.Nascimento.Year));
        }

        public static void MapPessoaToPessoaView(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Pessoa, PessoaView>();
        }

        public static void MapNegociacaoToNegociacaoView(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Negociacao, NegociacaoView>();
            cfg.CreateMap<Oferta, OfertaView>()
                .ForMember(o => o.DataVencimento, m => m.MapFrom(a => a.Data.ToString("yyyy-MM-dd")));
            cfg.CreateMap<Pagamento, PagamentoView>();
        }
    }
}