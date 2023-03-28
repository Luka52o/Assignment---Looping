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

        // /////////////////////////////////////////////////////////////////////////////////////////////////////
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
            while (!Int32.TryParse(Console.ReadLine(), out inputNumber))
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

        // /////////////////////////////////////////////////////////////////////////////////////////////////////
        public static int rangeMin;
        public static void RunRandomNumbers()
        {
            Random generator = new Random();
            List<int> RandNums = new List<int>();
            int rangeMax;
            bool done = false;
            Console.WriteLine("Random Numbers Selected. The program will generate 25 random numbers within a range you input.");
            Console.WriteLine("Please enter the maximum of your range:");
            while (!Int32.TryParse(Console.ReadLine(), out rangeMax))
            {
                Console.WriteLine("Please enter a valid number with no decimal places.");
            }
            Console.WriteLine("Now please enter the minimum of your range:");
            while (!done)
            {
                while (!Int32.TryParse(Console.ReadLine(), out rangeMin))
                {
                    Console.WriteLine("Please enter a valid number with no decimal places:");
                }
                if (rangeMin > rangeMax)
                {
                    Console.WriteLine("Please ensure your minimum is lesser than your maximum:");
                }
                else
                {
                    done = true;
                }
            }

            for (int i = 1; i <= 25; i++)
            {
                RandNums.Add(generator.Next(rangeMin, rangeMax));
            }
            RandNums.Sort();
            Console.Write(rangeMin + " ");
            for (int i = 0; i < RandNums.Count; i++)
            {
                Console.Write(" " + (RandNums[i]) + " ");
            }
            Console.WriteLine(" " + rangeMax);
            Console.WriteLine("(Numbers have been automatically sorted from least - greatest, including your range caps)");
        }

        // /////////////////////////////////////////////////////////////////////////////////////////////////////
        public static double balance = 100.00;
        public static void RunDiceGame()
        {
            bool played = false;
            string betType;

            Console.WriteLine($"Welcome to the dice game. Your current balance is ${balance}, please chose a bet from the following list:");
            Console.WriteLine("1. DOUBLES - Roll two dice, earn double your bet if the rolls are the same");
            Console.WriteLine("2 .NOT DOUBLES - Roll two dice, earn half your bet if the rolls do not match");
            Console.WriteLine("3. EVEN SUM - Roll two dice, earn your bet if the sum of the rolls is an even number");
            Console.WriteLine("4. ODD SUM - Roll two dice, earn your bet if the sum of the rolls is an odd number");
            Console.WriteLine("Type in your choice into the console:");
            betType = Console.ReadLine();
            while (betType.ToUpper() != "DOUBLES" && betType.ToUpper() != "NOT DOUBLES" && betType.ToUpper() != "EVEN SUM" && betType.ToUpper() != "ODD SUM" && betType.ToUpper() != "1" && betType.ToUpper() != "2" && betType.ToUpper() != "3" && betType.ToUpper() != "4")
            {
                Console.WriteLine("Please enter a valid bet type:");
                betType = Console.ReadLine();
            }
            if (betType.ToUpper() == "DOUBLES" || betType == "1")
            {
                PlayDoubles();
            }
            else if (betType.ToUpper() == "NOT DOUBLES" || betType == "2")
            {
                PlayNotDoubles();
            }
            else if (betType.ToUpper() == "EVEN SUM" || betType == "3")
            {
                PlayEvenSum();
            }
            else if (betType.ToUpper() == "ODD SUM" || betType == "4")
            {
                PlayOddSum();
            }
        }
        public static void PlayDoubles()
        {
            bool usableValueGiven = false;
            double betValue = 0;
            string playAgain;

            while (!usableValueGiven)
            {
                Console.WriteLine("Now enter your bet amount:");
                Console.Write("$");

                if (!double.TryParse(Console.ReadLine(), out betValue))
                    Console.WriteLine("Please enter a valid number value for your bet:");

                else if (betValue > balance)
                    Console.WriteLine("Please enter a bet smaller than your balance");
                else
                {
                    usableValueGiven = true;
                }
            }
            die die1 = new die();
            die die2 = new die();
            die1.RollDie6();
            die2.RollDie6();

            die1.DrawRoll();
            Console.WriteLine();
            die2.DrawRoll();

            if (die1.Roll == die2.Roll)
            {
                Console.WriteLine($"WINNER! PAYOUT: ${betValue * 2}");
                balance = balance + (betValue * 2);
                Console.WriteLine($"ACCOUNT BALANCE: ${balance}");

                if (balance != 0)
                {
                    Console.WriteLine("Play again? Y/N");
                    playAgain = Console.ReadLine();
                    if (playAgain.ToUpper() == "N")
                    {
                        Console.WriteLine($"Thank you for playing! Your final account balance is {balance}");
                    }
                    else if (playAgain.ToUpper() == "Y")
                    {
                        RunDiceGame();
                    }
                }
                else
                {
                    Console.WriteLine("ACCOUNT DEPLETED. Better luck next time!");
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine($"LOSER. YOU LOST {betValue}");
                balance = balance - (betValue);
                Console.WriteLine($"ACCOUNT BALANCE: {balance}");

                if (balance != 0)
                {
                    Console.WriteLine("Play again? Y/N");
                    playAgain = Console.ReadLine();
                    if (playAgain.ToUpper() == "N")
                    {
                        Console.WriteLine($"Thank you for playing! Your final account balance is {balance}");
                    }
                    else if (playAgain.ToUpper() == "Y")
                    {
                        RunDiceGame();
                    }
                }
                else
                {
                    Console.WriteLine("ACCOUNT DEPLETED. Better luck next time!");
                }
            }
        }
        public static void PlayNotDoubles()
        {
            bool usableValueGiven = false;
            double betValue = 0;
            string playAgain;

            while (!usableValueGiven)
            {
                Console.WriteLine("Now enter your bet amount:");
                Console.Write("$");

                if (!double.TryParse(Console.ReadLine(), out betValue))
                    Console.WriteLine("Please enter a valid number value for your bet:");

                else if (betValue > balance)
                    Console.WriteLine("Please enter a bet smaller than your balance");
                else
                {
                    usableValueGiven = true;
                }
            }
            die die1 = new die();
            die die2 = new die();
            die1.RollDie6();
            die2.RollDie6();

            die1.DrawRoll();
            Console.WriteLine();
            die2.DrawRoll();

            if (die1.Roll != die2.Roll)
            {
                Console.WriteLine($"WINNER! PAYOUT: ${betValue / 2}");
                balance = balance + (betValue / 2);
                Console.WriteLine($"ACCOUNT BALANCE: ${balance}");

                if (balance != 0)
                {
                    Console.WriteLine("Play again? Y/N");
                    playAgain = Console.ReadLine();
                    if (playAgain.ToUpper() == "N")
                    {
                        Console.WriteLine($"Thank you for playing! Your final account balance is {balance}");
                    }
                    else if (playAgain.ToUpper() == "Y")
                    {
                        RunDiceGame();
                    }
                }
                else
                {
                    Console.WriteLine("ACCOUNT DEPLETED. Better luck next time!");
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine($"LOSER. YOU LOST {betValue}");
                balance = balance - (betValue);
                Console.WriteLine($"ACCOUNT BALANCE: {balance}");

                if (balance != 0)
                {
                    Console.WriteLine("Play again? Y/N");
                    playAgain = Console.ReadLine();
                    if (playAgain.ToUpper() == "N")
                    {
                        Console.WriteLine($"Thank you for playing! Your final account balance is {balance}");
                    }
                    else if (playAgain.ToUpper() == "Y")
                    {
                        RunDiceGame();
                    }
                }
                else
                {
                    Console.WriteLine("ACCOUNT DEPLETED. Better luck next time!");
                }
            }
        }
        public static void PlayEvenSum()
        {
            bool usableValueGiven = false;
            double betValue = 0, rollSum;
            string playAgain;

            while (!usableValueGiven)
            {
                Console.WriteLine("Now enter your bet amount:");
                Console.Write("$");

                if (!double.TryParse(Console.ReadLine(), out betValue))
                    Console.WriteLine("Please enter a valid number value for your bet:");

                else if (betValue > balance)
                    Console.WriteLine("Please enter a bet smaller than your balance");
                else
                {
                    usableValueGiven = true;
                }
            }
            die die1 = new die();
            die die2 = new die();
            die1.RollDie6();
            die2.RollDie6();

            die1.DrawRoll();
            Console.WriteLine();
            die2.DrawRoll();

            rollSum = die1.Roll + die2.Roll;
            if (rollSum % 2 == 0)
            {
                Console.WriteLine($"WINNER! PAYOUT: ${betValue}");
                balance = balance + betValue;
                Console.WriteLine($"ACCOUNT BALANCE: ${balance}");

                if (balance != 0)
                {
                    Console.WriteLine("Play again? Y/N");
                    playAgain = Console.ReadLine();
                    if (playAgain.ToUpper() == "N")
                    {
                        Console.WriteLine($"Thank you for playing! Your final account balance is {balance}");
                    }
                    else if (playAgain.ToUpper() == "Y")
                    {
                        RunDiceGame();
                    }
                }
                else
                {
                    Console.WriteLine("ACCOUNT DEPLETED. Better luck next time!");
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine($"LOSER. YOU LOST {betValue}");
                balance = balance - betValue;
                Console.WriteLine($"ACCOUNT BALANCE: {balance}");

                if (balance != 0)
                {
                    Console.WriteLine("Play again? Y/N");
                    playAgain = Console.ReadLine();
                    if (playAgain.ToUpper() == "N")
                    {
                        Console.WriteLine($"Thank you for playing! Your final account balance is {balance}");
                    }
                    else if (playAgain.ToUpper() == "Y")
                    {
                        RunDiceGame();
                    }
                }
                else
                {
                    Console.WriteLine("ACCOUNT DEPLETED. Better luck next time!");
                }
            }
        }
        public static void PlayOddSum()
        {
            bool usableValueGiven = false;
            double betValue = 0, rollSum;
            string playAgain;

            while (!usableValueGiven)
            {
                Console.WriteLine("Now enter your bet amount:");
                Console.Write("$");

                if (!double.TryParse(Console.ReadLine(), out betValue))
                    Console.WriteLine("Please enter a valid number value for your bet:");

                else if (betValue > balance)
                    Console.WriteLine("Please enter a bet smaller than your balance");
                else
                {
                    usableValueGiven = true;
                }
            }
            die die1 = new die();
            die die2 = new die();
            die1.RollDie6();
            die2.RollDie6();

            die1.DrawRoll();
            Console.WriteLine();
            die2.DrawRoll();

            rollSum = die1.Roll + die2.Roll;
            if (rollSum % 2 == 0)
            {
                Console.WriteLine($"LOSER. YOU LOST {betValue}");
                balance = balance - betValue;
                Console.WriteLine($"ACCOUNT BALANCE: {balance}");

                if (balance != 0)
                {
                    Console.WriteLine("Play again? Y/N");
                    playAgain = Console.ReadLine();
                    if (playAgain.ToUpper() == "N")
                    {
                        Console.WriteLine($"Thank you for playing! Your final account balance is {balance}");
                    }
                    else if (playAgain.ToUpper() == "Y")
                    {
                        RunDiceGame();
                    }
                }
                else
                {
                    Console.WriteLine("ACCOUNT DEPLETED. Better luck next time!");
                }
            }
            else
            {
                Console.WriteLine($"WINNER! PAYOUT: ${betValue}");
                balance = balance + betValue;
                Console.WriteLine($"ACCOUNT BALANCE: ${balance}");

                if (balance != 0)
                {
                    Console.WriteLine("Play again? Y/N");
                    playAgain = Console.ReadLine();
                    if (playAgain.ToUpper() == "N")
                    {
                        Console.WriteLine($"Thank you for playing! Your final account balance is {balance}");
                    }
                    else if (playAgain.ToUpper() == "Y")
                    {
                        RunDiceGame();
                    }
                }
                else
                {
                    Console.WriteLine("ACCOUNT DEPLETED. Better luck next time!");
                    Console.ReadLine();
                }
            }
        }

    }
}