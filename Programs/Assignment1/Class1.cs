using System;

class Program
{
    static void Main(string[] args)
    {
        // Check if a string is a palindrome
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        if (IsPalindrome(str))
        {
            Console.WriteLine("{0} is a palindrome.", str);
        }
        else
        {
            Console.WriteLine("{0} is not a palindrome.", str);
        }

        // Check if a number is a palindrome
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());

        if (IsPalindrome(n))
        {
            Console.WriteLine("{0} is a palindrome.", n);
        }
        else
        {
            Console.WriteLine("{0} is not a palindrome.", n);
        }
    }

    // Function to check if a string is a palindrome
    static bool IsPalindrome(string str)
    {
        int i = 0;
        int j = str.Length - 1;

        while (i < j)
        {
            if (str[i] != str[j])
            {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }

    // Function to check if a number is a palindrome
    static bool IsPalindrome(int n)
    {
        int temp = n;
        int reverse = 0;

        while (temp > 0)
        {
            int digit = temp % 10;
            reverse = reverse * 10 + digit;
            temp /= 10;
        }

        return n == reverse;
    }
}
