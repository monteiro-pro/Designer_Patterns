using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAssunto s = new ConcreteAssunto();
            s.Anexar(new ConcreteObservador(s, "X"));
            s.Anexar(new ConcreteObservador(s, "Y"));
            s.Anexar(new ConcreteObservador(s, "Z"));

            s.EstadoAssunto = "ABC";
            s.Notificar();

            Console.ReadKey();
        }
    }
}
