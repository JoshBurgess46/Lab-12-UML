using System;
using System.Collections.Generic;

namespace Lab_12_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Staff("University of Toledo",25000,"bob","123 main st"),
                new Student("Law",2,11000,"Tim","123 main st")
            };
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }
        }
    }
}
