using PloomesAPI.Model;
using PloomesAPI.Requests;
using PloomesAPI.Responses;

namespace PloomesAPI.Mapper
{
    public class ProdutoMapper
    {
        public static Produto Mapper(ProdutoRequest ProdutoRequest)
        {
            return new Produto()
            {
                ID = ProdutoRequest.ID,
                Descricao = ProdutoRequest.Descricao,
                Preco = ProdutoRequest.Preco,
                Quantidade = ProdutoRequest.Quantidade
            };
        }
        public static ProdutoResponse Mapper(Produto produto)
        {
            return new ProdutoResponse()
            {
                ID = produto.ID.ToString(),
                Descricao = produto.Descricao,
                Preco = produto.Preco.ToString(),
                Quantidade = produto.Quantidade.ToString()
            };
        }
    }
}
