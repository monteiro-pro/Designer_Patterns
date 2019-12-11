using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class FuncionarioPermanente : IFuncionario
    {
        public int Idade { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }

        public IFuncionario Clone()
        {
            return this.MemberwiseClone() as IFuncionario;
        }
    }
}
