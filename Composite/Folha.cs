using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Folha : Componente
    {
        public Folha(string nome) : base(nome)
        {
                
        }

        public override void Adicionar(Componente c)
        {
            Console.WriteLine("Não é possível adicionar!");
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new String('-', profundidade) + Nome);
        }

        public override void Remover(Componente c)
        {
            Console.WriteLine("Não é possível remover!");
        }
    }
}
