using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.X509Certificates;

namespace Assignment___Looping
{
    internal class Program
    {
        static void Main(string[] args = null)
        {
            string programSelect;

            Console.WriteLine("Please select the program you wish to use:");
            Console.WriteLine("1. Prompter");
            Console.WriteLine("2. Percent Passing");
            Console.WriteLine("3. Odd Sum");
            Console.WriteLine("4. Random Numbers");
            Console.WriteLine("5. Dice Game");

            programSelect = Console.ReadLine();
            while (programSelect.ToUpper() != "PROMPTER" && programSelect.ToUpper() != "1" && programSelect.ToUpper() != "PERCENT PASSING" && programSelect.ToUpper() != "2" && programSelect.ToUpper() != "ODD SUM" && programSelect.ToUpper() != "3" && programSelect.ToUpper() != "RANDOM NUMBERS" && programSelect.ToUpper() != "4" && programSelect.ToUpper() != "DICE GAME" && programSelect.ToUpper() != "5")
            {
                Console.WriteLine("Please select a valid option from the list above");
                programSelect = Console.ReadLine();
            }
            if (programSelect.ToUpper() == "PROMPTER" || programSelect.ToUpper() == "1")
            {
                RunPrompter();
            }
            else if (programSelect.ToUpper() == "PERCENT PASSING" || programSelect.ToUpper() == "2")
            {
                RunPercentPassing();
            }
            else if (programSelect.ToUpper() == "ODD SUM" || programSelect.ToUpper() == "3")
            {
                RunOddSum();
            }
            else if (programSelect.ToUpper() == "RANDOM NUMBERS" || programSelect.ToUpper() == "4")
            {
                RunRandomNumbers();
            }
            else if (programSelect.ToUpper() == "DICE GAME" || programSelect.ToUpper() == "5")
            {
                RunDiceGame();
            }
        }
        public static int max, num;
        public static void RunPrompter()
        {
            int min;
            bool validRange = false, validNum = false;
            Console.WriteLine("Prompter Selected. Please enter an integer to be used as a minimum of a range:");
            while (!Int32.TryParse(Console.ReadLine(), out min))
            {
                Console.WriteLine("Please enter a valid integer value");
            }
            Console.WriteLine("Please now enter an integer to be used as a maximum of the range");
            while (!validRange)
            {
                while (!Int32.TryParse(Console.ReadLine(), out max))
                {
                    Console.WriteLine("Please enter a valid integer value");
                }
                if (max < min)
                {
                    Console.WriteLine("Please enter a maximum that is greater than the minimum");
                }
                else if (max > min)
                {
                    validRange = true;
                }
            }
            Console.WriteLine("Range accepted. Now please enter any number within the range");
            while (!validNum)
            {
                while (!Int32.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Please enter a valid integer value");
                }
                if (num < max && num > min)
                {
                    validNum = true;
                }
                else
                {
                    Console.WriteLine("Please enter a number within the range");
                }
            }
            Console.WriteLine("Thank you for you input.");
            Console.WriteLine($"MIN ..... {min}");
            Console.WriteLine($"MAX ..... {max}");
            Console.WriteLine();
            Console.WriteLine($"NUM ..... {num}");

            Console.WriteLine();
            Console.WriteLine("Type MENU to return to the main menu");
            if (Console.ReadLine().ToUpper() == "MENU")
            {
                Main(null);
                Console.WriteLine();
                Console.WriteLine();
            }

        }

       // /////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void RunPercentPassing()
        {
            bool done = false;
            double percentPassing, studentScore, maxGrade, studentsPassing = 0;
            List<double> scores = new List<double>();
            List<double> percentGrades = new List<double>();

            Console.WriteLine("Percent Passing selected. Please enter the maximum score of the evaluation");
            while (!Double.TryParse(Console.ReadLine(), out maxGrade))
            {
                Console.WriteLine("Please enter a valid integer for the maximum score of the evaluation");
            }
            Console.WriteLine("Now please enter each student's score individually, press ENTER after each score. Enter -1 when all grades have been entered.");
            while (!done)
            {
                while (!Double.TryParse(Console.ReadLine(), out studentScore))
                {
                    Console.WriteLine("Please only enter integer values for scores.");
                    
                }
                if (studentScore != -1)
                {
                    scores.Add(studentScore);
                }
                else if (studentScore == -1)
                {
                    done = true;
                }
            }
            Console.WriteLine($"Scores added: {scores.Count}");

            for (int i = 0; i < scores.Count; i++)
            {
                percentGrades.Add(scores[i] / maxGrade);
                Console.WriteLine(percentGrades[i]);
                if (percentGrades[i] >= 0.70)
                {
                    studentsPassing++;
                }
            }
            percentPassing = Math.Round((studentsPassing / scores.Count) * 100, 1);
            Console.WriteLine($"{percentPassing}% of students passed the evaluation.");
        }

        // /////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void RunOddSum()
        {
            int inputNumber, num;
            List<int> ints = new List<int>();
            Console.WriteLine("Odd Sum Selected. Please enter a number now.");
            while(!Int32.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.WriteLine("Please enter a valid number with no decimal places.");
            }

            // determine if inputNumber is even or odd
            if (inputNumber % 2 == 0)
            {
                num = inputNumber - 1;
                ints.Add(num);
                while (num != 1)
                {
                    num = num - 2;
                    ints.Add(num);
                }
                Console.WriteLine($"The sum of every odd number less than your number, and your number itself is {ints.Sum() + inputNumber}.");
            }
            else
            {
                num = inputNumber - 2;
                ints.Add(num);
                while (num != 1)
                {
                    num = num - 2;
                    ints.Add(num);
                }
                Console.WriteLine($"The sum of every odd number less than your number, and your number itself is {ints.Sum() + inputNumber}.");
            }
        }
        public static void RunRandomNumbers()
        {
            Random generator = new Random();
            List<int> RandNums = new List<int>();
            int rangeMax, rangeMin;
            Console.WriteLine("Random Numbers Selected. The program will generate 25 random numbers within a range you input.");
            Console.WriteLine("Please enter the maximum of your range:");
            while (!Int32.TryParse(Console.ReadLine(), out rangeMax))
            {
                Console.WriteLine("Please enter a valid number with no decimal places.");
            }
            Console.WriteLine("Now please enter the minimum of your range");
            while (!Int32.TryParse(Console.ReadLine(), out rangeMin))
            {
                Console.WriteLine("Please enter a valid number with no decimal places.");
            }
            for (int i = 1; i <= 25; i++)
            {
                generator.Next(rangeMin, rangeMax - 1);
                RandNums.Add(i);
            }
            for (int i = 1; i <= RandNums.Count; i++)
            {

            }
        }
        public static void RunDiceGame()
        {
            
        }
    }
}