using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediador m = new ConcreteMediador();

            ConcreteColega1 c1 = new ConcreteColega1(m);
            ConcreteColega2 c2 = new ConcreteColega2(m);

            m.Colega1 = c1;
            m.Colega2 = c2;

            c1.Enviar("Bem vindo");
            c2.Enviar("Opa, Muito Obrigado!");

            Console.ReadKey();
        }
    }
}
