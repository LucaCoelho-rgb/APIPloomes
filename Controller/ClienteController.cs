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
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Cliente>> Get()
        {
            return ClienteRepository.Buscar(0,"");
        }
        [HttpGet("{ID}")]
        public ActionResult<Cliente> Get(int ID)
        {
            return ClienteRepository.Buscar(ID).FirstOrDefault();
        }
        [HttpPost]
        public ActionResult<ReturnResponse> Post([FromBody] ClienteRequest request)
        {
            var cliente = ClienteMapper.Mapper(request);
            ClienteRepository.Gravar(cliente);

            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = $"Cadastrado com sucesso"
            };

            return retorno;
        }
        [HttpPut]
        public ActionResult<ReturnResponse> Put([FromBody] ClienteRequest request)
        {
            var cliente = ClienteMapper.Mapper(request);
            ClienteRepository.Atualizar(cliente);

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
            ClienteRepository.Delete(ID);

            var retorno = new ReturnResponse()
            {
                Code = 200,
                Message = $"Registro Deletado com sucesso"
            };

            return retorno;
        }
    }

}
