using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("ROOT");
            root.Adicionar(new Folha("Folha A"));
            root.Adicionar(new Folha("Folha B"));

            Composite comp = new Composite("Composite X");
            comp.Adicionar(new Folha("Folha AX"));
            comp.Adicionar(new Folha("Folha BX"));

            root.Adicionar(comp);
            root.Adicionar(new Folha("Folha C"));

            Folha folha = new Folha("Folha D");
            root.Adicionar(folha);
            root.Remover(folha);

            root.Mostrar(1);

            Console.ReadKey();
        }
    }
}
