using System;
using System.Collections.Generic;
using System.Text;

public class BankAccount
{
    int id;
    decimal balance;

    public int ID
    {
        get { return id; }
        set { id = value; }
    }

    public decimal Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public void Deposit(decimal amount)
    {
        this.Balance = Balance + amount;
    }
    //- -> private
    //+ -> public
    public void WithDraw(decimal amount)
    {
        Balance -= amount;
    }
    public override string ToString()
    {
        return $"Account {this.id}, balance {this.balance} ";
    }
}


