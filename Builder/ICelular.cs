using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ICelular
    {
        void BuildTela();
        void BuildSistema();
        void BuildBateria();
        void BuildCamera();

        Celular Celular { get; }
    }
}
