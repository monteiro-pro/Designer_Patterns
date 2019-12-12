using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Documentario : ICanal
    {
        public string Canal()
        {
            return ("Sintonizado no Canal de Documentários");
        }

        public string Status()
        {
            return ("Você está assistindo - O Dominador de Tubarões");
        }
    }
}
