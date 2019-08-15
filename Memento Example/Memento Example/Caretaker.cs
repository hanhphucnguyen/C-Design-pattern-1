using System;
using System.Collections.Generic;
using System.Text;


namespace Memento_Example
{
    public class Caretaker
    {
        /// <summary>
        /// Since the caretaker doesn't care about anything other than having an IOriginator as a member,
        /// it can be used by any class that implements IOriginator, and handle any kind of Mememnto object.
        /// </summary>
        private IOriginator _originator;

        /// <summary>
        /// Uses a stack to allow for easy undoing
        /// </summary>
        private Stack<IMemento> _mementos;

        public Caretaker(IOriginator originator)
        {
            _originator = originator;
            _mementos = new Stack<IMemento>();
        }

        public void Save()
        {
            _mementos.Push(_originator.GetMemento());
        }

        public void Undo()
        {
            _originator.SetMemento(_mementos.Pop());
        }

        

    }
}
