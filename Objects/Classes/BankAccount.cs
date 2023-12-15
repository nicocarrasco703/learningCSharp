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

    private readonly decimal _minBalance;
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
        // si el retiro de dinero es mayor a lo que tengo
        Transaction? overdraftTransaction = CheckWithdrawalLimit(Balance - amount < _minBalance);
        Transaction withdrawal = new(-amount, date, note);
        _allTransactions.Add(withdrawal);
        if (overdraftTransaction != null)
            _allTransactions.Add(overdraftTransaction);
    }

    // este metodo me indica si me pase del limite de lo que puedo retirar de la cuenta
    // ? significa que se puede retornar null. protected significa que este metodo solo puede ser llamado por clases derivadas
    protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)
    {
        if (isOverdrawn)
        {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }
        else
        {
            return default;
        }
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
    
    // metodo con keyword virtual para ser implementado por las demas clases que son heredadas segun su tipo de cuenta
    public virtual void PerformMonthEndTransactions() { }

    // como la clase LineOfCredit puede tener saldo negativo, separamos en dos constructores, el primero es un constructor que no usa el parametro minBalance (por defecto sera 0) y que con la expresion : this() llama al segundo constructor
    // el segundo constructor es el verdadero
    public BankAccount(string name, decimal initBalance) : this(name, initBalance, 0) {}
    public BankAccount(string name, decimal initBalance, decimal minBalance)
    {
        Number = s_accountNumberSeed.ToString();
        s_accountNumberSeed++;
        this.Owner = name; // this solo se requiere cuando una variable local o parametro tiene el mismo nombre
        
        _minBalance = minBalance;
        if (initBalance > 0)
            MakeDeposit(initBalance, DateTime.Now, "Initial balance");
    }
}