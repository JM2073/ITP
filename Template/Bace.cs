    using static Template.CustomMethod;
    public class Bace
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
                        stay = SubMenu();
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

        private static bool SubMenu()
        {
            Console.Clear();

            Console.WriteLine($"are you ready {User.Name} some exercises.");
            Console.WriteLine("Pick your exercises");
            Console.WriteLine("1.)HELLO WORLD!!");
            Console.WriteLine("2.)Sum it up");

            Console.WriteLine($"type 'back' to return to the main menu");


            switch (Console.ReadLine() ?? string.Empty)
            {
                case "1":
                    Console.Clear();
                    return true;
                case "2":
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
    }
