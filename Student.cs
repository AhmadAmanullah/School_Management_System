using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Console;
using System.IO;
namespace SchoolManagementSystem
{
    internal class Student
    {
        string name = "DefaultName";
        string ID;
        string grade;
        string dateOfBirth;
        string CNIC;
        string fatherName = "DefaultFatherName";
        string StudentDataFile = @"D:\.Net Data\Console Applications\SchoolManagementSystem\StudentData.txt";

        public void CreateStudentFile()
        {
            if (File.Exists(StudentDataFile))
            {
                WriteLine("File Already Created.");
            }
            else
            {
                // Create a new file     
                FileStream fs = File.Create(StudentDataFile);
            }
        }

        public void AddStudentInformation()
        {
            WriteLine("Enter Student Name");
            name = ReadLine();

            //check user entered name
            while (!IsStringAndAlphabetic(name))
            {
                WriteLine("Invalid input! Please enter the name again.");
                name = ReadLine();
            }
            //check user ID
            WriteLine("Please enter ID");
            ID = ReadLine();

            while (!IsNumericValueEntered(ID))
            {
                WriteLine("Invalid input! Please enter a valid ID in numbers.");
                ID = ReadLine();
            }
            //check user grade
            WriteLine("Enter Student Grade");
            grade = ReadLine();

            while (!IsNumericValueEntered(grade))
            {
                WriteLine("Invalid input! Please enter a valid grade in numbers.");
                grade = ReadLine();
            }
            ///check user dateofbirth
            WriteLine("Enter Student dateOfBirth");
            dateOfBirth = ReadLine();

            while (!IsNumericValueEntered(dateOfBirth))
            {
                WriteLine("Invalid input! Please enter a valid date of birth in numbers.");
                dateOfBirth = ReadLine();
            }

            ///check user CNIC
            WriteLine("Enter Student CNIC");
            CNIC = ReadLine();

            while (!IsNumericValueEntered(CNIC))
            {
                WriteLine("Invalid input! Please enter a valid CNIC in numbers.");
                CNIC = ReadLine();
            }

            ///check user FatherName
            WriteLine("Enter Student FatherName");     
            fatherName = ReadLine();


            while (!IsStringAndAlphabetic(fatherName))
            {
                WriteLine("Invalid input! Please enter the father name again.");
                fatherName = ReadLine();
            }
        }

        public void AddDataInStudentFile()
        {

            File.AppendAllText(StudentDataFile, name);
            File.AppendAllText(StudentDataFile, "\n");

            File.AppendAllText(StudentDataFile, ID);
            File.AppendAllText(StudentDataFile, "\n");

            File.AppendAllText(StudentDataFile, grade);
            File.AppendAllText(StudentDataFile, "\n");

            File.AppendAllText(StudentDataFile, dateOfBirth);
            File.AppendAllText(StudentDataFile, "\n");

            File.AppendAllText(StudentDataFile, CNIC);
            File.AppendAllText(StudentDataFile, "\n");

            File.AppendAllText(StudentDataFile, fatherName);
            File.AppendAllText(StudentDataFile, "\n\n");
        }

        bool IsStringAndAlphabetic(string name)
        {
            foreach (char character in name)
            {
                if (!char.IsLetter(character))
                {
                    return false;
                }
            }
            return true;
        }

        bool IsNumericValueEntered(string _numericValue)
        {
            return int.TryParse(_numericValue, out _);  // The out _ discards the parsed integer value
        }



        public void ViewStudentInformation()
        {
            WriteLine("studentName = " + name +
                "\nStudent ID = " + ID +
                "\nStudent Grade = " + grade +
                "\nStudent DateOfBirth = " + dateOfBirth +
                "\nStudent CNIC = " + CNIC +
                "\nStudent Father Name = " + fatherName);
        }

        public void ViewStudentFileData()
        {
            string StudentInfo = File.ReadAllText(StudentDataFile, Encoding.UTF8);
            WriteLine(StudentInfo);
        }

        public void UpdateStudentDataFromFile()
        {
            WriteLine("Enter Student Name To Change");
            string updateName = ReadLine();
            while (!IsStringAndAlphabetic(updateName))
            {
                WriteLine("Invalid input! Please enter the name again.");
                updateName = ReadLine();
            }

            WriteLine("Enter the new name to replace it with:");
            string newName = ReadLine();
            while (!IsStringAndAlphabetic(newName))
            {
                WriteLine("Invalid input! Please enter the name again.");
                newName = ReadLine();
            }

            string[] fileLines = File.ReadAllLines(StudentDataFile, Encoding.UTF8);
            bool found = false;

            for (int i = 0; i < fileLines.Length; i++)
            {
                if (fileLines[i].Trim().Equals(updateName.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    fileLines[i] = newName; // Replace the found name with the new name
                    found = true;
                    break;
                }
            }

            if (found)
            {
                // Write the modified lines back to the file
                File.WriteAllLines(StudentDataFile, fileLines, Encoding.UTF8);
                WriteLine("Student Name Updated Successfully.");
            }
            else
            {
                WriteLine("Student Name Not Found.");
            }
        }


        public void DeleteStudentDataFromFile()
        {
            WriteLine("Enter Student Name To delete");
            string deleteName = ReadLine();
            while (!IsStringAndAlphabetic(deleteName))
            {
                WriteLine("Invalid input! Please enter the name again.");
                deleteName = ReadLine();
            }

            string[] fileLines = File.ReadAllLines(StudentDataFile, Encoding.UTF8);
            bool found = false;

            for (int i = 0; i < fileLines.Length; i++)
            {
                if (fileLines[i].Trim().Equals(deleteName.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    fileLines[i] = ""; // delete the found name with the new name
                    found = true;
                    break;
                }
            }

            if (found)
            {
                // Write the modified lines back to the file
                File.WriteAllLines(StudentDataFile, fileLines, Encoding.UTF8);
                WriteLine("Student Name deleted Successfully.");
            }
            else
            {
                WriteLine("Student Name Not Found.");
            }
        }
    }
}