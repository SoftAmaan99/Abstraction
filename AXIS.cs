using System;
namespace MyOopsConcept;
public class AXIS : IBankAb
{
    public override void BankTransfer()
    {
        Console.WriteLine("AXIS Bank Bank Transfer");
    }
    public override void CheckBalance()
    {
        Console.WriteLine("AXIS Bank Check Balance");
    }
    public override void MiniStatement()
    {
        Console.WriteLine("AXIS Bank Mini Statement");
    }
    public override void ValidateCard()
    {
        Console.WriteLine("AXIS Bank Validate Card");
    }
    public override void WithdrawMoney()
    {
        Console.WriteLine("AXIS Bank Withdraw Money");
    }
}