using System.Collections.Specialized;

namespace BankKata.Tests;

public class TransactionService : ITransactionService
{
    public IRepository Repository;
    
    public TransactionService(IRepository repository)
    {
        this.Repository = repository;
    }

    public void Deposit(int amount)
    {
        Repository.Save(new Transaction(new DateTime(), amount));
    }

    public void Withdraw(int amount)
    {
        Repository.Save(new Transaction(new DateTime(), amount*(-1)));;
    }
}