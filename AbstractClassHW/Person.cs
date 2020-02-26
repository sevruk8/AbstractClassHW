using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassHW
{
    abstract class Person
    {
        public string Name { get; set; }

        public abstract void SayHello();
    }
}
