using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_OOP_C_Sharp
{
    abstract class Person
    {
        private string firstName;
        private string lastName;
        private int personID;
        private static int count = 1;
        private DateTime birthdate;
        private string country; 

        public string Name1
        {
            get{
                return firstName;
            }
            set{
                firstName = value;
            }
        }

        public string NameL
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value; 
            }
        }

        public int ID
        {
            get
            {
                return personID; 
            }
            set
            {
                personID = value; 
            }
        }

        public DateTime birth
        {
            get
            {
                return birthdate;
            }
            set
            {
                birthdate = value; 
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value; 
            }
        }

        public Person(String firstName, String lastName, DateTime birth, String country)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ID = count++;
            this.birth = birthdate;
            this.country = country;
        }

        public virtual String getName()
        {
            return this.firstName + this.lastName;
        }

        public int getID()
        {
            return this.ID;
        }

        public abstract String DoSomething();
    }
}
