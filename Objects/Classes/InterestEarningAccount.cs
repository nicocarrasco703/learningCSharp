namespace Classes;

public class InterestEarningAccount : BankAccount
{
    // constructor de la clase basado en el de la clase base
    public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
    {
    }

    public override void PerformMonthEndTransactions()
    {
        if (Balance > 500m)
        {
            decimal interest = Balance * 0.02m;
            MakeDeposit(interest, DateTime.Now, "Apply monthly interest");
        }
    }
}