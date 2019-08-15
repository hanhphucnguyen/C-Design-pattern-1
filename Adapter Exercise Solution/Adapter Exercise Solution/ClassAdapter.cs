using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Exercise_Solution
{
    public class ClassAdapter : Tiger, Cat
    {
        public void makeSound()
        {
            roar();
        }
    }
}
