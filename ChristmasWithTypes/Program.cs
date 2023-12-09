using System;

namespace WhiteBoard
{
    class Program
    {
        public static string WhiteBoard(int num)
        {
            string answer = "";
            if(num % 3 == 0 && num % 5 ==0)
            {
                answer = "fizzbuzz";
            }
            else if(num % 3 == 0 && num % 5 != 0)
            {
                answer = "fizz";
            }
            else if(num % 5 == 0 && num % 3 != 0)
            {
                answer = "buzz";
            }

            return answer;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(WhiteBoard(10));

        }
    }
}
