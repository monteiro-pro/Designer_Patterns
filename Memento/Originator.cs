using System;

namespace Memento
{
    public class Originator
    {
        private string _state;

        public string State
        {
            get {return this._state; }
            set 
            {
                _state = value;
                Console.WriteLine("State = " + _state);
            }
        }

        public Memento CreateMementor()
        {
            return (new Memento(this._state));
        }

        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restaurando o estado...");
            State = memento.State;
        }
    }
}
