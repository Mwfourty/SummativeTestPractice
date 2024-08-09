namespace SummativeTestPractice
{
    internal class Program
    {
        enum Menu
        {
            AddStudentName = 1,
            ShowAllStudents,
            Exit
        }

        static void AddStudentName()
        {
            Console.Write("Enter student name: ");
            studentNames.Add(Console.ReadLine());

            Console.WriteLine("\nStudent added!");
        }

        static void ShowAllStudents()
        {
            Console.WriteLine("All students");
            Console.WriteLine();

            foreach (string studentName in studentNames)
            {
                Console.WriteLine(studentName);
            }
        }

        static void Exit()
        {
            Console.WriteLine("Thank you!");
            Environment.Exit(0);
        }

        static List<string> studentNames = new List<string>(); // Global list
        static void Main(string[] args)
        {
            Menu option = new Menu();
           
            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Add student name");
                Console.WriteLine("2. Show all student names");
                Console.WriteLine("3. Exit");
                Console.WriteLine();

                Console.Write("Choose option: ");
                option = (Menu)int.Parse(Console.ReadLine());

                switch (option)
                {
                    case Menu.AddStudentName:
                        AddStudentName();
                        break;

                    case Menu.ShowAllStudents:
                        ShowAllStudents();
                        break;

                    case Menu.Exit:
                        Exit();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid option");
                        break;
                }

            } while (option != Menu.Exit);

            Console.ReadKey();
        }
    }
}
