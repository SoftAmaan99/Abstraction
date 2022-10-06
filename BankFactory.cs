namespace MyOopsConcept;
public class BankFactory
{
    public static IBankAb GetBankObject(string BankType)
    {
        IBankAb BankObject = null;
        if (BankType == "SBI")
        {
            BankObject = new SBI();
        }
        else if (BankType == "AXIS")
        {
            BankObject = new AXIS();
        }
        return BankObject;
    }
}