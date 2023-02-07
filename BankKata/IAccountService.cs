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
    public IReaderAccountService ReaderAccountService;

    private ListDictionary transactions = new ListDictionary();

    public AccountService(ITransactionService transactionService, IReaderAccountService readerAccountService)
    {
        TransactionService = transactionService;
        ReaderAccountService = readerAccountService;
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

public interface IReaderAccountService
{
    string PrintStatement();
}

public interface ITransactionService
{
    void Deposit(int amount);
    void Withdraw(int amount);
    
}