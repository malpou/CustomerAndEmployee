using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAndEmployee
{
    class Customer : Person
    {
        public override Name Name { get; set; }
        public override DateTime Birthday { get; set; }
        public PaymentMethods PaymentMethod  { get; set; }

        public Customer(string firstName, string lastName, DateTime birthday,PaymentMethods paymentMethod) : base(firstName, lastName, birthday)
        {
            PaymentMethod = paymentMethod;
        }

        public override void DisplayPerson()
        {
            Console.WriteLine($"{Name.FirstName} {Name.LastName}");
            Console.WriteLine($"{Birthday.ToShortDateString()} | {PaymentMethod}");
        }

        public enum PaymentMethods
        {
            MobilePay,
            Card,
            Cash,
        }
    }
}
