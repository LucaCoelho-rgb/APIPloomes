using Microsoft.AspNetCore.Mvc;
using PloomesAPI.Mapper;
using PloomesAPI.Model;
using PloomesAPI.Repositories;
using PloomesAPI.Requests;
using PloomesAPI.Responses;
using System.Collections.Generic;
using System.Linq;

namespace PloomesAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Produto>> Get()
        {
            return ProdutoRepository.Buscar(0,"");
        }
        [HttpGet("{ID}")]
        public ActionResult<Produto> Get(int ID)
        {
            return ProdutoRepository.Buscar(ID).FirstOrDefault();
        }
        [HttpPost]
        public ActionResult<ReturnResponse> Post([FromBody] ProdutoRequest request)
        {
            var produto = ProdutoMapper.Mapper(request);
            ProdutoRepository.Gravar(produto);

            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = $"Cadastrado com sucesso"
            };

            return retorno;
        }
        [HttpPut]
        public ActionResult<ReturnResponse> Put([FromBody] ProdutoRequest request)
        {
            var produto = ProdutoMapper.Mapper(request);
            ProdutoRepository.Atualizar(produto);

            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = $"Registro atualizado com sucesso"
            };

            return retorno;
        }
        [HttpDelete("{ID}")]
        public ActionResult<ReturnResponse> Delete(int ID)
        {
            ProdutoRepository.Delete(ID);

            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = $"Registro Deletado com sucesso"
            };

            return retorno;
        }
    }

}
