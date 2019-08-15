using System;
using System.Collections.Generic;
using System.Text;

namespace Memento_Example
{
    public class Originator : IOriginator
    {
        /// <summary>
        /// In the textbook, the pattern is written in C++, and uses the "friend" keyword
        /// to allow the Originator to see the Memento's private members. This is done so
        /// that Caretakers don't have to know anything about the internal state of a Memento.
        /// 
        /// In C#, there is no "friend" keyword. Thus, if we implement the empty IMememnto
        /// interface as a private class internal to our concrete Originator, then we can see
        /// all of its public members, but no other class can.
        /// </summary>
        private class Memento : IMemento
        {
            public Guid Id;
        }

        private Guid _id;

        public Originator()
        {
            _id = Guid.NewGuid();
            Console.WriteLine($"Starting ID: {_id}");
            Console.WriteLine();
        }

        /// <summary>
        /// Updates the ID to a random GUID
        /// </summary>
        public void UpdateId()
        {
            Console.WriteLine("Updating Id...");
            _id = Guid.NewGuid();
            Console.WriteLine($"ID is now {_id}");
            Console.WriteLine();
        }

        /// <summary>
        /// We'll set some values when returning a memento, for demonstration purposes
        /// </summary>
        /// <returns></returns>
        public IMemento GetMemento()
        {
            var memento = new Memento();
            memento.Id = _id;

            Console.WriteLine("Creating Memento...");
            Console.WriteLine();

            return memento;
        }

        /// <summary>
        /// Resets the internal ID to some previous state, as long as it the Memento is of the correct type
        /// </summary>
        /// <param name="memento">The state to reset back to</param>
        public void SetMemento(IMemento memento)
        {
            if (!(memento is Memento))
            {
                return;
            }
            Console.WriteLine("Restting ID...");
            _id = (memento as Memento).Id;
            Console.WriteLine($"ID is reset to {_id}");
            Console.WriteLine();
        }

    }
}
