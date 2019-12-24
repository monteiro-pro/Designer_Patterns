using System;

namespace Dependecy_Injection
{
    public class Empresa2
    {
        public int Codigo { get; set; }
        public String RazaoSocial { get; set; }

        private IObjetoEndereco _endereco;

        public IObjetoEndereco Endereco 
        { 
            get { return _endereco; } 
            set { _endereco = value; } 
        }
    }
}
