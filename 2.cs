using System;

namespace ProblemSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1: Display the first 10 natural numbers
            Console.WriteLine("Problem 1: Display the first 10 natural numbers");
            Console.WriteLine("Expected Output: 1 2 3 4 5 6 7 8 9 10");
            Console.WriteLine("Actual Output: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Problem 2: Find the sum of the first 10 natural numbers
            Console.WriteLine("\nProblem 2: Find the sum of the first 10 natural numbers");
            Console.WriteLine("Expected Output:");
            Console.WriteLine("The first 10 natural numbers are: 1 2 3 4 5 6 7 8 9 10");
            Console.WriteLine("The sum is: 55");
            Console.WriteLine("Actual Output: ");
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("The first 10 natural numbers are: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The sum is: " + sum);

            // Problem 3: Display the sum of n natural numbers
            Console.WriteLine("\nProblem 3: Display the sum of n natural numbers");
            Console.Write("Test Data: Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            Console.WriteLine("The first " + n + " natural numbers are:");
            int sumN = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
                sumN += i;
            }
            Console.WriteLine();
            Console.WriteLine("The sum of natural numbers up to " + n + " terms: " + sumN);

            // Problem 4: Read 10 numbers and find their average and sum
            Console.WriteLine("\nProblem 4: Read 10 numbers and find their average and sum");
            Console.WriteLine("Test Data: Enter 10 numbers:");
            int[] numbers = new int[10];
            int sum10 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Number-" + (i + 1) + ": ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum10 += numbers[i];
            }
            double average = (double)sum10 / 10;
            Console.WriteLine("Expected Output:");
            Console.WriteLine("The sum of 10 numbers is: " + sum10);
            Console.WriteLine("The average is: " + average.ToString("F6"));

            // Problem 5: Display the cube of an integer up to a given number
            Console.WriteLine("\nProblem 5: Display the cube of an integer up to a given number");
            Console.Write("Test Data: Enter the number of terms: ");
            int numTerms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            for (int i = 1; i <= numTerms; i++)
            {
                int cube = i * i * i;
                Console.WriteLine("Number is: " + i + " and cube of " + i + " is: " + cube);
            }

            // Problem 6: Display the multiplication table of a given integer
            Console.WriteLine("\nProblem 6: Display the multiplication table of a given integer");
            Console.Write("Test Data: Enter the number : ");
            int tableNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            for (int i = 1; i <= 10; i++)
            {
                int result = tableNumber * i;
                Console.WriteLine(tableNumber + " X " + i + " = " + result);
            }

            // Problem 7: Display the multiplication table vertically from 1 to n
            Console.WriteLine("\nProblem 7: Display the multiplication table vertically from 1 to n");
            Console.Write("Test Data: Enter the table number starting from 1: ");
            int nTable = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            Console.WriteLine("Multiplication table from 1 to " + nTable + ":");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= nTable; j++)
                {
                    int result = i * j;
                    Console.Write(j + "x" + i + " = " + result + ", ");
                }
                Console.WriteLine();
            }

            // Problem 8: Display the n terms of odd natural numbers and their sums
            Console.WriteLine("\nProblem 8: Display the n terms of odd natural numbers and their sums");
            Console.Write("Test Data: Enter the number of terms: ");
            int nTerms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            int oddSum = 0;
            Console.Write("The odd numbers are:");
            for (int i = 1; i <= nTerms; i++)
            {
                int oddNumber = 2 * i - 1;
                Console.Write(" " + oddNumber);
                oddSum += oddNumber;
            }
            Console.WriteLine();
            Console.WriteLine("The sum of odd natural numbers up to " + nTerms + " terms: " + oddSum);

            // Problem 9: Display a right angle triangle with an asterisk
            Console.WriteLine("\nProblem 9: Display a right angle triangle with an asterisk");
            Console.WriteLine("Pattern:");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Problem 10: Display a pattern like a right angle triangle with a number
            Console.WriteLine("\nProblem 10: Display a pattern like a right angle triangle with a number");
            Console.WriteLine("Pattern:");
            int count = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + " ");
                    count++;
                }
                Console.WriteLine();
            }

            // Problem 11: Display a pattern like a right angle triangle with a number which repeats a number in a row
            Console.WriteLine("\nProblem 11: Display a pattern like a right angle triangle with a number which repeats a number in a row");
            Console.WriteLine("Pattern:");
            count = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + " ");
                }
                count++;
                Console.WriteLine();
            }

            // Problem 12: Display a pattern like a right angle triangle with the number increased by 1
            Console.WriteLine("\nProblem 12: Display a pattern like a right angle triangle with the number increased by 1");
            Console.WriteLine("Pattern:");
            count = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + " ");
                    count++;
                }
                Console.WriteLine();
            }

            // Problem 13: Display a pattern like a pyramid with numbers increasing by 1
            Console.WriteLine("\nProblem 13: Display a pattern like a pyramid with numbers increasing by 1");
            Console.WriteLine("Pattern:");
            count = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + " ");
                    count++;
                }
                Console.WriteLine();
            }

            // Problem 14: Display a pattern like a pyramid with an asterisk
            Console.WriteLine("\nProblem 14: Display a pattern like a pyramid with an asterisk");
            Console.WriteLine("Pattern:");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // Problem 15: Calculate the factorial of a given number
            Console.WriteLine("\nProblem 15: Calculate the factorial of a given number");
            Console.Write("Test Data: Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("The factorial of " + number + " is: " + factorial);

            // Problem 16: Display the n terms of even natural numbers and their sum
            Console.WriteLine("\nProblem 16: Display the n terms of even natural numbers and their sum");
            Console.Write("Test Data: Enter the number of terms: ");
            nTerms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            int evenSum = 0;
            Console.Write("The even numbers are:");
            for (int i = 1; i <= nTerms; i++)
            {
                int evenNumber = 2 * i;
                Console.Write(" " + evenNumber);
                evenSum += evenNumber;
            }
            Console.WriteLine();
            Console.WriteLine("The sum of even natural numbers up to " + nTerms + " terms: " + evenSum);

            // Problem 17: Display a pattern like a pyramid with a number which will repeat the number in the same row
            Console.WriteLine("\nProblem 17: Display a pattern like a pyramid with a number which will repeat the number in the same row");
            Console.WriteLine("Pattern:");
            count = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + " ");
                }
                count++;
                Console.WriteLine();
            }

            // Problem 18: Find the sum of the series [1 - X^2/2! + X^4/4! - ...]
            Console.WriteLine("\nProblem 18: Find the sum of the series [1 - X^2/2! + X^4/4! - ...]");
            Console.Write("Test Data: Enter the value of X: ");
            double xValue = Convert.ToDouble(Console.ReadLine());
            Console.Write("Test Data: Enter the number of terms: ");
            numTerms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            double seriesSum = 1.0;
            int sign = -1;
            int power = 2;
            for (int i = 2; i <= numTerms; i++)
            {
                double term = Math.Pow(xValue, power) / Factorial(power);
                seriesSum += sign * term;
                sign *= -1;
                power += 2;
            }
            Console.WriteLine("The sum = " + seriesSum.ToString("F6"));
            Console.WriteLine("Number of terms = " + numTerms);
            Console.WriteLine("Value of X = " + xValue.ToString("F6"));

            // Problem 19: Display the n terms of the harmonic series and their sum
            Console.WriteLine("\nProblem 19: Display the n terms of the harmonic series and their sum");
            Console.Write("Test Data: Enter the number of terms: ");
            nTerms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            Console.Write("1");
            double harmonicSum = 1.0;
            for (int i = 2; i <= nTerms; i++)
            {
                Console.Write(" + 1/" + i);
                harmonicSum += 1.0 / i;
            }
            Console.WriteLine();
            Console.WriteLine("Sum of series up to " + nTerms + " terms: " + harmonicSum.ToString("F6"));

            // Problem 20: Display a pattern like a pyramid using an asterisk and each row contains an odd number of asterisks
            Console.WriteLine("\nProblem 20: Display a pattern like a pyramid using an asterisk and each row contains an odd number of asterisks");
            Console.WriteLine("Pattern:");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Problem 21: Display the sum of the series [9 + 99 + 999 + 9999 + ...]
            Console.WriteLine("\nProblem 21: Display the sum of the series [9 + 99 + 999 + 9999 + ...]");
            Console.Write("Test Data: Enter the number of terms: ");
            nTerms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            int sumSeries = 0;
            int termValue = 9;
            for (int i = 1; i <= nTerms; i++)
            {
                Console.Write(termValue + " ");
                sumSeries += termValue;
                termValue = termValue * 10 + 9;
            }
            Console.WriteLine();
            Console.WriteLine("The sum of the series = " + sumSeries);

            // Problem 22: Print Floyd's Triangle
            Console.WriteLine("\nProblem 22: Print Floyd's Triangle");
            Console.WriteLine("Pattern:");
            count = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count % 2);
                    count++;
                }
                Console.WriteLine();
            }

            // Problem 23: Display the sum of the series [1 + X + X^2/2! + X^3/3! + ...]
            Console.WriteLine("\nProblem 23: Display the sum of the series [1 + X + X^2/2! + X^3/3! + ...]");
            Console.Write("Test Data: Enter the value of X: ");
            xValue = Convert.ToDouble(Console.ReadLine());
            Console.Write("Test Data: Enter the number of terms: ");
            numTerms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            seriesSum = 0.0;
            power = 0;
            for (int i = 0; i < numTerms; i++)
            {
                double term = Math.Pow(xValue, power) / Factorial(power);
                seriesSum += term;
                power++;
            }
            Console.WriteLine("The sum is: " + seriesSum.ToString("F6"));
            Console.WriteLine("Number of terms = " + numTerms);
            Console.WriteLine("The value of X = " + xValue.ToString("F6"));

            // Problem 24: Find the sum of the series [X - X^3 + X^5 - ...]
            Console.WriteLine("\nProblem 24: Find the sum of the series [X - X^3 + X^5 - ...]");
            Console.Write("Test Data: Enter the value of X: ");
            xValue = Convert.ToDouble(Console.ReadLine());
            Console.Write("Test Data: Enter the number of terms: ");
            numTerms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            seriesSum = xValue;
            power = 3;
        
            for (int i = 2; i <= numTerms; i++)
            {
                double term = sign * Math.Pow(xValue, power);
                seriesSum += term;
                sign *= -1;
                power += 2;
            }
            Console.WriteLine("The sum = " + seriesSum);
            Console.WriteLine("Number of terms = " + numTerms);
            Console.WriteLine("The value of X = " + xValue);

            // Problem 25: Display the n terms of square natural numbers and their sum
            Console.WriteLine("\nProblem 25: Display the n terms of square natural numbers and their sum");
            Console.Write("Test Data: Enter the number of terms: ");
            nTerms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            Console.Write("The square natural numbers up to " + nTerms + " terms are:");
            int sumSquare = 0;
            for (int i = 1; i <= nTerms; i++)
            {
                int square = i * i;
                Console.Write(" " + square);
                sumSquare += square;
            }
            Console.WriteLine();
            Console.WriteLine("The sum of square natural numbers up to " + nTerms + " terms = " + sumSquare);

            Console.ReadLine();
        }

        static int Factorial(int number)
        {
            if (number == 0)
                return 1;
            else
                return number * Factorial(number - 1);
        }
    }
}
