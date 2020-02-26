using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassHW
{
    class Ukrainian : Person
    {
        public Ukrainian(string name)
        {
            Name = name;
        }

        public override void SayHello()
        {
            Console.WriteLine(Name + " говорить: Привіт!");
        }
    }
}
