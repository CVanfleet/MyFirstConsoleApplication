using System;
namespace MyFirstConsoleApplication
{
    public class Person
    {
        public Person()
        {
            string Name, Location;
        }

        public Person(string name, string location)
        {
            Name = name;

            Location = location;
        }

        public string Name { get; set; }
        public string Location { get; set; }
    }
}

