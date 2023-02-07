using System.Collections.Specialized;
using static System.DateTime;

namespace BankKata;

public interface IAccountService
{
    void Deposit(int amount);
    void Withdraw(int amount);
    void PrintStatement();
}




public class AccountService : IAccountService
{
    public ITransactionService TransactionService;
    public IFormatTransactionService FormatTransactionService;

    private ListDictionary transactions = new ListDictionary();

    public AccountService(ITransactionService transactionService, IFormatTransactionService formatTransactionService)
    {
        TransactionService = transactionService;
        FormatTransactionService = formatTransactionService;
    }

    public void Deposit(int amount)
    {
        TransactionService.Deposit(amount);
    }

    public void Withdraw(int amount)
    {
        TransactionService.Withdraw(amount);
    }

    public void PrintStatement()
    {
        throw new NotImplementedException();
    }
}

public interface IFormatTransactionService
{
    string FormatTransaction();
}

public interface ITransactionService
{
    void Deposit(int amount);
    void Withdraw(int amount);
    
}