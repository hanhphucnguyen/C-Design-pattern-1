using System;

namespace Singleton
{
    /// <summary>
    /// Class demonstrates the simplest version of a Singleton, with a 
    /// single private instance member, hidden ctor, and static access 
    /// to the member instance.
    /// </summary>
    class Singleton
    {
        private static Singleton _instance;

        /// <summary>
        /// Private to prevent instantiation of Singletons outside this class.
        /// </summary>
        private Singleton()
        {
            Console.WriteLine("Creating Singleton instance");
        }

        /// <summary>
        /// Returns a reference to the internal instance of the class.
        /// If the internal instance is null, constructs it.
        /// </summary>
        /// <returns>Reference to internal Singleton instance</returns>
        public static Singleton GetInstance()
        {
            Console.WriteLine("Singleton.GetInstance() called");

            if (_instance == null)
            {
                // The ctor is only accessible from insde this class.
                // Thus, this is the only way to create a Singleton.
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
