namespace Week_3;
/*
 1. Write an if-statement that takes two integer variables and  exchanges
 their values if the first one is greater than the second one.
 2. Write a program that shows the sign (+ or -) of the product of three real 
 numbers, without calculating it. Use a sequence of if operators.
 3. Write a program that finds the biggest of three integers, using nested
 if statements.
 4. Sort 3 real numbers in descending order. Use nested if statements.
 5. Write a program that asks for a digit (0-9), and depending on the input,
 shows the digit as a word (in English). Use a switch statement.
 6. Write  a  program  that  gets  the  coefficients  a,  b  and  c  of  a  quadratic 
 equation: ax2 + bx + c, calculates  and  prints  its  real  roots  (if  they  exist). 
 Quadratic equations may have 0, 1 or 2 real roots.
 7. Write a program that finds the greatest of given 5 numbers.
 8. Write a program that, depending on the user’s choice, inputs int, double 
 or string variable. If the variable is int or double, the program increases it 
 by 1. If the variable is a string, the program appends "*" at the end. Print 
 the result at the console. Use switch statement.
 9. We  are  given  5  integer  numbers.  Write  a  program  that  finds  those
 subsets whose sum is 0. Examples:
 - If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1
 is 0.
 - If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets
 with sum 0.
 10. Write a program that applies bonus points to given scores in the range 
 [1...9] by the following rules:
 - If the score is between 1 and 3, the program multiplies it by 10.
 - If the score is between 4 and 6, the program multiplies it by 100.
 - If the score is between 7 and 9, the program multiplies it by 1000.
 - If  the  score  is  0  or  more  than  9,  the  program  prints  an  error 
 message.
 11. * Write a program that converts a number in the range [0...999] to 
 words, corresponding to the English pronunciation. Examples:
 -    0 --> "Zero"
 -    12 --> "Twelve"
 - 98 --> "Ninety eight"
 - 273 --> "Two hundred seventy three"
 - 400 --> "Four hundred"
 - 501 --> "Five hundred and one"
*/
public class Exercises
{
    public static void StartExercises()
    {
        Dice();
        // FooTask();
        // SetTasks();

        Console.WriteLine("END APP");
        Console.ReadKey();
    }

    private static void Dice()
    {
        var ran = new Random();
        int total = 0, diceOne = 0, diceTwo = 0, diceThree = 0, diceFore = 0, diceFive = 0, diceSix = 0;
        Console.WriteLine("lets roll some dice.");
        Console.Write("how many dice would you like to roll?");
        var rollCount = Convert.ToInt32(Console.ReadLine());
        for (var i = 0; i < rollCount; i++)
        {
            var roll = ran.Next(1,7);
            Console.WriteLine($"you rolled a {roll}");  
            total += roll;
            switch (roll)
            {
                case 1:
                    diceOne++;
                    break;
                case 2:
                    diceTwo++;
                    break;
                case 3:
                    diceThree++;
                    break;
                case 4:
                    diceFore++;
                    break;
                case 5:
                    diceFive++;
                    break;
                case 6:
                    diceSix++;
                    break;
                default:
                    throw new Exception();
                    break;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"you rolled a one {diceOne} times");
        Console.WriteLine($"you rolled a two {diceTwo} times");
        Console.WriteLine($"you rolled a three {diceThree} times");
        Console.WriteLine($"you rolled a fore {diceFore} times");
        Console.WriteLine($"you rolled a five {diceFive} times");
        Console.WriteLine($"you rolled a six {diceSix} times\n");
        Console.WriteLine($"the total of the dice rolls are {total}");
    }

    private static void SetTasks()
    {
        Console.WriteLine("Task one!\n");

        Console.WriteLine("please enter two values:");
        Console.Write("value 1: ");
        var val1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("value 2: ");
        var val2 = Convert.ToInt32(Console.ReadLine());

        if (val1 > val2)
        {
            (val1, val2) = (val2, val1);
        }

        Console.WriteLine($"value 1 is {val1}, value 2 is {val2}");
        Console.WriteLine("if the original first value was bigger it would of been swapped with the second value.\n\n");

        Console.WriteLine("Task two!\n");
    }

    private static void FooTask()
    {
        var rand = new Random();
        bool choiceOp;
        int firstNum = 0, secondNum = 0;

        Console.WriteLine("lets do some math\n\n");

        Console.WriteLine("would you like to use user input or randome numbers");
        Console.WriteLine("1.) user input");
        Console.WriteLine("2.) randome numbers");
        choiceOp = true;
        do
        {
            var input = Console.ReadLine();
            if (input == "1")
            {
                Console.Write("Please enter a number: ");
                firstNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please another number: ");
                secondNum = Convert.ToInt32(Console.ReadLine());
                choiceOp = false;
            }
            else if (input == "2")
            {
                firstNum = rand.Next(0, 100);
                secondNum = rand.Next(0, 100);
                choiceOp = false;
            }
            else
            {
                Console.WriteLine("please select an option.");
            }
        } while (choiceOp);

        Console.WriteLine($"the first number is {firstNum}\nthe second number is {secondNum}");

        Console.WriteLine("please choice witch opration you would like to preform.");
        Console.WriteLine("your choises are between + * / - %");
        var result = string.Empty;
        choiceOp = true;
        do
        {
            var function = Convert.ToChar(Console.ReadLine());
            switch (function)
            {
                case '*':
                    result = (firstNum * secondNum).ToString();
                    choiceOp = false;
                    break;
                case '+':
                    result = (firstNum + secondNum).ToString();
                    choiceOp = false;
                    break;
                case '-':
                    result = (firstNum - secondNum).ToString();
                    choiceOp = false;
                    break;
                case '/':
                    result = (firstNum / secondNum).ToString();
                    choiceOp = false;
                    break;
                case '%':
                    result = (firstNum % secondNum).ToString();
                    choiceOp = false;
                    break;
                default:
                    Console.Write("please use the corresponding simble ");
                    break;
            }
        } while (choiceOp);

        Console.WriteLine($"the result of your operation is: {result}");
    }
}