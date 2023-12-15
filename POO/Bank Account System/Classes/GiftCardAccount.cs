namespace Classes;

public class GiftCardAccount : BankAccount
{
    private readonly decimal _monthlyDeposit = 0m;

    // el token => se usa aca como separador de un miembro y su implementacion
    // lo usamos aca porque el constructor de la clase base no tiene un miembro monthlyDeposit
    // se pone con valor por defecto 0 si no se llama al constructor con ese parametro
    public GiftCardAccount(string name, decimal initBalance, decimal monthlyDeposit = 0) : base(name, initBalance) =>
        _monthlyDeposit = monthlyDeposit;

    public override void PerformMonthEndTransactions()
    {
        if (_monthlyDeposit != 0)
        {
            MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
        }
    }
}