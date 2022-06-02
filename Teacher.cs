using System;

namespace MyAplication
{
    public class Teacher : Person
    {

        public Teacher(string name, int age, string teacherId, string subject) : base(name, age)
        {
            this.TeacherId = teacherId;
            this.Subject = subject;
        }
        public string TeacherId;
        public string Subject; 
    }
}
