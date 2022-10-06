using System;
namespace MyOopsConcept;
class Program
{
    public static void Main(string[] args)
    {
        #region SBI Bank @Start here
        Console.WriteLine($"Transaction doing by SBI Bank");
        IBankAb sbi = BankFactory.GetBankObject("SBI");
        sbi.ValidateCard();
        sbi.WithdrawMoney();
        sbi.CheckBalance();
        sbi.BankTransfer();
        sbi.MiniStatement();
        #endregion SBI Bank @End here

        #region AXIS Bank @Start here
        Console.WriteLine($"Transaction doing by AXIS Bank");
        IBankAb axis = BankFactory.GetBankObject("AXIS");
        axis.ValidateCard();
        axis.WithdrawMoney();
        axis.CheckBalance();
        axis.BankTransfer();
        axis.MiniStatement();
        #endregion AXIS Bank @End here
    }
}