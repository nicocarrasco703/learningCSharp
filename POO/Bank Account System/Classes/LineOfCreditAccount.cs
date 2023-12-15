namespace Classes;

public class LineOfCreditAccount : BankAccount
{
    public LineOfCreditAccount(string name, decimal initBalance, decimal creditLimit) : base(name, initBalance, -creditLimit)
    {
    }

    protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) =>
        isOverdrawn // operador ternario
            ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
            : default;
    public override void PerformMonthEndTransactions()
    {
        // negar balance para obtener un cargo de interes positivo
        decimal interest = -Balance * 0.07m;
        MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
    }
}