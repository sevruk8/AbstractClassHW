using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassHW
{
    class Russian : Person
    {
        public Russian(string name)
        {
            Name = name;
        }
        public override void SayHello() 
        {
            Console.WriteLine(Name + " говорит: Привет!");
        }
    }

}
