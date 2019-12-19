namespace Command
{
    public abstract class Command
    {
        protected Receiver Receiver;

        public Command(Receiver receiver)
        {
            this.Receiver = receiver;
        }

        public abstract void Execute();
    }
}
