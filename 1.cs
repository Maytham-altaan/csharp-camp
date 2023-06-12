using System;

class Program
{
    static void Main()
    {
        // Problem 1: Input a string and print it
        Console.WriteLine("Problem 1: Input a string and print it");
        Console.Write("Test Data: Input the string: ");
        string inputString = Console.ReadLine();
        Console.WriteLine("Expected Output:");
        Console.WriteLine("The string you entered is: " + inputString);

        // Problem 2: Find the length of a string without using a library function
        Console.WriteLine("\nProblem 2: Find the length of a string without using a library function");
        Console.Write("Test Data: Input the string: ");
        string lengthString = Console.ReadLine();
        Console.WriteLine("Expected Output:");
        int length = 0;
        foreach (char c in lengthString)
        {
            length++;
        }
        Console.WriteLine("Length of the string is: " + length);

        // Problem 3: Separate individual characters from a string
        Console.WriteLine("\nProblem 3: Separate individual characters from a string");
        Console.Write("Test Data: Input the string: ");
        string separateString = Console.ReadLine();
        Console.WriteLine("Expected Output:");
        Console.WriteLine("The characters of the string are:");
        foreach (char c in separateString)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();

        // Problem 4: Print individual characters of the string in reverse order
        Console.WriteLine("\nProblem 4: Print individual characters of the string in reverse order");
        Console.Write("Test Data: Input the string: ");
        string reverseString = Console.ReadLine();
        Console.WriteLine("Expected Output:");
        Console.WriteLine("The characters of the string in reverse are:");
        for (int i = reverseString.Length - 1; i >= 0; i--)
        {
            Console.Write(reverseString[i] + " ");
        }
        Console.WriteLine();

        // Problem 5: Count the total number of words in a string
        Console.WriteLine("\nProblem 5: Count the total number of words in a string");
        Console.Write("Test Data: Input the string: ");
        string wordString = Console.ReadLine();
        Console.WriteLine("Expected Output:");
        string[] words = wordString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;
        Console.WriteLine("Total number of words in the string is: " + wordCount);

        // Problem 6: Compare two strings without using string library functions
        Console.WriteLine("\nProblem 6: Compare two strings without using string library functions");
        Console.Write("Test Data: Input the 1st string: ");
        string firstString = Console.ReadLine();
        Console.Write("Input the 2nd string: ");
        string secondString = Console.ReadLine();
        Console.WriteLine("Expected Output:");
        bool areEqual = CompareStrings(firstString, secondString);
        if (areEqual)
        {
            Console.WriteLine("The length of both strings are equal and also, both strings are equal.");
        }
        else
        {
            Console.WriteLine("The length of both strings are not equal or both strings are not equal.");
        }

        // Problem 7: Count the number of alphabets, digits, and special characters in a string
        Console.WriteLine("\nProblem 7: Count the number of alphabets, digits, and special characters in a string");
        Console.Write("Test Data: Input the string: ");
        string countString = Console.ReadLine();
        Console.WriteLine("Expected Output:");
        int alphabetCount = 0;
        int digitCount = 0;
        int specialCharCount = 0;
        foreach (char c in countString)
        {
            if (char.IsLetter(c))
            {
                alphabetCount++;
            }
            else if (char.IsDigit(c))
            {
                digitCount++;
            }
            else
            {
                specialCharCount++;
            }
        }
        Console.WriteLine("Number of Alphabets in the string is: " + alphabetCount);
        Console.WriteLine("Number of Digits in the string is: " + digitCount);
        Console.WriteLine("Number of Special characters in the string is: " + specialCharCount);

        // Problem 8: Copy one string to another string
        Console.WriteLine("\nProblem 8: Copy one string to another string");
        Console.Write("Test Data: Input the string: ");
        string originalString = Console.ReadLine();
        string copiedString = CopyString(originalString);
        Console.WriteLine("Expected Output:");
        Console.WriteLine("The First string is: " + originalString);
        Console.WriteLine("The Second string is: " + copiedString);
        Console.WriteLine("Number of characters copied: " + originalString.Length);

        // Problem 9: Count the number of vowels or consonants in a string
        Console.WriteLine("\nProblem 9: Count the number of vowels or consonants in a string");
        Console.Write("Test Data: Input the string: ");
        string vowelConsonantString = Console.ReadLine();
        Console.WriteLine("Expected Output:");
        int vowelCount = 0;
        int consonantCount = 0;
        foreach (char c in vowelConsonantString)
        {
            if (IsVowel(c))
            {
                vowelCount++;
            }
            else if (char.IsLetter(c))
            {
                consonantCount++;
            }
        }
        Console.WriteLine("The total number of vowels in the string is: " + vowelCount);
        Console.WriteLine("The total number of consonants in the string is: " + consonantCount);

        // Problem 10: Find the maximum number of characters in a string
        Console.WriteLine("\nProblem 10: Find the maximum number of characters in a string");
        Console.Write("Test Data: Input the string: ");
        string maxCharString = Console.ReadLine();
        Console.WriteLine("Expected Output:");
        char maxChar = FindMaxChar(maxCharString);
        int maxCharFrequency = CountCharFrequency(maxCharString, maxChar);
        Console.WriteLine("The Highest frequency of character '" + maxChar + "' appears number of times: " + maxCharFrequency);

        // Problem 11: Sort a string array in ascending order
        Console.WriteLine("\nProblem 11: Sort a string array in ascending order");
        Console.Write("Test Data: Input the string: ");
        string sortString = Console.ReadLine();
        Console.WriteLine("Expected Output:");
        string sortedString = SortString(sortString);
        Console.WriteLine("After sorting the string appears like:");
        Console.WriteLine(sortedString);

        // Problem 12: Read a string through the keyboard and sort it using bubble sort
        Console.WriteLine("\nProblem 12: Read a string through the keyboard and sort it using bubble sort");
        Console.Write("Test Data: Input number of strings: ");
        int numStrings = Convert.ToInt32(Console.ReadLine());
        string[] stringArray = new string[numStrings];
        Console.WriteLine("Input " + numStrings + " strings below:");
        for (int i = 0; i < numStrings; i++)
        {
            stringArray[i] = Console.ReadLine();
        }
        Console.WriteLine("Expected Output:");
        BubbleSort(stringArray);
        Console.WriteLine("After sorting the array appears like:");
        foreach (string str in stringArray)
        {
            Console.WriteLine(str);
        }
    }

    static bool CompareStrings(string firstString, string secondString)
    {
        if (firstString.Length != secondString.Length)
        {
            return false;
        }

        for (int i = 0; i < firstString.Length; i++)
        {
            if (firstString[i] != secondString[i])
            {
                return false;
            }
        }

        return true;
    }

    static string CopyString(string originalString)
    {
        char[] chars = originalString.ToCharArray();
        string copiedString = new string(chars);
        return copiedString;
    }

    static bool IsVowel(char c)
    {
        c = char.ToLower(c);
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }

    static char FindMaxChar(string str)
    {
        int[] charCount = new int[256];
        int maxCount = 0;
        char maxChar = '\0';

        foreach (char c in str)
        {
            charCount[c]++;
            if (charCount[c] > maxCount)
            {
                maxCount = charCount[c];
                maxChar = c;
            }
        }

        return maxChar;
    }

    static int CountCharFrequency(string str, char c)
    {
        int count = 0;
        foreach (char ch in str)
        {
            if (ch == c)
            {
                count++;
            }
        }
        return count;
    }

    static string SortString(string str)
    {
        char[] chars = str.ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }

    static void BubbleSort(string[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (string.Compare(arr[j], arr[j + 1]) > 0)
                {
                    string temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
