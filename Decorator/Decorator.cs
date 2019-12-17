using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    // Decorador Abstrato
    public class Decorator : ItemBiblioteca
    {
        protected ItemBiblioteca itemBiblioteca { get; set; }

        public Decorator(ItemBiblioteca itemBiblioteca)
        {
            this.itemBiblioteca = itemBiblioteca;
        }

        public override void Exibe()
        {
            this.itemBiblioteca.Exibe();
        }
    }
}
