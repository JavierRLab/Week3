namespace BankKata;

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