using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ICelular celular = new BuilderAndroid();
            Fabricar fabricar = new Fabricar(celular);

            Console.Write("Celular Fabricado: ");
            Console.WriteLine(celular.Celular.Nome);
            Console.Write("Sistema: ");
            Console.WriteLine(celular.Celular.Sistema);
            Console.Write("Bateria: ");
            Console.WriteLine(celular.Celular.Bateria);
            Console.Write("Tela: ");
            Console.WriteLine(celular.Celular.Tela);
            Console.Write("Camera: ");
            Console.WriteLine(celular.Celular.Camera);

            Console.ReadKey();
        }
    }
}
