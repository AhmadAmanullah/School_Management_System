using System;
using static System.Console;

namespace SchoolManagementSystem
{
    class Program
    {
        int accessDatabase = 0;
        int managementCase;
        int accessStudentDatabase = 0;
        int studentCase;
        bool IsValidStudentTask;

        static void Main(string[] args)
        {
            Program schoolManager = new Program();
            while (schoolManager.accessDatabase == 0)
            {
                WriteLine("Please select which database you want to access:");
                WriteLine("0. student database.\n" +
                    "1. teacher database.\n" +
                    "2. class database.\n" +
                    "3. subject database.\n" +
                    "4. attendance database.\n" +
                    "5. examination database.\n" +
                    "6. result database.\n" +
                    "7. timetable database.\n" +
                    "8. fee database.\n" +
                    "9. library database.\n" +
                    "10. user database.\n" +
                    "11. authentication and authorization database.\n" +
                    "12. report database.\n");
                schoolManager.managementCase = Convert.ToInt32(ReadLine());
                switch (schoolManager.managementCase)
                {
                    case 0:
                        // Display available tasks to the user
                        while (schoolManager.accessStudentDatabase == 0)
                        {

                            Console.WriteLine("Please select which task you want to perform:\n" +
                                "0. Add Student\n" +
                                "1. View Student\n" +
                                "2. Update Student\n" +
                                "3. Delete Student\n");
                            schoolManager.studentCase = Convert.ToInt32(ReadLine());
                            Student studentObj = new Student();
                            switch (schoolManager.studentCase)
                            {
                                case 0:
                                    // Add student
                                    Console.WriteLine("Adding student Data...");
                                    studentObj.CreateStudentFile();
                                    studentObj.AddStudentInformation();
                                    studentObj.AddDataInStudentFile();
                                    break;
                                case 1:
                                    // View student
                                    Console.WriteLine("Viewing student Data...");
                                    studentObj.ViewStudentFileData();
                                    break;
                                case 2:
                                    // Update student
                                    Console.WriteLine("Updating student Data...");
                                    studentObj.UpdateStudentDataFromFile();
                                    break;
                                case 3:
                                    // Delete student
                                    Console.WriteLine("Deleting student Data...");
                                    studentObj.DeleteStudentDataFromFile();
                                    // Implement your delete student logic here
                                    break;
                                default:
                                    Console.WriteLine("Invalid student task selected. Please enter valid student task.");
                                    schoolManager.studentCase = Convert.ToInt32(ReadLine());
                                    break;

                            }
                            WriteLine("Enter 0 to continue access to student database or 1 to go back");
                            schoolManager.accessStudentDatabase = Convert.ToInt32(ReadLine());
                        }
                        break;
                    case 1:
                        // Teacher case

                        break;
                    case 2:
                        // Class case

                        break;
                    case 3:
                        // Subject case

                        break;
                    default:
                        WriteLine("Invalid database selected. Please enter valid database number.");
                        schoolManager.managementCase = Convert.ToInt32(ReadLine());
                        break;

                }
                WriteLine("Enter 0 to continue access to database or 1 to exit");
                schoolManager.accessDatabase = Convert.ToInt32(ReadLine());

            }
            WriteLine("\nPress any key to exit...");
            ReadKey();
        }
    }
}