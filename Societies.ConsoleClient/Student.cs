namespace Societies.ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //properties
    public partial class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int FacNumber { get; set; }
    }

    //constructors
    public partial class Student
    {
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    //methods
    public partial class Student
    {
        public void GoToSchool()
        {
            Console.WriteLine("I am going to school.");
        }

        public void GoBackHome()
        {
            Console.WriteLine("I am going back home.");
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Age}";
        }
    }
}
