using System;

namespace Dependecy_Injection
{
    public class Empresa4
    {
        public int Codigo { get; set; }
        public String RazaoSocial { get; set; }
        public IObjetoEndereco Endereco { get; set; }

        public Empresa4()
        {
            this.Endereco = Localizador.getEndereco();
        }
    }
}
