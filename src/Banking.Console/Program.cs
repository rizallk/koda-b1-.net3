
using Banking.Console.Models;
using Banking.Console.Services;

List<Account> accounts = new List<Account>()
{
  new SavingAccount("ACC001", "Andi", 500000, "Active"),
  new CurrentAccount("ACC002", "Budi", 750000, "Active"),
  new SavingAccount("ACC003", "Dina", 250000, "Frozen"),
  new CurrentAccount("ACC004", "Satrio", 1000000, "Active"),
};

Console.WriteLine("===== Rekening Status Active =====");
var accountsActive = accounts.Where(acc => acc.Status == "Active");

foreach (var item in accountsActive)
{
  item.ShowInfo();
}

Console.WriteLine("\n===== Mengurutkan Dari Saldo Terbesar =====");
var accountsSorted = accountsActive.OrderByDescending(acc => acc.Balance);

foreach (var item in accountsSorted)
{
  item.ShowInfo();
}

Console.WriteLine("\n===== Tampilkan Nama Seluruh Owner =====");
var accountsOwnerName = accounts.Select(acc => acc.OwnerName);

foreach (var name in accountsOwnerName)
{
  Console.WriteLine(name);
}

Console.WriteLine("\n===== Hitung Keseluruhan Total Saldo =====");
var accountsTotalBalance = accounts.Sum(acc => acc.Balance);

Console.WriteLine($"Total Saldo : Rp.{accountsTotalBalance}");

Console.WriteLine("\n===== Pencarian dengan LINQ + Async/Await =====");
var queryService = new AccountQueryService(accounts);

Account? task1 = await queryService.FindAccountAsync("ACC005");

if (task1 != null)
{
  task1.ShowInfo();
}
else
{
  Console.WriteLine("Account not found");
}


