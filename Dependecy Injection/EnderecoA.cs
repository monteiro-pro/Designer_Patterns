using System;

namespace Dependecy_Injection
{
    public class EnderecoA : IObjetoEndereco
    {
        public String Rua { get; set; }
        public int Numero { get; set; }
    }
}
