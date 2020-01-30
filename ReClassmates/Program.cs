using System;
using System.Collections.Generic;
using System.Text;

namespace ReClassmates
{
    class Program
    {
        static void Main(string[] args)
        {
            bool moreStudent = true;
            bool moreProgram = true;
            bool moreCreate = true;

            List<Student> students = new List<Student>();
            Student s0 = new Student("Ryan", "O'Hagan", "West Bloomfield", "sushi", 32);
            Student s1 = new Student("Joe", "Hertz", "Southfield", "pizza", 22);
            Student s2 = new Student("A-Aron", "O'Shaughnessy", "Wixom", "burgers", 18);
            Student s3 = new Student("Jay-Quellin", "Smith", "Hoboken", "pasta", 26);

            students.Add(s0);
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the Student Portal");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            int create = Methods.CheckRange(int.Parse(Methods.GetUserInput("Press 1 to add a new student or 2 to look up a student")), 1, 2);
            if(create == 1)                
            {
                while(moreCreate)
                {
                    string first = Methods.GetUserInput("What is the students first name?");
                    string last = Methods.GetUserInput("What is the students last name?");
                    string live = Methods.GetUserInput("What is the students home town?");
                    string eat = Methods.GetUserInput("What is the students favorite food?");
                    int old = int.Parse(Methods.GetUserInput("How old is the student?"));
                    string place = $"s{students.Count + 1}";
                    Student s4 = new Student(first, last, live, eat, old);
                    students.Add(s4);
                    moreCreate = Methods.ValidateInput("Would you like to add another student?");
                }
            }
            else
            {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Connecting to Database");
            }

            students.Sort((x, y) => string.Compare(x.LastName, y.LastName));

            while(moreProgram)
            {
                moreStudent = true;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Welcome to the Student Directory");
                Console.ResetColor();

                foreach(Student s in students)
                {
                    Console.WriteLine((students.IndexOf(s) + 1) + ". " + s.FirstName + " " + s.LastName);
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                int choice1 = Methods.CheckRange(int.Parse(Methods.GetUserInput($"Which student would you like to know more about? (1-{students.Count})")), 1, students.Count);

                while(moreStudent)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("What information would you like?");
                    Console.ResetColor();
                    int choice2 = Methods.CheckRange(int.Parse(Methods.GetUserInput("1. Age\n2. Home Town\n3. Favorite Food")), 1, 3);

                    if(choice2 == 1)
                    {
                        Console.WriteLine($"{students[choice1 - 1].FirstName} is {students[choice1 - 1].Age} years old");
                    }
                    if(choice2 == 2)
                    {
                        Console.WriteLine($"{students[choice1 - 1].FirstName}'s home town is {students[choice1 - 1].HomeTown}");
                    }
                    if(choice2 == 3)
                    {
                        Console.WriteLine($"{students[choice1 - 1].FirstName}'s favorite food is {students[choice1 -1].FavFood}");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    moreStudent = Methods.ValidateInput($"Would you like to learn more about {students[choice1 - 1].FirstName}?");
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                moreProgram = Methods.ValidateInput("Would you like to learn about another student?");
            }
        }
    }
}
