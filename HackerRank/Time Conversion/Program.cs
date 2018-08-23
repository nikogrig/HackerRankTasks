using System;

namespace Time_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = timeConversion(s);

            Console.WriteLine(result);
        }

        static string timeConversion(string input)
        {          
            DateTime dt = DateTime.Parse(input);

            string result = dt.ToString("HH:mm:ss");

            return result;
        }
    }
}
