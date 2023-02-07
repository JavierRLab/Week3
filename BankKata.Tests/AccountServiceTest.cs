namespace BankKata.Tests;

public class AccountServiceTest
{
    [Fact]
    public void AddDeposit()
    {
        var readerAccountService = new ReaderAccountServiceSpy();
        var transactionService = new TransactionService();
        
        var accountService = new AccountService(transactionService, readerAccountService);
        accountService.Deposit(1000);
        accountService.Deposit(2000);
        accountService.Withdraw(500);
        //accountService.PrintStatement();

        var resultString = ((ReaderAccountServiceSpy)accountService.ReaderAccountService).PrintedStatesmentes;
        
        Assert.Equal("", resultString);



    }
}

public class ReaderAccountServiceSpy : IReaderAccountService
{
    public string PrintedStatesmentes;
    public string PrintStatement()
    {
        throw new NotImplementedException();
    }
}