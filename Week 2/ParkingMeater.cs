// See https://aka.ms/new-console-template for more information
using static Template.CustomMethod;

//var parkingTime = 120;
//var amountPaid = 5;
var costPerHour = 1.30;

Console.WriteLine("User Inputted verse");
Console.Write("how much have you paid? £");
double amountPaid = 0;
/*
var loop = true;
while (loop) // getting amountPaid
{
    var value = Console.ReadLine();
    var pass = double.TryParse(value,out amountPaid);
    if (!pass)
    {
        Console.Write("please enter a valid value: ");
        value = Console.ReadLine();
    }
    else
    {
        loop = false;
    }
}
*/

Console.Write("how long will you be staying? (in minutes)  ");
double parkingTime = 0;

// while (loop) // getting parking hours
// {
//     var value = Console.ReadLine();
//     var pass = double.TryParse(value,out parkingTime);
//     if (!pass)
//     {
//         Console.Write("please enter a valid value: ");
//         value = Console.ReadLine();
//     }
//     else
//     {
//         loop = false;
//     }
// }


Console.WriteLine("Parking!");
Console.WriteLine($"the person has paid £{amountPaid}");
Console.WriteLine($"the cost per hour is £{costPerHour}");
Console.WriteLine($"the person has parked for {parkingTime}");
Console.WriteLine();

var hoursParked = parkingTime / 60;
var charge = costPerHour * hoursParked;

Console.WriteLine($"the person was parked for {hoursParked} hours");
Console.WriteLine($"the person was charged £{charge}");
Console.WriteLine();

var change = (int)(amountPaid - charge) * 100;

var pounds = change / 100;
change = change % 100;

var fifty = change / 50;
change = change % 50;

var twenty = change / 20;
change = change % 20;

var ten = change / 10;
change = change % 10;

var five = change / 5;
change = change % 5;

var two = change / 2;
change = change % 2;

var one = change / 1;

Console.WriteLine("change output;");
Console.WriteLine($"pounds {pounds}");
Console.WriteLine($"fifty pence {fifty}");
Console.WriteLine($"twenty pence {twenty}");
Console.WriteLine($"ten pence {ten}");
Console.WriteLine($"five pence {five}");
Console.WriteLine($"two pence {two}");
Console.WriteLine($"one pence {one}");

Console.ReadKey();