namespace BankKata.Tests;

public class AccountServiceTest
{
    [Fact]
    public void AddTransactions()
    {
        var repository = new RepositoryFake();
        var transactionService = new TransactionService(repository);
        var formatStatementsService = new FormatStatementsService(transactionService);
        
        var accountService = new AccountService(transactionService, formatStatementsService);
        transactionService.TransactionDate = new DateTime(2012, 1, 10);
        accountService.Deposit(1000);
        transactionService.TransactionDate = new DateTime(2012, 1, 13);
        accountService.Deposit(2000);
        transactionService.TransactionDate = new DateTime(2012, 1, 14);
        accountService.Withdraw(500);
        accountService.PrintStatement();

        var resultString = formatStatementsService.FormatTransaction();

        var expectedResultStr = "Date || Amount || Balance \n" +
                              "14/01/2012 || -500 || 2500 \n" +
                              "13/01/2012 || 2000 || 3000 \n" +
                              "10/01/2012 || 1000 || 1000 \n";
        Assert.Equal(expectedResultStr, resultString);



    }
}