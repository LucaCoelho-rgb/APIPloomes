using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PloomesAPI.Responses
{
    public class ClienteResponse
    {
        public String ID { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Endereco { get; set; }
        public String DtNascimento { get; set; }
    }
}
