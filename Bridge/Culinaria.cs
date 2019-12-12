using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Culinaria : ICanal
    {
        public string Canal()
        {
            return ("Sintonizado no Canal de Culinária");
        }

        public string Status()
        {
            return ("Você está assistindo - Master Chefe");
        }
    }
}
