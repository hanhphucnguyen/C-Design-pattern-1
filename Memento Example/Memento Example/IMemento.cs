
namespace Memento_Example
{
    /// <summary>
    /// The memento interface is intentionally empty
    /// This is so that the caretaker just has to know that something IS a memento
    /// It doesn't have to know about its internals
    /// (moreo n this in Originator.cs)
    /// </summary>
    public interface IMemento {

    }
}
