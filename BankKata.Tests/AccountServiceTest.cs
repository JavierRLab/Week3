namespace BankKata.Tests;

public class AccountServiceTest
{
    [Fact]
    public void AddTransactions()
    {
        var repository = new RepositoryFake();
        var formatStatementsService = new FormatStatementsService();
        var transactionService = new TransactionService(repository);
        
        var accountService = new AccountService(transactionService, formatStatementsService);
        accountService.Deposit(1000);
        accountService.Deposit(2000);
        accountService.Withdraw(500);
        accountService.PrintStatement();

        var resultString = formatStatementsService.FormatTransaction();

        var expectedResultStr = "Date || Amount || Balance \n" +
                              "14/01/2012 || -500 || 2500 \n" +
                              "13/01/2012 || 2000 || 3000 \n" +
                              "10/01/2012 || 1000 || 1000";
        Assert.Equal(expectedResultStr, resultString);



    }
}