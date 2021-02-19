using PloomesAPI.Model;
using PloomesAPI.Requests;
using PloomesAPI.Responses;

namespace PloomesAPI.Mapper
{
    public class ClienteMapper
    {
        public static Cliente Mapper(ClienteRequest ClienteRequest)
        {
            return new Cliente()
            {
                ID = ClienteRequest.ID,
                Nome = ClienteRequest.Nome,
                Email = ClienteRequest.Email,
                Endereco = ClienteRequest.Endereco,
                DtNascimento = ClienteRequest.DtNascimento
            };
        }
        public static ClienteResponse Mapper(Cliente cliente)
        {
            return new ClienteResponse()
            {
                ID = cliente.ID.ToString(),
                Nome = cliente.Nome,
                Email = cliente.Email,
                Endereco = cliente.Endereco,
                DtNascimento = cliente.DtNascimento
            };
        }
    }
}
