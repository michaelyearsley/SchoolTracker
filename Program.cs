using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    enum School
    {
        MahoutoKorro,
        Hogwarts,
        Ilvermorny,
        CastleBruxo,
        Uagadou

    }
    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            PayRoll payroll = new PayRoll();
            payroll.PayAll();

            var adding = true;

            while (adding)
            {
                try
                {

                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("student name: ");

                    newStudent.Grade = Util.Console.AskInt("student Grade: ");

                    newStudent.School = (School) Util.Console.AskInt("School Name:Type the correspnding number: \n 0:  MahoutoKorro \n 1: Hogwarts \n 2: Ilvermorny \n 3:Castle Bruxo \n 4: Uagadou\n");

                    newStudent.Birthday = Util.Console.Ask("student Birthday: ");

                    newStudent.Address = Util.Console.Ask("student Address: ");

                    newStudent.Phone = Util.Console.AskInt("student Phone number: ");

                    students.Add(newStudent);
                    Student.Count++;
                    Console.WriteLine("Student count: {0}", Student.Count);

                    Console.WriteLine("Add another? y/n");
                    if (Console.ReadLine() != "y")
                        adding = false;
                }

                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {

                    Console.Write("Error, please re-enter: ");
                }
            }
            foreach (var student in students)
            {
                Console.WriteLine("Name: {0} lives at {3} and was born on: {2} his/her Grade is: {1}", student.Name, student.Grade, student.Birthday, student.Address);
            }
            Exports();
        }
        static void Import()
        {
            var importedStudent = new Student("Jenny", 86, "birthday", "address", 123456);
            Console.WriteLine(importedStudent.Name);
        }
        static void Exports()
        {
            foreach (var student in students)
            {
                switch(student.School)
                {
                    case School.MahoutoKorro:
                        Console.WriteLine("Exporting to MahoutoKorro");
                        break;
                    case School.Hogwarts:
                        Console.WriteLine("Exporting to Hogwarts");
                        break;
                    case School.Ilvermorny:
                        Console.WriteLine("Exporting to Ilvermorny");
                        break;
                    case School.CastleBruxo:
                        Console.WriteLine("Exporting to CastleBruxo");
                        break;
                    case School.Uagadou: 
                        Console.WriteLine("Exporting to Uagadou");
                        break;
                }
            }
        }
    }
    class Member
    {
        public string Name;
        public string Address;
        protected int phone;

        public int Phone
        {
            set { phone = value; }
        }
    }

    class Student : Member
    {
        static public int Count = 0;

        public int Grade;
        public string Birthday;
        public School School;

        public Student()
        {

        }

        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
    }

}

