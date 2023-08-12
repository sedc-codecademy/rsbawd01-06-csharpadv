using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Account> accounts = new List<Account>
        {
            new SavingsAccount("12345", "1234", 1000),
            new CheckingAccount("67890", "5678", 500),
            new CheckingAccount("4000", "1234", 1500),
            new CheckingAccount("4000", "1234", 1500),
            new CheckingAccount("4000", "1234", 1500),
            new CheckingAccount("4000", "1234", 1500),
        };

        while (true)
        {
            Console.WriteLine("Welcome to the ATM");
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            Console.Write("Enter PIN: ");
            string pin = Console.ReadLine();

            Account currentAccount = accounts.FirstOrDefault(acc => acc.AccountNumber == accountNumber && acc.ValidatePin(pin));

            if (currentAccount != null)
            {
                Console.WriteLine($"Logged in as {currentAccount.AccountNumber}");

                while (true)
                {
                    Console.WriteLine("Select an option:");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter option: ");
                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.Write("Enter amount to deposit: ");
                            double depositAmount = double.Parse(Console.ReadLine());
                            currentAccount.Deposit(depositAmount);
                            break;
                        case 2:
                            Console.Write("Enter amount to withdraw: ");
                            double withdrawAmount = double.Parse(Console.ReadLine());
                            currentAccount.Withdraw(withdrawAmount);
                            break;
                        case 3:
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            Console.WriteLine("Invalid option. Please select a valid option.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid account number or PIN. Please try again.");
            }
        }
    }
}
