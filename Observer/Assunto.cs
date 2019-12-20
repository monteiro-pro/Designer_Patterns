using System.Collections.Generic;

namespace Observer
{
    public abstract class Assunto
    {
        private List<Observador> _observador = new List<Observador>();

        public void Anexar(Observador observador)
        {
            this._observador.Add(observador);
        }

        public void Desanexar(Observador observador)
        {
            this._observador.Remove(observador);
        }

        public void Notificar()
        {
            foreach (Observador item in this._observador)
            {
                item.Update();
            }
        }
    }
}
