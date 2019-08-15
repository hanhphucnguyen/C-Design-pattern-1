using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Exercise_Solution
{
    //This is the composite class
    public class PetDirectory : Animal
    {
        private List<Animal> _children = new List<Animal>();

        public void ShowDetails()
        {
            foreach (var child in _children)
            {
                child.ShowDetails();
            }
        }

        public void Add(Animal animal)
        {
            if (!_children.Contains(animal))
            {
                _children.Add(animal);
            }
        }

        public void Remove(Animal animal)
        {
            _children.Remove(animal);
        }
    }
}
