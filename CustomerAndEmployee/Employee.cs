using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAndEmployee
{
    class Employee : Person
    {
        public override Name Name { get; set; }
        public override DateTime Birthday { get; set; }
        public Information Information { get; set; }

        public Employee(string firstName, string lastName, DateTime birthday, int id, int account) : base(firstName, lastName, birthday)
        {
            Information = new Information(id, account);
        }

        public override void DisplayPerson()
        {
            Console.WriteLine($"{Information.Id} | {Name.FirstName} {Name.LastName}");
            Console.WriteLine($"{Birthday.ToShortDateString()} {Information.SalaryAccount}");
        }
    }
}
