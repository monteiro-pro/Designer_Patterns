using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class ItemBiblioteca
    {
        public int NumeroCopias { get; set; }

        public abstract void Exibe();
    }
}
