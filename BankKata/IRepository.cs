using BankKata.Tests;

namespace BankKata;

public interface IRepository
{
    public void Save(Transaction transaction);
    public List<Transaction> GetTransactions();

}




