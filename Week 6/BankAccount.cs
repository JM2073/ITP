namespace Week_6;

public class BankAccount
{
    public BankAccount()
    {
        Pin = "1234";
    }

    private double balance;
    
    private string Pin { get; set; }
    
    public double overDraftLimit { get; set; }
    
    public string accountNo { get; set; }
    
    public string sortCode { get; set; }

    public double ViewBalance()
    {
        return balance;
    }
    
    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        balance -= amount;
    }

    public bool CheckPin(string enteredPin)
    {
        return string.CompareOrdinal(Pin, enteredPin) == 0;
    }

    public void ChangePin(string newPin)
    {
        Pin = newPin;
    }
}