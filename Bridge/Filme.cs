using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Filme : ICanal
    {
        public string Canal()
        {
            return ("Sintonizado no Canal de Filmes");
        }

        public string Status()
        {
            return ("Você está assistindo - Os Vingadores");
        }
    }
}
