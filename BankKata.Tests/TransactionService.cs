using System.Collections.Specialized;

namespace BankKata.Tests;

public class TransactionService : ITransactionService
{
    public readonly List<Transaction> Transactions = new List<Transaction>();
    public void Deposit(int amount)
    {
        Transactions.Add(new Transaction(new DateTime(), amount));
    }

    public void Withdraw(int amount)
    {
        Transactions.Add(new Transaction(new DateTime(), amount*(-1)));
    }
}

public class Transaction
{
    public DateTime TransactionDate;
    public int Amount { get; }

    public Transaction(DateTime transactionDate, int amount)
    {
        TransactionDate = transactionDate;
        Amount = amount;
    }
}