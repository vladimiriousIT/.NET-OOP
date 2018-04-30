using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var bankAccount = new BankAccount();
        bankAccount.ID = 1;
        bankAccount.Deposit(15);
        bankAccount.WithDraw(10);

        Console.WriteLine(bankAccount);
    }
}
