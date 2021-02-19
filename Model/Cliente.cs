using Dapper.Contrib.Extensions;
using System;
namespace PloomesAPI.Model
{
    [Table("Cliente")]
    public class Cliente: BaseModel
    {
        [Key]
        public int ID { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Endereco { get; set; }
        public String DtNascimento { get; set; }
    }
}
