namespace BankKata.Tests;

public class FormatTransactionServiceTests
{
    [Fact]
    public void GetEmptyTransactions()
    {
        var repository = new RepositoryFake();
        var transactionService = new TransactionService(repository);
        var formatStatementsService = new FormatStatementsService(transactionService);

        Assert.Equal("Date || Amount || Balance \n", formatStatementsService.FormatTransaction());
    }
    [Fact]
    public void GetSingleTransactions()
    {
        var repository = new RepositoryFake();
        var transactionService = new TransactionService(repository);
        var formatStatementsService = new FormatStatementsService(transactionService);
        transactionService.TransactionDate = new DateTime(2012, 1, 10);
        transactionService.Deposit(1000);

        var expectedString = "Date || Amount || Balance \n" +
                             "10/01/2012 || 1000 || 1000 \n";
        var formatTransaction = formatStatementsService.FormatTransaction();
        Assert.Equal(expectedString, formatTransaction);
    }
}