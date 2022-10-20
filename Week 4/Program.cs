// See https://aka.ms/new-console-template for more information

//
// using System.Threading.Channels;
//
// int[] rainfall = new int[12];
// Console.WriteLine("Please input 12 rainfall values in mm for a country");
//
//
// for (int i = 1; i <= 12; i++)
// {
//     Console.Write($"{i+1} Input:");
//     rainfall[i] = Template.CustomMethod.ParseStringToInt(Console.ReadLine());
// }
//
// for (int i = 1; i <= 12 ; i++)
// {
//     Console.WriteLine($"the month {i+1} had {rainfall[i]}mm of rain");
// }
//
// int avarge= 0;
// int total = 0;
// foreach (var i in rainfall)
// {
//     total += i;
// }
// avarge = total / rainfall.Length;
// Console.WriteLine($"the avarage of rainfall is {avarge}");

// Console.WriteLine($"the avarage of rainfall is {rainfall.Average()}");
// string[,] addressBook = new string[3, 2];
// for (int i = 0; i < 3; i++)
// {
//     Console.Write("Enter Name ");
//     addressBook[i, 0] = Console.ReadLine() ?? " " ;
//     Console.Write("Enter Address ");
//     addressBook[i, 1] = Console.ReadLine() ?? " " ;
// }
//
// Console.WriteLine("name , Address");
// Console.WriteLine("====================");
//
// for (var i = 0; i < 3; i++)
// {
//     Console.Write($"{addressBook[i,0]} , ");
//     Console.Write($"{addressBook[i,1]}");
//     Console.WriteLine();
// }

using System.Data;


Console.ReadKey();