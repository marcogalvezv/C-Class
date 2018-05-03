using System;
using System.Collections.Generic;
using System.Text;


namespace Exceptions
{
    class CarIsDeadException: System.Exception
    {
        public CarIsDeadException() {
        }
        public CarIsDeadException(string message) : base(message) { }
        public CarIsDeadException(string message,
        System.Exception inner)
        : base(message, inner) { }        

    }
}
