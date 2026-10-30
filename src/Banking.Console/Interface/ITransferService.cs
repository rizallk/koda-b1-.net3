namespace Banking.Console.Interface;

public interface ITransferService
{
  void Debit(int amount);
  void Credit(int amount);
}