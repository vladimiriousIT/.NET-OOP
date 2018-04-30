using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var acounts = new Dictionary<int, BankAccount>();
        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            var splitCommand = command.Split();
            var accountId = int.Parse(splitCommand[1]);
            switch (splitCommand[0])
            {
                case "Create":
                    if (acounts.ContainsKey(accountId))
                    {
                        Console.WriteLine("Account already exists");
                    }
                    else
                    {
                        var accountNew = new BankAccount();
                        accountNew.ID = accountId;
                        acounts.Add(accountId, accountNew);
                       
                    }
                    break;
                case "Deposit":
                    if (VlidateAccountExists(accountId, acounts))
                    {
                        acounts[accountId].Deposit(int.Parse(splitCommand[2]));
                    }
                    break;
                case "WithDraw":
                    if (VlidateAccountExists(accountId,acounts))
                    {
                        acounts[accountId].WithDraw(int.Parse(splitCommand[3]));
                    }
                 break;
                case "Print":
                    if(VlidateAccountExists(accountId, acounts))
                    {
                        Console.WriteLine(acounts[accountId]);
                    }
                    break;
                default:
                    break;
            }
        }
    }

    static bool VlidateAccountExists(int accountID, Dictionary<int, BankAccount> accounts)
    {
        if (accounts.ContainsKey(accountID))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Account does not exist");
            return false;
        }
    }
}

