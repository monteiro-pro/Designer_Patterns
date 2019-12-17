using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Componente
    {
        protected string Nome;

        public Componente(string ssss)
        {
            this.Nome = ssss;
        }
        
        public abstract void Adicionar(Componente c);
        public abstract void Remover(Componente c);
        public abstract void Mostrar(int profundidade);
    }
}
