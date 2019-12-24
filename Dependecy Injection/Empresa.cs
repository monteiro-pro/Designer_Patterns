using System;

namespace Dependecy_Injection
{
    public class Empresa
    {
        public int Codigo { get; set; }
        public String RazaoSocial { get; set; }
        public IObjetoEndereco Endereco { get; private set; }

        public Empresa(IObjetoEndereco objeto)
        {
            this.Endereco = objeto;
        }
    }
}
