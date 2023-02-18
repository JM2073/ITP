using System.Net.Security;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Week_6;

namespace Template
{
    
    public class ATM
    {
        public static User _currentUser = new ();
        public static bool _showMenu = false;
        
        public static void Main()
        {
            var access = false;
            while(access == false)
            {
                Console.WriteLine("AtM of the city of gold bank");
                Console.WriteLine("please enter your pin:");

                var pin = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(pin) == false && pin.Length == 4 )
                {
                    
                    access = _currentUser.BankAccount.CheckPin(pin);
                    if (access == false)
                    {
                        Console.WriteLine("Incorrect pin please try again.");
                    }                    
                }
                else
                {
                    Console.WriteLine("please enter a valid pin");
                }
                Console.Clear();
            }
            
            _showMenu = true;
            while (_showMenu)
            {
                
                _showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();

            Console.WriteLine("welcome to the ATM");
            Console.WriteLine($"\nwhat would you like to do {_currentUser.Name}?\n");
            Console.WriteLine("1.)View Balance");
            Console.WriteLine("2.)Withdraw Money");
            Console.WriteLine("3.)Deposit Money");
            Console.WriteLine("4.)Change Pin Number");
            Console.WriteLine("5.)Exit");

            Console.WriteLine();
            double amount = 0;
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"your current balance is {_currentUser.BankAccount.ViewBalance()}");
                break;
                case "2":
                    Console.Write("Please Enter the amount of money you wish to withdraw: ");
                    amount = CustomMethod.ParseStringToDouble(Console.ReadLine());
                    _currentUser.BankAccount.Withdraw(amount);
                    Console.WriteLine($"Money Withdrawn your new balance is: {_currentUser.BankAccount.ViewBalance()}");
                break;
                case "3":
                    Console.Write("Please Enter the amount of money you wish to deposit: ");
                    amount = CustomMethod.ParseStringToDouble(Console.ReadLine());
                    _currentUser.BankAccount.Deposit(amount);
                    Console.WriteLine($"Money Deposited your new balance is: {_currentUser.BankAccount.ViewBalance()}");
                    break;
                case "4":
                    Console.Write("Please enter what youwish to change your pin to: ");
                    var newPin = Console.ReadLine();
                    var errors = newPin.Length != 4 && int.TryParse(newPin,out _) == false;
                    
                    while (errors)
                    {
                        Console.Write("please enter a valid Pin: ");
                       newPin = Console.ReadLine();
                       errors = newPin.Length != 4 && int.TryParse(newPin,out _) == false;
                    }
                    _currentUser.BankAccount.ChangePin(newPin);
                    break;

                case "5":
                    Console.WriteLine("Have a grate day!");
                    Console.WriteLine("Press any key to Stop the ATM.");
                    Console.ReadKey();
                    return false;
                default:
                    Console.WriteLine("Please Pick a valid option.");
                    break;

            }

            Console.WriteLine("press any button to return to the menu.");
            Console.ReadKey();
            return true;
        }
    }

}