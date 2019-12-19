namespace Iterator
{
    public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract object CurrentItem();
        public abstract bool IsDone();
    }
}
