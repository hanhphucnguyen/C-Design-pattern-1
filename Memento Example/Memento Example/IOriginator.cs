namespace Memento_Example
{
    public interface IOriginator
    {
        IMemento GetMemento();
        void SetMemento(IMemento memento);
    }
}
