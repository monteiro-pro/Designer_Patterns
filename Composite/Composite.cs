using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Composite : Componente
    {
        private List<Componente> filhos = new List<Componente>();
        public Composite(string nome) : base(nome)
        {

        }

        public override void Adicionar(Componente c)
        {
            this.filhos.Add(c);
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new String('-', profundidade) + Nome);

            foreach (Componente item in this.filhos)
            {
                item.Mostrar(profundidade + 2);
            }
        }

        public override void Remover(Componente c)
        {
            this.filhos.Remove(c);
        }
    }
}
