using Dapper.Contrib.Extensions;
using System;
namespace PloomesAPI.Model
{
    [Table("Produto")]
    public class Produto: BaseModel
    {
        [Key]
        public int ID { get; set; }
        public String Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
