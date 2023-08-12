abstract class Account : IAccount
{
    public string AccountNumber { get; protected set; }
    public string Pin { get; protected set; }
    public double Balance { get; protected set; }

    public Account(string accountNumber, string pin, double initialBalance)
    {
        AccountNumber = accountNumber;
        Pin = pin;
        Balance = initialBalance;
    }

    public abstract void Deposit(double amount);
    public abstract void Withdraw(double amount);

    public bool ValidatePin(string pin)
    {
        return Pin == pin;
    }
}
