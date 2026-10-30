using Banking.Console.Interface;
using Banking.Console.Models;

namespace Banking.Console.Services;

public class TransferService : ITransferService
{
  public Account Source;
  public Account Destination;

  public TransferService(Account source, Account destination)
  {
    Source = source;
    Destination = destination;
  }

  public void Debit(int amount)
  {
    if (amount > Source.Balance)
    {
      throw new ArgumentException("Saldo Anda Anda cukup.");
    }
    if (Source.AccountNumber == Destination.AccountNumber)
    {
      throw new ArgumentException("Tidak boleh transfer ke diri sendiri.");
    }
    System.Console.WriteLine($"Transfer : Rp{amount}");
    Source.DecreaseBalance(amount);
    Destination.IncreaseBalance(amount);
  }

  public void Credit(int amount)
  {
    Source.IncreaseBalance(amount);
  }
}