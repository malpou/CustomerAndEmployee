using System;

namespace CustomerAndEmployee
{
    abstract class Person
    {
        public abstract Name Name { get; set; }
        public abstract DateTime Birthday { get; set; }
        public abstract void DisplayPerson();

        public Person(string firstName, string lastName, DateTime birthday)
        {
            Name = new Name(firstName, lastName);
            Birthday = birthday;
        }
    }
}
