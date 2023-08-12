class CheckingAccount : Account
{
    public CheckingAccount(string accountNumber, string pin, double initialBalance)
        : base(accountNumber, pin, initialBalance)
    {
    }

    public override void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
    }

    public override void Withdraw(double amount)
    {
        const double overdraftLimit = -100;
        if (Balance - amount >= overdraftLimit)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Withdrawal exceeds overdraft limit.");
        }
    }
}
