using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_UML
{
    class Student : Person
    {
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }

        public Student()
        {
            
        }

        public Student(string program, int year, double fee, string name, string address) : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public override string ToString()
        {
            return $"{Name}: {Address}: {Program}: {Year}: {Fee}";
        }
    }
}
