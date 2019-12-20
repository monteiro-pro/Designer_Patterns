using System;

namespace Mediator
{
    public class ConcreteColega2 : Colega
    {
        public ConcreteColega2(Mediador mediador) : base(mediador)
        {
        }

        public void Enviar(string mensagem)
        {
            mediador.Enviar(mensagem, this);
        }

        public void Notificar(string mensagem)
        {
            Console.WriteLine("Mensagem  do Colega 2: " + mensagem);
        }

    }
}