using Dapper.Contrib.Extensions;
using System;
namespace PloomesAPI.Model
{
    [Table("Produto")]
    public class ProdutoResponse: BaseModel
    {
        [Key]
        public String ID { get; set; }
        public String Descricao { get; set; }
        public String Preco { get; set; }
        public String Quantidade { get; set; }
    }
}
