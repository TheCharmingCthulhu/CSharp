using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test_Add();

            NonPublicItem.GetItem();

            Console.ReadKey();
        }

        private static void Test_Add()
        {
            for (int i = 1; i < 51; i++)
            {
                int j = i;

                int result = Add(i, j);

                Assert.Greater(result, 0, "Value is below threshold.");
                Assert.Less(result, 100, "Value is above threshold.");
            }

            Console.WriteLine("Unit Test Success");
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static void FizzBuzz()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i.ToString());
            }
        }

        private static void StringTemplate()
        {
            Dictionary<string, string> keys = new Dictionary<string, string>()
            {
                {"Title", "Hello World!"}
            };

            string input = File.ReadAllText("index.html");

            var matches = Regex.Matches(input, "");

            input = Regex.Replace(input, @"\{([A-z0-9]{1,})\}", new MatchEvaluator((Match match) =>
            {
                return keys.ContainsKey(match.Groups[1].Value) ? keys[match.Groups[1].Value] : match.Value;
            }));

            Console.WriteLine(input);
        }
    }
}
