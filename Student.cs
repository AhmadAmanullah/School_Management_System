using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace SchoolManagementSystem
{
    internal class Student
    {
        string studentName = "defaultValue";
        int studentID;
        int studentClassNumber;

        public Student(string _studentName, int _studentID, int _studentClassNumber) 
        {
            studentName = _studentName;
            studentID = _studentID;
            studentClassNumber = _studentClassNumber;
        }

        public void StudentInformation()
        {
            WriteLine("studentName = " + studentName + 
                "\nStudent RollNumber = " + studentID +
                "\nstudentClassNumber = " + studentClassNumber);
        }
    }
}
