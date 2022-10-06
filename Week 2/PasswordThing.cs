namespace Week_2;
public class PasswordThing
{
    public static void StartPasswordThing()
    {
        Console.WriteLine("please enter your password:");
        var password = Console.ReadLine()!;

        Console.WriteLine("pleas reenter your password:");
        var passwordCheck = Console.ReadLine();

        if (password.Equals(passwordCheck))
        {
            Console.WriteLine("welcome to the matrix");
        }
        else
        {
            Console.WriteLine("passwords didnt match sorry");
        }
    }

    
}