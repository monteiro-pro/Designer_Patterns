using System;

namespace Observer
{
    public class ConcreteObservador : Observador
    {
        private string _nome;
        private string _estadoObservador;
        private ConcreteAssunto _assunto;

        public ConcreteObservador(ConcreteAssunto assunto, string nome)
        {
            this._assunto = assunto;
            this._nome = nome;
        }

        public override void Update()
        {
            this._estadoObservador = _assunto.EstadoAssunto;
            Console.WriteLine("Observador {0}: Seu novo estado é: {1}", this._nome, this._estadoObservador);
        }

        public ConcreteAssunto Assunto { get; set; }

    }
}
