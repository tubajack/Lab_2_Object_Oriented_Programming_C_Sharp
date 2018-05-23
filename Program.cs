using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_OOP_C_Sharp
{
    class Program
    {
        private static List<Student> MathStudents = new List<Student>();
        static DateTime robert = new DateTime(1994, 10, 6, 3, 23, 14);
        private static Teacher instructor = new Teacher("Robert", "Hernandez", robert, "Mexico");

        static void Main(string[] args)
        {
            //Teacher information
            instructor.Degree = "Baylor University";
            CreateStudents();
            Console.WriteLine("The teacher is {0} {1} from {2} with ID {3}", 
                instructor.Name1, instructor.NameL, instructor.Degree, instructor.ID);
            instructor.giveTest("This is the hardest test you will ever take");

            foreach(Student a in MathStudents)
            {
                Console.WriteLine("First Name: {0}, Last Name: {1}", a.Name1, a.NameL);
                Console.WriteLine("Graduation: {0}, ID: {1}", a.GradYear, a.getID());
                a.DoSomething();
                a.taketheExam();
            }

            DateTime ayush = new DateTime(2009, 3, 16, 8, 30, 52);
            Student newStudent = new Student("Ayush", "Chandra", ayush, "India");
            Person newPerson = newStudent;

            
        }

        private static void CreateStudents()
        {
            DateTime karthik = new DateTime(2011, 2, 14, 9, 30, 42);
            MathStudents.Add(new Student("Karthik", "Iyer", karthik, "United States"));

            DateTime namir = new DateTime(2007, 11, 12, 5, 23, 14);
            MathStudents.Add(new Student("Namir", "Media", namir, "Iran"));

            DateTime abhik = new DateTime(2002, 1, 3, 2, 34, 15);
            MathStudents.Add(new Student("Abhik", "Kumar", abhik, "Bangladesh"));
        }

        
    }
}
