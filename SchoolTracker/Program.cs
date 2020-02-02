using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {           
            
            var studentName = new List<String>();
            var grade = new List<int>();

            var adding = true;

            while (adding)
            {
                Console.Write("What is the student name: ");
                studentName.Add(Console.ReadLine());
                Console.Write("What is the student grade: ");
                grade.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add another? y/n");
                if (Console.ReadLine() != "y")
                    adding = false;

            }

            for (int i = 0; i < studentName.Count; i++)
            
            {
                Console.WriteLine("name:" + studentName[i] + ", "+ "grade:" + grade[i]);
            }
        }
         
    }   
}
