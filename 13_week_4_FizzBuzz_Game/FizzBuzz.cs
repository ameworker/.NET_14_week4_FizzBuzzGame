using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_week_4_FizzBuzz_Game
{

    internal class FizzBuzz
    {

        public string DescribeNumber(int number)
        {
            string result = string.Empty;

            if (number % 3 == 0 && number % 5 != 0)
            {
                result = "Fizz";

            }
            else if (number % 3 != 0 && number % 5 == 0)
            {
                result = "Buzz";

            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                result = "FizzBuzz";

            }
            else
            {
                result = number.ToString();
            }

            return result;
        }
    }
}

