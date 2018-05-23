using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_OOP_C_Sharp
{
    class Student : Person
    {
        private int gradYear;

        public int GradYear{
            get{
                return gradYear;
            }
            set{
                gradYear = value;
            }
        }

        public Student(string firstname, string lastname, DateTime birth, string country) : 
            base(firstname, lastname, birth, country){
            this.Name1 = firstname;
            this.NameL = lastname; 
        }

        public void taketheExam(){
            Console.WriteLine(this.Name1 + " " + this.NameL + " is taking the exam.");
        }

        public override string DoSomething(){
            return "Something has been done by Student " + getID();
        }
    }
}
