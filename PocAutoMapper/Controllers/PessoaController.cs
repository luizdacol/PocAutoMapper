using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PocAutoMapper.Entities;
using PocAutoMapper.Views;

namespace PocAutoMapper.Controllers
{
    [Route("pessoa")]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetPessoa()
        {
            var pessoa = new Pessoa()
            {
                Nome = "Teste",
                Idade = 20,
                Celular = new Telefone()
                {
                    DDD = 11,
                    Numero = 123456789
                }
            };

            // var config = new MapperConfiguration(cfg =>
            // {
            //     cfg.CreateMap<Pessoa, PessoaView>();
            //     // cfg.CreateMap<Telefone, TelefoneView>();
            // });

            // var mapper = config.CreateMapper();
            // var pessoaView = mapper.Map<PessoaView>(pessoa);

            var pessoaView = Mapper.Map<PessoaView>(pessoa);

            return Ok(pessoaView);
        }
    }
}