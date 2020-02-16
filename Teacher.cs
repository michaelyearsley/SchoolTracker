using System;

namespace SchoolTracker
{
    class Teacher : Member, IPayee
    {

        public string Subject;

        public void Pay()
        {
            Console.WriteLine("Paying teacher");
        }
    }
}
