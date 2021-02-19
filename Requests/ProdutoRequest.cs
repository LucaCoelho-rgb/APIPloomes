using Dapper.Contrib.Extensions;
using PloomesAPI.Model;
using System;
namespace PloomesAPI.Requests
{
    public class ProdutoRequest: BaseModel
    {
        public int ID { get; set; }
        public String Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
