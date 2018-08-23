using System;

namespace Grading_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] grades = new int[n];

            for (int i = 0; i < n; i++)
            {
                int grade = int.Parse(Console.ReadLine());

                grades[i] = grade;
            }

            int[] result = gradingStudents(grades);
            Console.WriteLine("result:");

            Console.WriteLine(string.Join("\n", result));
        }

        static int[] gradingStudents(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                var item = grades[i];

                if (item >= 38)
                {
                    var diff = 5 - (item % 5);

                    if (diff < 3)
                    {
                        grades[i] = item + diff;

                    }
                }
            }

            return grades;
        }
    }
}
