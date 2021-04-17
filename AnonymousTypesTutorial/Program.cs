using System;
using System.Linq;
using System.Collections.Generic;

namespace AnonymousTypesTutorial
{
    internal class Person
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public Gender gender { get; set; }

        public enum Gender
        {
            male=1,
            female=0
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var source = new List<Person>() { };
            source.Add(new Person() { Name="A",Height=1.1,Weight=74.2,Age=12,gender=Person.Gender.male});
            source.Add(new Person() { Name="B",Height=1.2,Weight=73.2,Age=22,gender=Person.Gender.male});
            source.Add(new Person() { Name="C",Height=1.32,Weight=54.2,Age=15,gender=Person.Gender.female});

            var sourceQuery = from per in source
                              select new { per.Name, per.Height,per.Age };
            foreach(var i in sourceQuery)
            {
                Console.WriteLine($"{i.Name} {i.Height} {i.Age}");
            }
        }
    }
}
