using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Ezgi";
            person2 = person1;
            person1.FirstName = "Derin";

            Console.WriteLine(person2.FirstName);



            Customer customer = new Customer();
            customer.FirstName = "Ayşe";
            customer.CreditCardNumber = "123456789";


            Employee employee = new Employee();
            employee.FirstName = "Ahmet";

            //Console.WriteLine(((Customer).person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
        }
    }

    //base class Person
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
