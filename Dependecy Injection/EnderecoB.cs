using System;

namespace Dependecy_Injection
{
    public class EnderecoB : IObjetoEndereco
    {
        public String Cidade { get; set; }
        public String UF { get; set; }
    }
}
