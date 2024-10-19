using static System.Console;

namespace SchoolManagementSystem
{
    class Program
    {
        public int managementCase;

        static void Main(string[] args)
        {
            Program schoolManager = new schoolManager();
            //SMS may anay wala kon hy?
            WriteLine("Enter 0 for updating student information.\n" +
                "Enter 1 for updating teacher information.\n" +
                "Enter 2 for updating class information.\n");
            schoolManager.managementCase = Convert.ToInt32(ReadLine());

            switch (schoolManager.managementCase)
            {
                case 0:
                    Student student_0 = new("John", 45, 5);
                    student_0.StudentInformation();
                    break;
                case 1:
                    //teacher case
                    break;
                case 2:
                    //teacher case
                    break;
                case 3:
                    //teacher case
                    break;
                default:
                    break;
            }
        }
    }
}