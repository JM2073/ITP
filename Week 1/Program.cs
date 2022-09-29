namespace Week_1
{
    using static Template.CustomMethod;

    class Program
    {
        private static class User
        {
            public static readonly string Name = GetName();
        }

        public static void Main()
        {
            var showMenu = true;
            Console.WriteLine("welcome to the class " + User.Name);

            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.WriteLine($"\nwhat would you like to do {User.Name}?\n");
            Console.WriteLine("1.)check the time");
            Console.WriteLine("2.)check the date");
            Console.WriteLine("3.)start Exercises");
            Console.WriteLine("4.)Close Application");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("The Current Time is: " + DateTime.Now.ToString("hh:mm:ss"));
                    return true;
                case "2":
                    Console.Clear();
                    Console.WriteLine("The Current Time is: " + DateTime.Now.Date.ToString("dd/MM/yyyy"));
                    return true;
                case "3":
                    var stay = true;
                    while (stay)
                    {
                        stay = ExercisesMenu();
                    }

                    return true;
                case "4":
                    Console.WriteLine("Have a grate day!");
                    Console.WriteLine("Press any key to close.");
                    Console.ReadKey();

                    return false;

                default:
                    Console.WriteLine("Please Pick a valid option.");

                    return true;
            }
        }

        private static bool ExercisesMenu()
        {
            Console.Clear();

            Console.WriteLine($"are you ready {User.Name} some exercises.");
            Console.WriteLine("Pick your exercises");
            Console.WriteLine("1.)HELLO WORLD!!");
            Console.WriteLine("2.)Sum it up");
            Console.WriteLine("3.)");
            Console.WriteLine("4.)");
            Console.WriteLine("5.)");
            Console.WriteLine("6.)");
            Console.WriteLine("7.)");
            Console.WriteLine("8.)");
            Console.WriteLine("9.)");
            Console.WriteLine("10.)");

            Console.WriteLine($"type 'back' to return to the main menu");


            switch (Console.ReadLine() ?? string.Empty)
            {
                case "1":
                    ExercisesOne();
                    Console.Clear();
                    return true;
                case "2":
                    ExercisesTwo();
                    Console.Clear();
                    return true;
                case "3":
                    ExercisesThree();
                    Console.Clear();
                    return true;
                case "4":
                    ExercisesFour();
                    Console.Clear();
                    return true;
                case "5":
                    ExercisesFive();
                    Console.Clear();
                    return true;
                case "6":
                    ExercisesSix();
                    Console.Clear();
                    return true;
                case "7":
                    ExercisesSeven();
                    Console.Clear();
                    return true;
                case "8":
                    ExercisesEight();
                    Console.Clear();
                    return true;
                case "9":
                    ExercisesNine();
                    Console.Clear();
                    return true;
                case "10":
                    ExercisesTen();
                    Console.Clear();
                    return true;
                case "back":

                    Console.Clear();
                    return false;
                default:
                    Console.WriteLine("Please Pick a valid option.");
                    return true;
            }
        }

        private static string GetName()
        {
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.Write("Please enter a valid name: ");
                name = Console.ReadLine();
            }

            return name;
        }

        private static void ExercisesOne()
        {
            var name = "Johnathon Rhys Millard";
            Console.WriteLine("Print hello world and your name on separate lines. (hardcoded name var)");
            Console.WriteLine("Hello World");
            Console.WriteLine(name);
            Console.WriteLine("press any key to continue.");
            Console.ReadKey();
        }

        private static void ExercisesTwo()
        {
            var numberOne = 2;
            var numberTwo = 5;
            Console.WriteLine("print the result of adding two numbers together (hardcoded number vars)");
            Console.WriteLine("first number: 2");
            Console.WriteLine("second number: 5");
            var sum = numberOne + numberTwo;
            Console.WriteLine(sum.ToString());
            Console.WriteLine("press any key to continue.");
            Console.ReadKey();
        }

        private static void ExercisesThree()
        {
            int numberOne = 15;
            int numberTwo = 3;
            Console.WriteLine("print the result of dividing two numbers (hardcoded number vars)");
            Console.WriteLine("first number: 15");
            Console.WriteLine("second number: 3");
            int sum = numberOne / numberTwo;
            Console.WriteLine(sum.ToString());
            Console.WriteLine("press any key to continue.");
            Console.ReadKey();
        }

        private static void ExercisesFour()
        {
            int sumOne = -1 + 4 * 6;
            int sumTwo = (35 + 5) % 7;
            int sumThree = 14 + -4 * 6 / 11;
            int sumFour = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine("print the result sums (hardcoded vars)");
            Console.WriteLine($"first sum: -1 + 4 * 6 = {sumOne}");
            Console.WriteLine($"second sum: ( 35 + 5 ) % 7 = {sumTwo}");
            Console.WriteLine($"third sum: 14 + -4 * 6 / 11 = {sumThree}");
            Console.WriteLine($"fourth sum: 2 + 15 / 6 * 1 - 7 % 2 = {sumFour}");

            Console.WriteLine("press any key to continue.");
            Console.ReadKey();
        }

        private static void ExercisesFive()
        {
            Console.WriteLine("swap numbers (User entered vars)\n");

            Console.Write("First number: ");
            var firstNum = ParseStringToInt(Console.ReadLine());
            Console.Write("Second number: ");
            var secondNum = ParseStringToInt(Console.ReadLine());

            (firstNum, secondNum) = (secondNum, firstNum);

            Console.WriteLine();
            Console.WriteLine($"swapped First number: {firstNum}");
            Console.WriteLine($"swapped Second number: {secondNum}");

            Console.WriteLine("press any key to continue.");
            Console.ReadKey();
        }

        private static void ExercisesSix()
        {
            Console.WriteLine("multiply three example  (user entered var)");

            Console.Write("First number: ");
            var firstNum = ParseStringToInt(Console.ReadLine());
            Console.Write("Second number: ");
            var secondNum = ParseStringToInt(Console.ReadLine());
            Console.Write("third number: ");
            var thirdNum = ParseStringToInt(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"{firstNum} x {secondNum} x {thirdNum} = {firstNum * secondNum * thirdNum}");
            Console.WriteLine("press any key to continue.");
            Console.ReadKey();
        }

        private static void ExercisesSeven()
        {
            Console.WriteLine("MATH");

            Console.Write("First number: ");
            var firstNum = ParseStringToInt(Console.ReadLine()!);
            Console.Write("Second number: ");
            var secondNum = ParseStringToInt(Console.ReadLine());

            Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum} ");
            Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum} ");
            Console.WriteLine($"{firstNum} x {secondNum} = {firstNum * secondNum} ");
            Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / secondNum} ");
            Console.WriteLine($"{firstNum} % {secondNum} = {firstNum % secondNum} ");
            Console.WriteLine("press any key to continue.");
            Console.ReadKey();
        }

        private static void ExercisesEight()
        {
            Console.WriteLine("MATH times Table");

            Console.Write("number: ");
            var firstNum = ParseStringToInt(Console.ReadLine());

            Console.Write("upto how many: ");
            var secondNum = ParseStringToInt(Console.ReadLine());

            //inorder to make sure the console displays the correct number of results, we increment there chosen amount by one
            for (int i = 1; i < secondNum + 1; i++)
            {
                Console.WriteLine($"{firstNum} x {i} = {firstNum * i}");
            }

            Console.WriteLine("press any key to continue.");
            Console.ReadKey();
        }

        private static void ExercisesNine()
        {
            Console.WriteLine("math AVERAGE (user entered var)");

            Console.Write("First number: ");
            var firstNum = ParseStringToInt(Console.ReadLine());
            Console.Write("Second number: ");
            var secondNum = ParseStringToInt(Console.ReadLine());
            Console.Write("third number: ");
            var thirdNum = ParseStringToInt(Console.ReadLine());
            Console.Write("forth number: ");
            var forthNum = ParseStringToInt(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(
                $"the average of {firstNum} {secondNum} {thirdNum} {forthNum} is : {firstNum + secondNum + thirdNum + forthNum / 4} ");
            Console.WriteLine("press any key to continue.");
            Console.ReadKey();
        }

        private static void ExercisesTen()
        {
            Console.WriteLine("math average (user entered var)");

            Console.Write("First number: ");
            var firstNum = ParseStringToInt(Console.ReadLine());
            Console.Write("Second number: ");
            var secondNum = ParseStringToInt(Console.ReadLine());
            Console.Write("third number: ");
            var thirdNum = ParseStringToInt(Console.ReadLine());
            Console.Write("forth number: ");
            var forthNum = ParseStringToInt(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(
                $"the average of {firstNum} {secondNum} {thirdNum} {forthNum} is : {firstNum + secondNum + thirdNum + forthNum / 4} ");
            Console.WriteLine("press any key to continue.");
            Console.ReadKey();
        }

       
    }

}

