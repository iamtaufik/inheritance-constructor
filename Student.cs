using System;

namespace MyAplication
{
    public class Student : Person
    {

        public Student(string name, int age, string studentId, string email) : base(name,age)
        {
            this.StudentId = studentId;
            this.Email = email;
        }
        public string Email;
        public string StudentId;
    }
}