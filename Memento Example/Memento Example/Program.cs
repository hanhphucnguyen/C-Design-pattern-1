using System;
using System.Collections.Generic;
using System.Text;

namespace Memento_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var originator = new Originator();
            var caretaker = new Caretaker(originator);
            caretaker.Save();
            Console.WriteLine("After the first save, the originator's first ID is saved as a memento and pushed on the caretaker's stack. Enter any input to continue.");
            Console.ReadLine();
            originator.UpdateId();
            originator.UpdateId();
            caretaker.Save();
            Console.WriteLine("After two updates and a save, only the second update is saved as a memento and pushed on the caretaker's stack. Enter any input to continue.");
            Console.ReadLine();
            originator.UpdateId();
            caretaker.Undo();
            Console.WriteLine("After this latest update, since we called Undo() the ID will be changed from the latest updated ID to the prior one (i.e. the latest one that was actually saved to the stack). This is the main point of memento. Enter any input to continue.");
            Console.ReadLine();
            originator.UpdateId();
            caretaker.Save();
            Console.WriteLine("A new ID is updated and pushed onto the stack. Enter any input to continue.");
            Console.ReadLine();
            originator.UpdateId();
            caretaker.Undo();
            caretaker.Undo();
            Console.WriteLine("Although the ID was updated again, we called Undo() twice this time. This means that the final ID is the second last one that was actually pushed on the stack (i.e. our first ID).");

        }
    }
}
