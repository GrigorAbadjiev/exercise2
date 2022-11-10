using System;

namespace exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double totalGrades = 0;  
            int failedStudents = 0;
            int goodStudents = 0;
            int veryGoodStudents = 0;
            int studentsTop = 0;
            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                totalGrades += grade;
                // <3
                // <4
                // <5
                // else (Top)
                if (grade < 3)
                {
                    failedStudents++;

                }
                else if (grade < 4)
                {
                    goodStudents++;
                }
                else if (grade < 5)
                {
                    veryGoodStudents++;
                }
                else
                {
                    studentsTop++;
                }
            }

            Console.WriteLine($"Top students: {studentsTop}%");
            Console.WriteLine($"Between 4.00 and 4.99: {veryGoodStudents}%");
            Console.WriteLine($"Between 3.00 and 3.99: {goodStudents}%");
            Console.WriteLine($"Fail: {failedStudents}%");
            Console.WriteLine($"Average: {totalGrades / students:f2}");
        }
    }       // input   // output
            // 10         Top students 3%
            // 3.00       Between 4.00 and 4.99 3%
            // 2.99       Between 3.00 and 3.99 2%
            // 5.68       Faild 2%
            // 3.01       Average 4.06
            // 4
            // 4
            // 6.00
            // 4.50
            // 2.44
            // 5
}
