using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassHW
{
    class English :Person
    {
        public English (string name)
        {
            Name = name;
        }
        public override void SayHello()
        {
            Console.WriteLine(Name + " says: Hi!");
        }
    }
}
