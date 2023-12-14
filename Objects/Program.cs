using Classes;
using System.Text;

var account = new BankAccount("Nico", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

account.MakeDeposit(150, DateTime.Now, "Pay check");
Console.WriteLine(account.Balance);
account.MakeWithdrawal(1120, DateTime.Now, "Rent :(");
Console.WriteLine(account.Balance);

Console.WriteLine(account.GetAccountHistory());

// prueba de excepciones con saldo invalido
//BankAccount invalidAccount;
//try
//{
//    invalidAccount = new BankAccount("invalid", -55);
//}
//catch (ArgumentOutOfRangeException e)
//{
//    Console.WriteLine("Exception caught creating account with negative balance.");
//    Console.WriteLine(e.ToString());
//    return;
//}

//try
//{
//    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
//}
//catch (InvalidOperationException e)
//{
//    Console.WriteLine("Exception caught trying to overdraw");
//    Console.WriteLine(e.ToString()); 
//    return;
//}
