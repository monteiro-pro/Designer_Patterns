namespace Mediator
{
    public class ConcreteMediador : Mediador
    {
        private ConcreteColega1 _colega1;
        private ConcreteColega2 _colega2;

        public ConcreteColega1 Colega1
        {
            set { _colega1 = value; }
        }

        public ConcreteColega2 Colega2
        {
            set { _colega2 = value; }
        }

        public override void Enviar(string mensagem, Colega colega)
        {
            if (colega == _colega1)
                _colega2.Notificar(mensagem);
            else
                _colega1.Notificar(mensagem);
        }
    }
}
