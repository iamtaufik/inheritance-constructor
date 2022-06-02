using System;

namespace MyAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mike", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Thomas Slebew", 35, "121212", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Sara", 19, "2312", "sara@amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
