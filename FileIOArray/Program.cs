using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOArray
{
    /// <summary>
    /// App to demonstrate File IO
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string dataPath = @"Data\Students.txt";
            string[] students;

            students = new string[3];
            students[0] = "Yukichi, Fukuzawa, 45";
            students[1] = "Doppo, Kunikida, 23";
            students[2] = "Akiko, Yosano, 25";

            WriteAllStudents(dataPath, students);

            students = ReadAllStudents(dataPath);

            DisplayAllStudents(students);
        }

        static string[] ReadAllStudents(string dataPath)
        {
            string[] students;

            students = File.ReadAllLines(dataPath);

            return students;
        }

        static void WriteAllStudents(string dataPath, string[] students)
        {
            File.WriteAllLines(dataPath, students);
        }

        static void DisplayAllStudents(string[] students)
        {
            Console.WriteLine();
            Console.WriteLine("All Students");
            Console.WriteLine();

            //s
            // Table Headers
            //
            Console.WriteLine(
                   "First Name".PadRight(16) +
                   "Last Name".PadRight(15) +
                   "Age".PadRight(15)
                   );
            Console.WriteLine(
                   "----------".PadRight(16) +
                   "---------".PadRight(15) +
                   "---".PadRight(15)
                   );

            //
            // Table of Students
            // 
            foreach (string student in students)
            {
                string[] studentInfo = student.Split(',');
                Console.WriteLine(
                    studentInfo[0].PadRight(15) +
                    studentInfo[1].PadRight(15) +
                    studentInfo[2].PadRight(15) 
                    );
            }

            Console.WriteLine();
            Console.ReadKey();
        }
        
    }
}
