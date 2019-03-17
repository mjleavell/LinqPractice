using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>() {
                "Donna",
                "Louis", 
                "Rachel",
                "Mike",
                "Jessica",
                "Harvey",
                ""
            };

            List<string> exercises = new List<string>() {
                "ToDo",
                "Shotz",
                "DynamicCards",
                "Nutshell"
            };

            List<string> descendingOrder = students.OrderBy(s => s).Reverse().ToList();

            foreach (string s in descendingOrder)
            {
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
