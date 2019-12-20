﻿using System;

namespace Mediator
{
    public class ConcreteColega1 : Colega
    {
        public ConcreteColega1(Mediador mediador) : base(mediador)
        {
        }

        public void Enviar(string mensagem)
        {
            mediador.Enviar(mensagem, this);
        }

        public void Notificar(string mensagem)
        {
            Console.WriteLine("Mensagem  do Colega 1: " + mensagem);
        }
    }
}