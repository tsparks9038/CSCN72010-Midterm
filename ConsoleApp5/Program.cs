using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray = new Student[10];
            string choice = "\0";

            Console.WriteLine("Select an option:\n");
            Console.WriteLine("1. Add a new student\n");
            Console.WriteLine("2. Update grade\n");
            Console.WriteLine("3. Display list of students by grade\n");
            Console.WriteLine("4. Clear list of students\n");
            Console.WriteLine("5. Exit\n");
            choice = Console.ReadLine();

            while (choice != "5")
            {
                if (choice == "1")
                {
                    Console.WriteLine("First name:");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Last name:");
                    string lastName = Console.ReadLine();

                    StudentCreation.CreateStudent(firstName, lastName, studentArray);

                    try
                    {
                        StudentCreation.CreateStudent(firstName, lastName, studentArray);
                    }

                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("{1}\n", e.Message);
                    }
                }

                else if (choice == "2")
                {
                    Console.WriteLine("Index of student:");
                    int indexValue = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("New grade:");
                    int grade = Convert.ToInt32(Console.ReadLine());

                    EditGrade.UpdateGrade(studentArray, indexValue, grade);
                }

                else if (choice == "3")
                {
                    foreach (Student s in studentArray)
                    {
                        Console.WriteLine(s.ToString());
                    }
                }

                else
                {
                    if (studentArray != null)
                    {
                        Array.Clear(studentArray, 0, 10);
                    }

                    Console.WriteLine("Student list cleared.\n");
                }

                Console.WriteLine("Select an option:\n");
                Console.WriteLine("1. Add a new student\n");
                Console.WriteLine("2. Update grade\n");
                Console.WriteLine("3. Display list of students by grade\n");
                Console.WriteLine("4. Clear list of students\n");
                Console.WriteLine("5. Exit\n");
                choice = Console.ReadLine();
            }
        }
    }
}
