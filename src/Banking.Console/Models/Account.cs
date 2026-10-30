namespace Banking.Console.Models;

abstract public class Account
{
  public string AccountNumber { get; set; }
  public string OwnerName { get; set; }
  public int Balance { get; protected set; }
  public string Status { get; set; }

  public Account(string accountNumber, string ownerName, int balance, string status)
  {
    AccountNumber = accountNumber;
    OwnerName = ownerName;
    Balance = balance;
    Status = status;
  }

  public virtual void IncreaseBalance(int amount)
  {
    Balance += amount;
  }

  public virtual void DecreaseBalance(int amount)
  {
    Balance -= amount;
  }

  public void ShowInfo()
  {
    System.Console.WriteLine($"{AccountNumber} - {OwnerName}");
    System.Console.WriteLine($"Balance : Rp{Balance}");
  }
}