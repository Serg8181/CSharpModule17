using Task17._6._6.Accounts;
using Task17._6._6.Calculator;

List<Account> accounts = new List<Account>()
{
    new OrdinaryAccount("ordinary", 5000.56),
    new OrdinaryAccount("ordinary", 45.76),
    new SalaryAccount("salary",8054.21)  
};

foreach (var account in accounts)
{
    Calculator.CalculateInterest(account);  
    Console.WriteLine($"Процентная ставка для аккаунта {account.Type} c балансом {account.GetBalance().ToString()} равна {account.Interest}");

}
Console.WriteLine();