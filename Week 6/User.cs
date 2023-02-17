namespace Week_6;

public class User
{
    public User()
    {
        var bankAcc = new BankAccount();
        bankAcc.accountNo = "1234567";
        bankAcc.sortCode = "12-45-78";
        bankAcc.overDraftLimit = 0;
        
        BankAccount = bankAcc;
        Name = "John Smith";
    }

    public BankAccount BankAccount { get; set; }
    public string Name { get; }
    
}
