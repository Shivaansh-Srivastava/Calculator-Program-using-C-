using System;
class sample
{
   static void sum(int x, int y)
    {
        int z = x + y;
        Console.WriteLine("The sum is: " + z);
    }
    static void diff(int x, int y)
    {
        int z = (x > y) ? x - y : y - x;
        Console.WriteLine("The difference is: " + z);
    }
    static void product(int x, int y)
    {
        int z = x * y;
        Console.WriteLine("The product is: " + z);
    }
    static void div(int x, int y)
    {
        if(x==0 || y == 0)
        {
            Console.WriteLine("One of the inputs is zero. Enter again properly.");
        }
        else
        {
            int z = (x > y) ? x / y : y / x;
            Console.WriteLine("The division result is: " + z);
        }
    }

    public static void Main()
    {
        Console.WriteLine("Choose from the following:");
        Console.WriteLine("-> 1.Sum");
        Console.WriteLine("-> 2.Difference");
        Console.WriteLine("-> 3.Product");
        Console.WriteLine("-> 4.Division");
        Console.WriteLine("Choose the option:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Number 1:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Number 2:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        switch (x)
        {
            case 1:
                sum(num1, num2);
                break;
            case 2:
                diff(num1, num2);
                break;
            case 3:
                product(num1, num2);
                break;
            case 4:
                div(num1, num2);
                break;
            default:
                Console.WriteLine("Enter a valid operation code.");
                break;
        }
    }
}