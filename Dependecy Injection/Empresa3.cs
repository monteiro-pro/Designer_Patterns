using System;

namespace Dependecy_Injection
{
    public class Empresa3 : IObjectoEnderecoIJ
    {
        public int Codigo { get; set; }
        public String RazaoSacial { get; set; }
        private IObjetoEndereco Endereco { get; set; }

        public void setEndereco(IObjetoEndereco obj)
        {
            this.Endereco = obj;
        }
    }
}
