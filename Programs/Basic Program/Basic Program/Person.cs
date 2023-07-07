using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Person
    {
        private int age;

        public Person(int age) 
        {
            this.Age = age;
        }

        public int Age { get => age; set => age = value; }

        public void validate_age(int age)
        {
            if ((age<18) || (age>120))
            {
                throw new InvalidAgeException("Sorry, Not eligible to vote");
            }
            else
            {
                Console.WriteLine("Eligible to vote");
            }
        }
    }
}
