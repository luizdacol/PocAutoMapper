using AutoMapper;
using PocAutoMapper.Entities;
using PocAutoMapper.Views;
using NUnit.Framework;

namespace TestAutoMapper.Test
{
    public class PessoaTest
    {
        [Test]
        public void AutoMapper_Configuration_IsValid()
        {
            Mapper.Initialize(m => m.CreateMap<Pessoa, PessoaView>()
            .ForMember(x => x.Altura, y => y.MapFrom(a => a.Idade)));

            Mapper.AssertConfigurationIsValid();
        }

        [Test]
        public void AutoMapper_Configuration_NotValid()
        {
            Mapper.Initialize(m => m.CreateMap<Pessoa, PessoaView>());

            //Teste quebrado
            Mapper.AssertConfigurationIsValid();
        }
    }
}