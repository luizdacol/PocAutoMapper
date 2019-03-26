using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PocAutoMapper.Entities;
using PocAutoMapper.Views;

namespace PocAutoMapper.Controllers
{
    [Route("aluno")]
    public class AlunoController : ControllerBase
    {

        [HttpGet]
        public ActionResult<AlunoView> GetAluno()
        {
            /* 
                Faz alguns mapeamento com logica 
            */
            // Mapper.Initialize(cfg =>
            //     cfg.CreateMap<Aluno, AlunoView>()
            //         .ForMember(av => av.Endereco, m => m.MapFrom(a => $"{a.Endereco.Rua} {a.Endereco.Cidade} - {a.Endereco.Pais}"))
            //         .ForMember(av => av.Genero, m => m.MapFrom(a => (a.Genero.Equals('M') ? "Masculino" : "Feminino")))
            //         .ForMember(av => av.Idade, a => a.MapFrom(m => DateTime.Now.Year - m.Nascimento.Year))
            // );

            var aluno = new Aluno()
            {
                Nome = "Fulano",
                Email = "fulano@yahoo.com",
                Endereco = new Entities.Endereco
                {
                    Pais = "Brasil",
                    Cidade = "Sao Paulo",
                    Rua = "Rua Projetada 100",
                    Cep = "88900-520"
                },
                Genero = 'M',
                Nascimento = new DateTime(1975, 10, 9)
            };

            var alunoView = Mapper.Map<Aluno, AlunoView>(aluno);
            return Ok(alunoView);
        }

        
    }
}