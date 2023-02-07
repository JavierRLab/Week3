namespace BankKata;

public class FormatStatementsService : IFormatTransactionService
{
    private const string Header = "Date || Amount || Balance \n";
    private readonly ITransactionService _transactionService;

    public FormatStatementsService(ITransactionService transactionService)
    {
        _transactionService = transactionService;
    }

    public string FormatTransaction()
    {
        var transactionsStr = "";
        var transactions = _transactionService.GetTransactions();
        int currentBalance = 0;
        foreach (var transaction in transactions)
        {
            var shortDateString = transaction.TransactionDate.ToShortDateString();
            currentBalance += transaction.Amount;
            transactionsStr += $"{shortDateString} || {transaction.Amount} || {currentBalance} \n";
        }
        return Header +
            transactionsStr;
    }
}