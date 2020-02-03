using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var adding = true;

            while (adding)
            {
                var newStudent = new Student();

                newStudent.Name = Util.Console.Ask("student name: ");
 
                newStudent.Grade = int.Parse(Util.Console.Ask("student Grade: "));

                newStudent.Birthday = Util.Console.Ask("student Birthday: ");

                newStudent.Address = Util.Console.Ask("student Address: ");

                newStudent.Phone = int.Parse(Util.Console.Ask("student Phone number: "));

                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student count: {}", Student.Count);

                Console.WriteLine("Add another? y/n");
                if (Console.ReadLine() != "y")
                    adding = false;
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade, student.Birthday, student.Address);
            }
        }    
    }
    class Student
    {
        static public int Count = 0;

        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        private int phone;

        public int Phone
        {
            set { Phone = value;  }
        }

        public void SetPhone(int number)
        {
            phone = number;
        }


    }   
}

