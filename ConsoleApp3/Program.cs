using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;

            Console.WriteLine("Select an option:\n");
            Console.WriteLine("1. Add a new student\n");
            Console.WriteLine("2. Update grade\n");
            Console.WriteLine("3. Display list of students by grade\n");
            Console.WriteLine("4. Clear list of students\n");
            Console.WriteLine("5. Exit\n");
            choice = Console.ReadLine();

            if (choice != "5")
            {
                Student[] studentArray = new Student[10];

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
                    //Console.WriteLine("Index of student:");
                    //int indexValue = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("New grade:");
                    //int grade = Convert.ToInt32(Console.ReadLine());

                    //EditGrade.UpdateGrade(studentArray, indexValue, grade);

                    EditGrade.UpdateGradeStub();
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
            }
        }
    }
}
