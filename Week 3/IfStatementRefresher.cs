namespace Week_3;
public static class IfStatementRefresher
{
    public static void Main()
    {
        Console.WriteLine("Henlo!!");
        Console.WriteLine("please enter your results for your credit modules :D");

        Console.Write("Modle 1 (0-15): ");
        var modOne =  Convert.ToInt32(Console.ReadLine());

        Console.Write("Modle 2 (0-15): ");
        var modTwo =  Convert.ToInt32(Console.ReadLine());

        Console.Write("Modle 3 (0-15): ");
        var modThree =  Convert.ToInt32(Console.ReadLine());

        Console.Write("Modle 4 (0-15): ");
        var modFore =  Convert.ToInt32(Console.ReadLine());

        Console.Write("Modle 5 (0-15): ");
        var modFive =  Convert.ToInt32(Console.ReadLine());

        Console.Write("Modle 6 (0-15): ");
        var modSix = Convert.ToInt32(Console.ReadLine());

        var total = modOne + modTwo + modThree + modFore + modFive + modSix;

        switch (total)
        {
            case > 0 and <= 34:
                Console.WriteLine("im afraid thats a fail for you.");
                break;
                
            case 40:
                Console.WriteLine("you have acheved the bare min to pass");
                break;
                
            case > 40 and <= 49:
                Console.WriteLine("you have gotten a 3rd. try harder next time!");
                break;
                
            case >= 50 and <= 59:
                Console.WriteLine("This is a 2:2 score, you did your best.");
                break;
                
            case >= 60 and <= 69:
                Console.WriteLine("this is a 2:1 score: a respectable score, be proud! ");
                break;
                
            case 70:
                Console.WriteLine("weldone top markes for you, you got a 1st :D ");
                break;
            default:
                Console.WriteLine("well that wasn't meant to happen. ");        
                break;
        }        
    }    
}