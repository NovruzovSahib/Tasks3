using System.ComponentModel.Design;
using System;
internal partial class Program
{
    private static void Main(string[] args)
    {
        //Task1();
        //Task2();
        //Task3();
        //Task4();
        //Task5();
        //Task6();
        //Task7();
        //Task8();
        Task9();
        //Task10();
        //Task11();
        //Task12();

        Console.ReadLine();
    }

    public static void Task1()
    {
        int a, b, c;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine($"Big number is {a}");
        }
        else if (b > a && b > c)
        {
            Console.WriteLine($"Big number is {b}");
        }
        else if (c > a && c > b)
        {
            Console.WriteLine($"Big number is {c}");
        }


    }
    public static void Task2()
    {
        int a, b, c;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());

        if (a >= b && a > c)
        {
            Console.WriteLine($"Big number is {a}");
        }
        else if (b >= a && b > c)
        {
            Console.WriteLine($"Big number is {b}");
        }
        else if (c >= a && c > b)
        {
            Console.WriteLine($"Big number is {c}");
        }
        else
        {
            Console.WriteLine($"Numbers are equal");
        }

    }
    public static void Task3()
    {
        double a, b, result;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("sum - 1 minus - 2 multiplication - 3 divide - 4 module - 5");
        result = Convert.ToDouble(Console.ReadLine());
        switch (result)
        {
            case 1:
                Console.WriteLine(a + b);
                break;
            case 2:
                Console.WriteLine(a - b);
                break;
            case 3:
                Console.WriteLine(a * b);
                break;
            case 4:
                Console.WriteLine(a / b);
                break;
            case 5:
                Console.WriteLine(a % b);
                break;
            default:
                Console.WriteLine("İnvalid Operation");
                break;
        }

    }
    public static void Task4()
    {
        double a, b, result;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("sum - 1 minus - 2 multiplication - 3 divide - 4 module - 5");
        result = Convert.ToInt32(Console.ReadLine());

        if (result == 1)
        {
            Console.WriteLine(a + b);
        }
        else if (result == 2)
        {
            Console.WriteLine(a - b);
        }
        else if (result == 3)
        {
            Console.WriteLine(a * b);
        }
        else if (result == 4)
        {
            Console.WriteLine(a / b);
        }
        else if (result == 5)
        {
            Console.WriteLine(a % b);
        }
        else
        {
            Console.WriteLine("Invalid Operation");
        }
    }

    public static void Task5()
    {
        double a, b, result;
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        result = a + b;
        if (result > 100)
        {
            Console.WriteLine(b / 2 + a);
        }
        else
        {
            Console.WriteLine(result);
        }

    }


    public static void Task6()
    {
        int x = 5;
        int y = 0;
        int chance = 3;
        while (x != y)
        {
            Console.WriteLine("Enter a number");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("Enter a big number");
                chance--;
            }
            else if (y > x)
            {
                Console.WriteLine("Enter a small number");
                chance--;
            }
            if (chance == 0)
            {
                Console.WriteLine(" Your chance is off ");
                break;
            }
            else if (x == y)
            {
                Console.WriteLine(" Congratulations! ");
            }
        }
    }

    public static void Task7()
    {
        int x, y;
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());

        if (x > y)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("X is big and even number ");
            }
            else
            {
                Console.WriteLine("X is big and odd number");
            }
        }
        else if (y > x)
        {
            if (y % 2 == 0)
            {
                Console.WriteLine("Y is big and even number");
            }
            else
            {
                Console.WriteLine("Y is big and odd number");
            }
        }

    }

    public static void Task8()
    {
        Console.WriteLine("Enter Year of Month");
        string month = Console.ReadLine();

        switch (month)
        {
            case "January":
                Console.WriteLine("Winter");
                break;
            case "February":
                Console.WriteLine("Winter");
                break;
            case "March":
                Console.WriteLine("Spring");
                break;
            case "April":
                Console.WriteLine("Spring");
                break;
            case "May":
                Console.WriteLine("Spring");
                break;
            case "June":
                Console.WriteLine("Summer");
                break;
            case "July":
                Console.WriteLine("Summer");
                break;
            case "August":
                Console.WriteLine("Summer");
                break;
            case "September":
                Console.WriteLine("Fall");
                break;
            case "October":
                Console.WriteLine("Fall");
                break;
            case "November":
                Console.WriteLine("Fall");
                break;
            case "December":
                Console.WriteLine("Winter");
                break;
            default:
                Console.WriteLine("Enter only Months");
                break;
        }
    }

    public static void Task9()
    {
        Console.WriteLine("Welcome to the Millioner: ");
        Console.Write("Enter your full name: ");
        string name = Console.ReadLine();
        Console.WriteLine("What is the capital of Zambia?");
        Console.WriteLine("Lusaka - 1 Kasama - 2 Mazabuka - 3 Kitwe - 4 50%50 - ");
        int question = Convert.ToInt32(Console.ReadLine());
        switch (question)
        {
            case 1:
                Console.WriteLine("You won 1 million dollars");
                break;
            case 2:
                Console.WriteLine("You have lost ");
                break;
            case 3:
                Console.WriteLine("You have lost");
                break;
            case 4:
                Console.WriteLine("You have lost");
                break;
            case 5:
                Console.WriteLine("Lusaka - 1 Kasama - 2");
                int question2 = Convert.ToInt32(Console.ReadLine());
                switch (question2)
                {
                    case 1:
                        Console.WriteLine("You won 1 million dollars");
                        break;
                    case 2:
                        Console.WriteLine("You have lost ");
                        break;
                }
                break;
            default:
                Console.WriteLine("Choose between 1 and 5");
                break;

        }

    }

    public static void Task10()
    {
        double x, y, z;
        Console.Write( "x: " );
        x = Convert.ToDouble(Console.ReadLine());

        Console.Write("y: ");
        y = Convert.ToDouble(Console.ReadLine());

        Console.Write("z: ");
        z = Convert.ToDouble(Console.ReadLine());

        if (x+y>z)
        {
            Console.WriteLine("İt is Equilateral triangle");
        }
        else
        {
            Console.WriteLine("İt is not Equilateral triangle");
        }
    }
    public static void Task11()
    {
        int dayofweek = Convert.ToInt32(Console.ReadLine());
        switch (dayofweek)
        {
            case 1: Console.WriteLine("monday");
                break;
            case 2:
                Console.WriteLine("tuesday");
                break;
            case 3:
                Console.WriteLine("wednesday");
                break;
            case 4:
                Console.WriteLine("thursday");
                break;
            case 5:
                Console.WriteLine("friday");
                break;
            case 6:
                Console.WriteLine("saturday");
                break;
            case 7:
                Console.WriteLine("sunday");
                break;
            default:
                Console.WriteLine("Enter only weekdays");
                break;
        }

    }

    public static void Task12()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1: Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
            case 10:
                Console.WriteLine("Ten");
                break;
            default:
                Console.WriteLine( "Enter only between 1 and 10 numbers");
                break;
        }

    }
}






