using System;

namespace MyAplication
{
    public class Person
    {
        public Person(string name,int age)
        {
           this.Name = name;
           this.Age = age; 
        }
     
        public int Age { get; set; }
        public string Name { get; set; }

        public void GetNameAndAge(){
            Console.WriteLine("The Person has name: {0} and Age: {1}", Name, Age);
        }
    }
}
