using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Source
{
    class Challenge : Attribute
    {
        public string Name { get; set; }
        public bool Run { get; set; } = false;
        public object[] Arguments { get; set; }

        public Challenge(params object[] args)
        {
            Arguments = args;
        }
    }

    class Challenges
    {
        public Challenges()
        {
            foreach (var method in GetType().GetMethods())
            {
                var challengeAttribute = method.GetCustomAttributes(false).OfType<Challenge>().FirstOrDefault();

                if (challengeAttribute != null && challengeAttribute.Run)
                {
                    {
                        if (challengeAttribute.Name != null && !challengeAttribute.Name.Equals(""))
                            Console.WriteLine("Challenge >: \"{0}\"", challengeAttribute.Name);

                        method.Invoke(this, challengeAttribute.Arguments);
                    }
                }
            }
        }

        private void Result(object value)
        {
            Console.WriteLine(">: Result \"{0}\"", value);
        }

        #region <- Challenges ->
        [Challenge(1000, Name = "Sum of multiples of 3 and 5", Run = false)]
        public void ChallengeOne(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;

            Result(sum);
        }

        [Challenge(4000000, Name = "Even Fibonacci numbers", Run = false)]
        public void ChallengeTwo(int n)
        {
            int a = 1, b = 2, c = 0, sum = 2;

            do
            {
                c = a + b;

                if (c % 2 == 0)
                    sum += c;

                a = b;
                b = c;
            } while (c <= n);

            Result(sum);
        }

        [Challenge(600851475143, Name = "Largest prime factor", Run = true)]
        public void ChallengeThree(long n)
        {
            long number = n;
            int index = 1, factor = 0;

            do
            {
                index++;

                if (number % index == 0)
                {
                    factor = index;

                    number = number / index;

                    index = 1;
                }
            } while (number != 1);

            Result(factor);
        }
        #endregion
    }
}
