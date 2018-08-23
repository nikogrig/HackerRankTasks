using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Compare_the_Triplets
{
    class Program
    {
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var firstPlayer = 0;

            var secondPlayer = 0;

            for (int i = 0; i < a.Count || i < b.Count; i++)
            {
                if (a[i] > b[i])
                {
                    firstPlayer++;
                }

                if (a[i] < b[i])
                {
                    secondPlayer++;
                }             
            }

            var list = new List<int>{ firstPlayer, secondPlayer };

            return list;
        }

        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').Select(int.Parse).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').Select(int.Parse).ToList();

            List<int> result = compareTriplets(a, b);

            Console.WriteLine(String.Join(" ", result));

        }
    }
}
