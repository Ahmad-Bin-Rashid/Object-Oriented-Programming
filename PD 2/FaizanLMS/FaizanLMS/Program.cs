using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using FaizanLMS.BL;

namespace FaizanLMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option1 = "", option2 = "", option3 = "", name = "", username = "", rollno = "", password = "";

            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();

            while (true)
            {
                PrintHeader();
                option1 = PrintMenu();
                switch (option1)
                {
                    case "1":
                        option2 = SigninMenu();
                        switch (option2)
                        {
                            case "1":
                                StudentSigninMenu(ref username, ref password, ref rollno);
                                bool check = CheckStudent(username, students);
                                if (check)
                                {
                                    option3 = StudentMenu();
                                    switch (option3)
                                    {
                                        case "1":
                                            EnrollMenu();
                                            break;
                                        case "2":
                                            UnenrollMenu();
                                            Console.ReadKey();
                                            break;
                                        case "3":
                                            return;
                                        default:
                                            Console.WriteLine("\n\t Please Enter Valid Option!");
                                            Console.ReadKey();
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Student!");
                                    Console.ReadKey();
                                }
                                break;
                            case "2":
                                students.Add(StudentSignupMenu());
                                Console.ReadKey();
                                break;
                            case "3":
                                return;
                            default:
                                Console.WriteLine("\n\t Please Enter Valid Option!");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case "2":
                        option2 = SigninMenu();
                        switch (option2)
                        {
                            case "1":
                                TeacherSigninMenu(ref username, ref password);
                                bool check = CheckStudent(username, students);
                                if (check)
                                {
                                    option3 = TeacherMenu();
                                    switch (option3)
                                    {
                                        case "1":
                                            AddCourseMenu();
                                            break;
                                        case "2":
                                            ViewStudentsMenu(students);
                                            Console.ReadKey();
                                            break;
                                        case "3":
                                            return;
                                        default:
                                            Console.WriteLine("\n\t Please Enter Valid Option!");
                                            Console.ReadKey();
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Student!");
                                    Console.ReadKey();
                                }
                                break;
                            case "2":
                                teachers.Add(TeacherSignupMenu());
                                Console.ReadKey();
                                break;
                            case "3":
                                return;
                            default:
                                Console.WriteLine("\n\t Please Enter Valid Option!");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("\n\t Please Enter Valid Option!");
                        Console.ReadKey();
                        break;
                }
            }
        }


        static string SigninMenu()
        {
            string option = "";
            Console.WriteLine("\nSelect from following:-");
            Console.WriteLine(" 1) SignIn");
            Console.WriteLine(" 2) SignUp");
            Console.WriteLine(" 3) Exit Program");
            Console.Write("Your Option: ");
            option = Console.ReadLine();
            return option;
        }

        static void PrintHeader()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"

         ___       ___      ___   ________  
        |'  |     |'  \    /'  | /'       ) 
        ||  |      \   \  //   |(:   \___/  
        |:  |      /\\  \/.    | \___  \    
         \  |___  |: \.        |  __/  \\   
        ( \_|:  \ |.  \    /:  | /' \   :)  
         \_______)|___|\__/|___|(_______/   
                                            
");
            Console.WriteLine("\n\n");
        }

        static string PrintMenu()
        {
            string option = "";
            Console.WriteLine("\nSelect your role:-");
            Console.WriteLine(" 1) Teacher");
            Console.WriteLine(" 2) Student");
            Console.WriteLine(" 3) Exit");
            Console.Write("Your Option: ");
            option = Console.ReadLine();
            return option;
        }

        static void StudentSigninMenu(ref string username, ref string password, ref string rollno)
        {
            Console.WriteLine("\nEnter Credientails:-");
            Console.Write("\n Enter your username: ");
            username = Console.ReadLine();
            Console.Write("\n Enter your password: ");
            password = Console.ReadLine();
            Console.Write("\n Enter your Rollno: ");
            rollno = Console.ReadLine();
        }

        static bool CheckStudent(string username, List<Student> students)
        {
            for (int x = 0; x < students.Count; x++)
            {
                if (username == students[x].username)
                {
                    return true;
                }
            }
            return false;
        }

        static Student StudentSignupMenu()
        {
            Console.WriteLine("\nEnter Credientails:-");

            Console.Write("\n Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("\n Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("\n Enter your password: ");
            string password = Console.ReadLine();
            Console.Write("\n Enter your Rollno: ");
            string rollno = Console.ReadLine();
            Student s = new Student(name, username, password, rollno);
            return s;
        }

        static void TeacherSigninMenu(ref string username, ref string password)
        {
            Console.WriteLine("\nEnter Credientails:-");
            Console.Write("\n Enter your username: ");
            username = Console.ReadLine();
            Console.Write("\n Enter your password: ");
            password = Console.ReadLine();
        }

        static Teacher TeacherSignupMenu()
        {
            Console.WriteLine("\nEnter Credientails:-");

            Console.Write("\n Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("\n Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("\n Enter your password: ");
            string password = Console.ReadLine();
            Console.Write("\n Enter your Rollno: ");
            string rollno = Console.ReadLine();
            Teacher t = new Teacher(name, username, password);
            return t;
        }

        static string TeacherMenu()
        {
            string option = "";
            Console.WriteLine("\nSelect from Following:-");
            Console.WriteLine(" 1) Add new Course");
            Console.WriteLine(" 2) View all Students");
            Console.WriteLine(" 3) Exit");
            Console.Write("Your Option: ");
            option = Console.ReadLine();
            return option;
        }

        static string StudentMenu()
        {
            string option = "";
            Console.WriteLine("\nSelect from following:-");
            Console.WriteLine(" 1) Enroll course");
            Console.WriteLine(" 2) Unenroll course");
            Console.WriteLine(" 3) Exit");
            Console.Write("Your Option: ");
            option = Console.ReadLine();
            return option;
        }

        static string AddCourseMenu()
        {
            Console.Write("Enter Course ID: ");
            coConsole.ReadLine();
        }

        static void ViewStudentsMenu(List<Student> student)
        {
            Console.WriteLine("Name \t Username \t RollNo");
            for (int x = 0; x < student.Count; x++)
            {
                Console.WriteLine(student[x].name + "\t" + student[x].username + "\t" + student[x].rollno);
            }
            Console.ReadKey();
        }

        static string EnrollMenu()
        {
            string option = "";
            Console.WriteLine("\nSelect your role:-");
            Console.WriteLine(" 1) Teacher");
            Console.WriteLine(" 2) Student");
            Console.WriteLine(" 3) Exit Program");
            Console.Write("Your Option: ");
            option = Console.ReadLine();
            return option;
        }

        static string UnenrollMenu()
        {
            string option = "";
            Console.WriteLine("\nSelect your role:-");
            Console.WriteLine(" 1) Teacher");
            Console.WriteLine(" 2) Student");
            Console.WriteLine(" 3) Exit Program");
            Console.Write("Your Option: ");
            option = Console.ReadLine();
            return option;
        }
    }
}
