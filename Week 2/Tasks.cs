namespace Week_2;
// https://www.w3resource.com/csharp-exercises/conditional-statement/index.php

public class Tasks
{
    public static void TaskOne()
    {
        Console.WriteLine("checking input");
        Console.Write("first input: ");
        var firstInput = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("second input: ");
        var secondInput = Convert.ToInt32(Console.ReadLine());

        if (firstInput == secondInput)
        {
            Console.WriteLine($"both values are the same {firstInput} and {secondInput}");
        }
        else
        {
            Console.WriteLine($"both values are the different {firstInput} and {secondInput}");
        }
    }

    public static void TaskTwo()
    {
        Console.WriteLine("checking input is even or odd");
        Console.Write("input: ");
        var input = Convert.ToInt32(Console.ReadLine());

        if ((input % 2) != 0)
        {
            Console.WriteLine($"{input} is an odd number");
        }
        else
        {
            Console.WriteLine($"{input} is an even number");
        }
    }

    public static void TaskThree()
    {
        Console.WriteLine("checking input is pos or neg");
        Console.Write("input: ");
        var input = Convert.ToInt32(Console.ReadLine());

        if (input >= 0)
        {
            Console.WriteLine($"{input} is a postive number");
        }
        else
        {
            Console.WriteLine($"{input} is a negtive number");
        }
    }

    public static void TaskForth()
    {
        Console.WriteLine("checking input is a leep year");
        Console.Write("input: ");
        var input = Convert.ToInt32(Console.ReadLine());

        if ((input % 400) == 0)
        {
            Console.WriteLine($"{input} is a leep year");
        }
        else if ((input % 100) == 0)
        {
            Console.WriteLine($"{input} is not a leep year");
        }
        else if ((input % 4) == 0)
        {
            Console.WriteLine($"{input} is a leep year");
        }
        else
        {
            Console.WriteLine($"{input} is not a leep year");
        }
    }

    public static void TaskFive()
    {
        Console.WriteLine("checking the user is old enough to vote");
        Console.Write("input: ");
        var input = Convert.ToInt32(Console.ReadLine());

        if (input >= 18)
        {
            Console.WriteLine("congrats your old enough to vote!");
        }
        else
        {
            Console.WriteLine("sorry you cant vote yet.");
        }
    }

    public static void TaskSix()
    {
        Console.WriteLine("gratter or less than or equels to zero custom output");
        Console.Write("input: ");
        var input = Convert.ToInt32(Console.ReadLine());
        int result;
        if (input > 0)
        {
            result = 1;
        }
        else if (input == 0)
        {
            result = 0;
        }
        else
        {
            result = -1;
        }

        Console.WriteLine($"the value of the input is {result}");
    }

    public static void TaskSeven()
    {
        Console.WriteLine("cat people acording to hight ");
        Console.Write("input: ");
        var input = Convert.ToInt32(Console.ReadLine());
        if (input < 150.0)
        {
            Console.WriteLine("this person is defantly short");
        }
        else if (input >= 150.0 && input < 165.0)
        {
            Console.WriteLine("this person is about avrage");
        }
        else if (input >= 165.0 && input <= 195.0)
        {
            Console.WriteLine("this is one tall boi");
        }
        else
        {
            Console.WriteLine("abnormal hight");
        }
    }

    public static void TaskAfterSeven()
    {
        Console.WriteLine("Find the gratest number out of three user input numbers");
        
        Console.Write("First input: ");
        var firstInput = Convert.ToInt32(Console.ReadLine());
        Console.Write("second input: ");
        var secondInput = Convert.ToInt32(Console.ReadLine());
        Console.Write("thrid input: ");
        var thridInput = Convert.ToInt32(Console.ReadLine());

        if (firstInput > secondInput && firstInput > thridInput)
        {
            Console.WriteLine("first imput was gratest");
        }
        else if (secondInput > firstInput && secondInput > thridInput)
        {
            Console.WriteLine("second input was gratest");
        }
        else
        {
            Console.WriteLine("thrid input was gratest");
        }
    }

    public static void TaskNine()
    {
        Console.WriteLine("find the quad of the input values xy styley");
        Console.WriteLine();
        Console.Write("x cord plaz: ");
        var xCord = Convert.ToInt32(Console.ReadLine());
        Console.Write("y cord plaz: ");
        var yCord = Convert.ToInt32(Console.ReadLine());

        if (xCord > 0 && yCord > 0)
        {
            Console.WriteLine($"the cords ({xCord},{yCord}) is in the first quad");
        } 
        else if (xCord < 0 && yCord > 0)
        {
            Console.WriteLine($"the cords ({xCord},{yCord}) is in the second quad");
        }
        else if (xCord < 0 && yCord < 0)
        {
            Console.WriteLine($"the cords ({xCord},{yCord}) is in the thrid quad");
        }
        else if (xCord > 0 && yCord < 0)
        {
            Console.WriteLine($"the cords ({xCord},{yCord}) is in the thrid quad");
        }
        else if (xCord == 0 && yCord == 0)
        {
            Console.WriteLine($"the cords ({xCord},{yCord}) is orgin");
        }
    }
}