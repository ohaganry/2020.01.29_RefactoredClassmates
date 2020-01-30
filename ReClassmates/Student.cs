using System;

namespace ReClassmates
{
    public class Student
    {
        public Student(string firstName, string lastName, string home, string food, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                HomeTown = home;
                FavFood = food;
                Age = age;
                //Student s0 = new Student("Ryan", "O'Hagan", "West Bloomfield", "Sushi", 32);
                //Student s1 = new Student("Joe", "Hertz", "Southfield", "Pizza", 22);
            }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeTown { get; set; }
        public string FavFood { get; set; }
        public int Age { get; set; }
    }
}