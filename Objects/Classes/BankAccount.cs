namespace Classes;

public class BankAccount
{
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance
    { 
        get
        {
            decimal balance = 0;
            foreach (var item in _allTransactions)
            {
                balance += item.Amount;
            }

            return balance;
        }
    }
     
    static private int s_accountNumberSeed = 1234567890; //  static, which means it's shared by all of the BankAccount objects. The value of a non-static variable is unique to each instance of the BankAccount object

    private List<Transaction> _allTransactions = new List<Transaction>();
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount <= 0) // excepcion si la cantidad a retirar es menor a 0
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        }
        var deposit = new Transaction(amount, date, note); // constructor de la clase Transaction
        _allTransactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
        }
        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Not sufficient funds for this operation");
        }
        var withdrawal = new Transaction(-amount, date, note);
        _allTransactions.Add(withdrawal);
    }

    public string GetAccountHistory()
    {
        var report = new System.Text.StringBuilder(); //  StringBuilder class to format a string that contains one line for each transaction.

        decimal balance = 0;
        report.AppendLine("Date\t\tAmmount\tbalance\tNote"); // \t new character
        foreach (var item in _allTransactions)
        {
            balance += item.Amount;
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
        }
        return report.ToString();
    }
    public BankAccount(string name, decimal initBalance)
    {
        this.Owner = name; // this solo se requiere cuando una variable local o parametro tiene el mismo nombre
        MakeDeposit(initBalance, DateTime.Now, "Initial balance");
        Number = s_accountNumberSeed.ToString();
        s_accountNumberSeed++;
    }
}