// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Welcome to the number sorter");
// int[] arr = new int[5];
//
// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write("enter a number :");
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
//
//
// Console.WriteLine("orignal order");
// for (int i = 0; i < arr.Length; i++)
//     Console.Write(arr[i] + " ");
//
//
// int temp = 0;
//
// for (int write = 0; write < arr.Length; write++) {
//     for (int sort = 0; sort < arr.Length - 1; sort++) {
//         if (arr[sort] > arr[sort + 1]) {
//             temp = arr[sort + 1];
//             arr[sort + 1] = arr[sort];
//             arr[sort] = temp;
//         }
//     }
// }
//
// Console.WriteLine("sorted order");
// for (int i = 0; i < arr.Length; i++)
//     Console.Write(arr[i] + " ");
//
// Console.WriteLine();
// Console.WriteLine($"your highest number is: {arr[4]}");
// Console.WriteLine($"your lowest number is: {arr[0]}");
//

using System.Runtime.CompilerServices;

Console.WriteLine("welcome to the shiitake mushroom show ");
//
// void message()
// {
//     Console.WriteLine("hello world");    
// }
//
// double valvArea(int raidus)
// {
//     return Math.PI * (raidus * raidus);
// }
//
// double valCurc(int raidus)
// {
//     return 2 * Math.PI  * raidus;
// }
//
// message();
// message();
// message();
//
// Console.WriteLine("please enter raidus.");
// int raidus = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine($"the area is {valCurc(raidus)}");
// Console.WriteLine($"the curm is {valvArea(raidus)}");

bool isNegtive = false;


List<int> NumbersIn(int value)
{
    if (value == 0) return new List<int>();

    var numbers = NumbersIn(value / 10);

    numbers.Add(value % 10);

    return numbers;
}

string Letterize(int number)
{
    string numText = string.Empty;

    if (number < 0)
    {
        isNegtive = true;
        number *= -1;
    }

    var numlist = NumbersIn(number);

    numText += isNegtive ? "minus " : " ";

    foreach (var num in numlist)
    {
        numText += num switch
        {
            1 => " one ",
            2 => " Two ",
            3 => " Three ",
            4 => " fore ",
            5 => " five ",
            6 => " six ",
            7 => " Seven ",
            8 => " eight ",
            9 => " nine ",
            0 => " zero ",
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    return numText;
}

Console.WriteLine("please enter a number between -999 and 999");
int choice = Convert.ToInt32(Console.ReadLine());

if (choice > 999 || choice < -999)
    Console.WriteLine($"too {(choice > 999 ? "large" : "small")}");
else
    Console.WriteLine(Letterize(choice));

//
// int number;
//
// string Letterize(int number)
// {
//     bool isNegtive = false;
//
//     if (number < 0)
//     {
//         isNegtive = true;
//         number *= -1;
//     }
//
//     string[] numbers = { "one", "two", "three", "fore", "five", "six", "seven", "eight", "nine", "zero" };
//
//     int hundreds = number / 100;
//     number %= 100;
//     int tens = number / 10;
//     number %= 10;
//
//     return $"{(isNegtive ? "minus" : "")} {numbers[hundreds - 1]} {numbers[tens - 1]} {numbers[number - 1]}";
// }
//
// Console.WriteLine("please enter a number between -999 and 999");
// number = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine($"Number is {Letterize(number)}");

Console.ReadKey();