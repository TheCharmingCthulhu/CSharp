using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Motomatic.Source.Utilities.Comparator
{
    class AlphaNumericComparer
    {
        public static int Compare(object x, object y)
        {
            if (x == null || y == null) return 0;

            int side = 0;
            string left = null;
            string right = null;

            if ((x as string).Length < (y as string).Length)
            {
                left = x as string;
                right = y as string;
                side = -1;
            }
            else
            {
                left = y as string;
                right = x as string;
                side = 1;
            }

            for (int i = 0; i < left.Length; i++)
            {
                if (char.IsDigit(left[i]) && char.IsDigit(right[i]))
                {
                    var valueLeft = int.Parse(Regex.Match(left, "[0-9]{1,}").Value);
                    var valueRight = int.Parse(Regex.Match(right, "[0-9]{1,}").Value);

                    if (valueLeft > valueRight)
                        return side;
                    else if (valueLeft == valueRight)
                        continue;
                    else
                        return -side;
                }

                if (left[i] > right[i])
                    return side;
                else if (left[i] == right[i])
                    continue;
                else
                    return -side;
            }

            return -side;
        }
    }
}
