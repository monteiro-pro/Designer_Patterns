using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Fabricar
    {
        public Fabricar(ICelular celularBuilder)
        {
            celularBuilder.BuildTela();
            celularBuilder.BuildCamera();
            celularBuilder.BuildBateria();
            celularBuilder.BuildTela();
            celularBuilder.BuildSistema();
        }
    }
}
