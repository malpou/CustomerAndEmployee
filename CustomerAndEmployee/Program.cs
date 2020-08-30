using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerAndEmployee
{
    class Program
    {
        /*
         * - Der skal laves en liste af Customers som kan sorteres efter fx. betalingsmetode (hvad den sorteres på er valgfrit).
         * - Der skal laves en liste af Employees som kan sorteres efter fx. medarbejder ID (hvad den sorteres på er valgfrit).
         */

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee("Employee", "A", new DateTime(2000, 10, 10), 1, 123456),
                new Employee("Employee", "B", new DateTime(2000, 10, 10), 5, 123456),
                new Employee("Employee", "C", new DateTime(2000, 10, 10), 3, 123456),
                new Employee("Employee", "D", new DateTime(2000, 10, 10), 2, 123456),
                new Employee("Employee", "E", new DateTime(2000, 10, 10), 4, 123456)
            };

            List<Customer> customers = new List<Customer>
            {
                new Customer("Customer", "A", new DateTime(2000, 10, 10), Customer.PaymentMethods.Cash),
                new Customer("Customer", "B", new DateTime(2000, 10, 10), Customer.PaymentMethods.MobilePay),
                new Customer("Customer", "C", new DateTime(2000, 10, 10), Customer.PaymentMethods.Cash),
                new Customer("Customer", "D", new DateTime(2000, 10, 10), Customer.PaymentMethods.Card),
                new Customer("Customer", "E", new DateTime(2000, 10, 10), Customer.PaymentMethods.MobilePay)
            };


            employees = employees.OrderBy(id => id.Information.Id).ToList();
            customers = customers.OrderBy(method => method.PaymentMethod).ThenBy(ln => ln.Name.LastName).ToList();

            Console.WriteLine("Sorted by ID");
            foreach (var employee in employees)
            {
                employee.DisplayPerson();
            }

            Console.WriteLine("\nSorted by payment method in how modern they are, then last name");
            foreach (var customer in customers)
            {
                customer.DisplayPerson();
            }
        }
    }
}
