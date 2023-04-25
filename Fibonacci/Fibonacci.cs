
using System;

namespace Fibonacci
{
    public class Fibonacci
    {
        public bool Check(int number)
        {
            //formula (5N^2 + 4) or (5N^2 - 4) needs to be perfect square -- 13
            number = 5 * (number * number);
            if(Math.Sqrt(number + 4) % 1 == 0 || Math.Sqrt(number - 4) % 1 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
