class SavingsAccount : Account
{
    public SavingsAccount(string accountNumber, string pin, double initialBalance)
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
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }
}
