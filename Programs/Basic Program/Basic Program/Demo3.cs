
//stub

/*using System;
class Demo3
{
    public void Big2Num()
    {
        Console.WriteLine("Enter 2 numbers for comparison");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 == number2)
        {
            Console.WriteLine($"{number1} and {number2} are equal");
        }
        else if (number1 > number2)
        {
            Console.WriteLine($"{number1} is greater than {number2}");
        }
        else
        {
            Console.WriteLine($"{number1} is lesser than {number2}");
        }
    }
    public void Big3Num()
    {
        Console.WriteLine("Enter 3 numbers for comparison");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        int number3 = Convert.ToInt32(Console.ReadLine());

        if ((number1 == number2) && (number2==number3))
        {
            Console.WriteLine($"{number1} and {number2} and {number3} are equal");
        }
        else if ((number1 > number2) && (number1 > number3))
        {
            Console.WriteLine($"{number1} is greater than {number2} and {number3}");
        }
        else if ((number2 > number3) && (number2 > number1))
        {
            Console.WriteLine($"{number2} is greater than {number1} and {number3}");
        }
        else
        {
            Console.WriteLine($"{number3} is greater than {number1} and {number2}");
        }
    }
    public void do_loop()
    {
        Console.WriteLine("Enter the max value");
        int max, cou = 1, sum = 0;
        max = Convert.ToInt32(Console.ReadLine());
        do
        {
            sum += cou;
            cou++;
        }
        while (cou <= max);
        Console.WriteLine("Total : " + sum);
    }
    public void while_loop()
    {
        Console.WriteLine("Enter the max value");
        int max, cou = 1, sum = 0;
        max = Convert.ToInt32(Console.ReadLine());
        while (cou <= max)
        {
            sum += cou;
            cou++;
        }
        Console.WriteLine("Total : " + sum);
    }
    public int for_loop(int max)
    {
        int sum = 0;
        for (int cou = 1; cou<=max;cou++)
        {
            sum += Convert.ToInt32(Math.Pow(cou, 2));
        }
        return sum;
    }
    
    public void for_each(string s1)
    {
        foreach(char s in s1)
        {
            Console.WriteLine(s);
        }
    }

    public void array_display()
    {
        // int[] nums = new int[10];
        int[] nums1 = { 170, 10, 300, 40 };
        int[, ] nums2 = { { 10, 20}, { 30, 40 } };

        Array.Sort(nums1);
        foreach (int temp in nums1)
        {
            Console.WriteLine(temp);
        }

        string[] cars = { "Volvo", "Audi", "Benz" };
        cars[1] = "RR";
        foreach(string car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
*/