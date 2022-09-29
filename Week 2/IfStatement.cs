namespace Week_2
{
    public class IfStatement
    {
        public static void Main()
        {
            Console.WriteLine("how old are you?");
            var age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("have you got your ID mate? yes or no");
                var ageId = Console.ReadLine();
                if (ageId.Equals("yes"))
                {
                    Console.WriteLine("lets buy you a beer!");
                }
                else
                {
                    Console.WriteLine("sorry mate, a coke it is for you");
                }
            }
            else
            {
                Console.WriteLine("sorry mate, a coke it is for you");
            }

            Console.ReadKey();
        }
    }
}