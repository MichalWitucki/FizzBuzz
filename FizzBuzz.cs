﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
         public string GameFizzBuzz(int userNumber)
        {
            if (userNumber % 5 == 0 && userNumber % 3 == 0)
                return "FizzBuzz";

            else if (userNumber % 5 == 0)
                return "Buzz";

            else if (userNumber % 3 == 0)
                return "Fizz";

            else return userNumber.ToString();
        }
    }
}
