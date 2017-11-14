using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringTemplate();
            FizzBuzz();

            Console.ReadKey();
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
