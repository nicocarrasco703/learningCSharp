namespace Classes;

public class BankAccount
{
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { get; }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
    }

    public BankAccount(string name, decimal initBalance)
    {
        this.Owner = name; // this solo se requiere cuando una variable local o parametro tiene el mismo nombre
        this.Balance = initBalance;
    }
}