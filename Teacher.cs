using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_OOP_C_Sharp
{
    class Teacher : Person
    {
        private string degree;

        public string Degree
        {
            get
            {
                return degree;
            }
            set
            {
                degree = value;
            }
        }

        public Teacher(string firstname, string lastname, DateTime birth, string country) 
            : base(firstname, lastname, birth, country)
        {
        }

        public override string DoSomething()
        {
            return "The teacher will now do something";
        }
        public void giveTest(string hardExam)
        {
            Console.WriteLine("The teacher is now giving a very hard exam.");
        }

    
    }
}
