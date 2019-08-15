using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Exercise_Solution
{
    public class ObjectAdapter : Cat
    {
        private Tiger tiger;
        public void makeSound()
        {
            tiger = new Tiger();
            tiger.roar();
        }
    }
}
