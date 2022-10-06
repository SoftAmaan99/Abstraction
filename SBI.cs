using System;
namespace MyOopsConcept;
public class SBI : IBankAb
{
    public override void BankTransfer()
    {
        System.Console.WriteLine("SBI Bank Bank Transfer");
    }
    public override void CheckBalance()
    {
        System.Console.WriteLine("SBI Bank Check balance");
    }
    public override void MiniStatement()
    {
        System.Console.WriteLine("SBI Bank Mini statement");
    }
    public override void ValidateCard()
    {
        System.Console.WriteLine("SBI Bank Validate card");
    }
    public override void WithdrawMoney()
    {
        System.Console.WriteLine("SBI Bank Withdraw money");
    }
}