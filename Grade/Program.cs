using System;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter English marks:");
            int englishMarks = Convert.ToInt32(Console.ReadLine());
            string englishGrade = GetGradeByMarks(englishMarks);

            Console.WriteLine("Enter Math marks:");
            int mathMarks = Convert.ToInt32(Console.ReadLine());
            string mathGrade = GetGradeByMarks(mathMarks);

            Console.WriteLine("Enter Language marks:");
            int languageMarks = Convert.ToInt32(Console.ReadLine());
            string languageGrade = GetGradeByMarks(languageMarks);
            
            Console.WriteLine("English Grade:" + englishGrade);
            Console.WriteLine("Math Grade:" + mathGrade);
            Console.WriteLine("Language Grade:" + languageGrade);
            
        }

        private static string GetGradeByMarks(int marks)
        {
            if (marks >= 80 || marks <= 100)
            {
                return "A+";
            }
            else if (marks >= 60 || marks < 80)
            {
                return "A";
            }
            else if (marks >= 40 || marks < 60)
            {
                return "B";
            }
            else if (marks >= 0 || marks < 40)
            {
                return "FAIL";
            }
            else if (marks < 0)
            {
                return "Mark cannot be less than 0";
            }
            return "";
        }
    }
}
