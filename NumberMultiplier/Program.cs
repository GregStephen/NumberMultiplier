using System;

namespace NumberMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string SquareNumbers(string[] arrayToSquare)
            {
                string squaredNumbers = "";
                for (var i = 0; i < arrayToSquare.Length; i++)
                {
                    var newNum = int.Parse(arrayToSquare[i]);
                    string result = (newNum * newNum).ToString();
                    if (i == 0)
                    {
                        squaredNumbers = squaredNumbers + result;
                    }
                    else
                    {
                        squaredNumbers = squaredNumbers + ", " + result;
                    }
                }
                return squaredNumbers;
            }

            int MultiplyNumbers(string[] arrayToMultiply)
            {
                var sum = 1;
                for (var i = 0; i < arrayToMultiply.Length; i++)
                {
                    var newNum = int.Parse(arrayToMultiply[i]);
                    sum = sum * newNum;
                }
                return sum;
            }
            void Program ()
            {
                Console.WriteLine("Hey, input a list of numbers, separated by a ','!");
                var listOfNumbers = Console.ReadLine();
                var arrayOfNumbers = listOfNumbers.Split(",");
                Console.WriteLine("Would you like to multiply these numbers or get the square of each?" +
                    "Type 'Multiply' or 'Square'");
                var whichFunctionToRun = Console.ReadLine().ToLower();
                if (whichFunctionToRun == "multiply")
                {
                    var sum = MultiplyNumbers(arrayOfNumbers);
                    Console.WriteLine(sum);
                }
                else if (whichFunctionToRun == "square")
                {
                    var squared = SquareNumbers(arrayOfNumbers);
                    Console.WriteLine(squared);
                }
                else
                {
                    Console.WriteLine("You didn't type the right thing ya goof");

                }
            }
            void PlayAgain()
            {
                Console.WriteLine("Would you like to play one more time? Y or N");
                var continueOrNot = Console.ReadLine().ToLower();
                if (continueOrNot == "y")
                {
                    Program();
                }
                else
                {
                }
            }
            Program();
            PlayAgain();

        }
    }
}
