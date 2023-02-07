namespace BankKata;

public class TransactionService : ITransactionService
{
    private readonly IRepository _repository;
    public DateTime TransactionDate { get; set; }

    public TransactionService(IRepository repository)
    {
        this._repository = repository;
        TransactionDate = DateTime.Now;
    }

    public void Deposit(int amount)
    {
        _repository.Save(new Transaction(TransactionDate, amount));
    }


    public void Withdraw(int amount)
    {
        _repository.Save(new Transaction(TransactionDate, -amount));;
    }

    public List<Transaction> GetTransactions()
    {
        return _repository.GetTransactions();
    }
}