using System;
using System.Collections.Generic;

namespace Shashank_and_the_Palindromic_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequence = int.Parse(Console.ReadLine());

            for (int i = 0; i < sequence; i++)
            {
                int cntOfArr = int.Parse(Console.ReadLine());

                string[] arr = new string[cntOfArr];

                for (int j = 0; j < cntOfArr; j++)
                {
                    string item = Console.ReadLine();

                    arr[j] = item;
                }

                int result = palindromicStrings(arr);

                Console.WriteLine(result);
            }
        }

        static int palindromicStrings(string[] arr)
        {
            var result = 0;

            var palindromes = new SortedSet<string>();

            foreach (var word in arr)
            {
                bool isPalindrome = true;

                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] != word[word.Length - 1 - i])
                    {
                        isPalindrome = false;

                        break;
                    }
                }
                if (isPalindrome)
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine("palindrome:" + string.Join(", ", palindromes));

            return result;
        }
    }
}
