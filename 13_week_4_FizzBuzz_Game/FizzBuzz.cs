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
            if (number % 3 == 0 && number % 5 != 0)
            {
                string result = "Fizz";
                return result;
            }
            else if (number % 3 != 0 && number % 5 == 0)
            {
                string result="Buzz";
                return result;
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                string result = "FizzBuzz";
                return result;
            }
            else
            {
                return number.ToString();
            }
        }
    }
}

