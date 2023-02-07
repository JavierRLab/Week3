using BankKata;
using BankKata.Tests;

namespace BankKata.Tests;

public class TransactionServiceTests
{
    [Fact]
    public void AddDepositTransaction()
    {
        var repository = new RepositoryFake();
        var transactionService = new TransactionService(repository);

        transactionService.Deposit(1000);
        Assert.Equal(1000, repository.GetTransactions()[0].Amount);
    }
    
    [Fact]
    public void AddWithdrawTransaction()
    {
        var repository = new RepositoryFake();
        var transactionService = new TransactionService(repository);

        transactionService.Withdraw(500);
        Assert.Equal(-500, repository.GetTransactions()[0].Amount);
    }
}

public class RepositoryFake : IRepository
{
    private List<Transaction> _transactions = new();
    
    public void Save(Transaction transaction)
    {
        _transactions.Add(transaction);
    }

    public List<Transaction> GetTransactions()
    {
        return _transactions;
    }
}