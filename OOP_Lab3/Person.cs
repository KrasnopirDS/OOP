using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    internal class Person
    {
        private string firstName, lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public virtual string View() => $"{firstName} {lastName} {age} lat";
    }
}
