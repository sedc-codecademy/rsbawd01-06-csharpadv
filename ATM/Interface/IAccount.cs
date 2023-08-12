interface IAccount
{
    void Deposit(double amount);
    void Withdraw(double amount);
    bool ValidatePin(string pin);
}
