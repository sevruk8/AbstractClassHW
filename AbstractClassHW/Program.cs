using System;
using System.Collections.Generic;

namespace AbstractClassHW
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>();
            people.Add(new Russian("Петя"));
            people.Add(new Ukrainian("Петро"));
            people.Add(new English("Pete"));

            foreach (Person person in people)
                person.SayHello();

            Console.ReadKey();

        }
    }
}
