namespace Banking.Console.Models;

public class SavingAccount(string accountNumber, string ownerName, int balance, string status) : Account(accountNumber, ownerName, balance, status)
{
  private readonly string Type = "Saving";


  public string GetTypeName()
  {
    return Type;
  }

  public override void IncreaseBalance(int amount)
  {
    base.IncreaseBalance(amount);
  }

  public override void DecreaseBalance(int amount)
  {
    base.DecreaseBalance(amount);
  }
}
