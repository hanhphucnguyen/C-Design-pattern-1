using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MediatorFanExample
{
    public class Button
    {
        private Mediator _mediator;

        public Button(Mediator mediator)
        {
            _mediator = mediator;
        }

        public void Press()
        {
            _mediator.Press();
        }
    }
}