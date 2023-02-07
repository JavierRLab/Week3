using BankKata;
using BankKata.Tests;

namespace CharacterCopyKata.Tests;

public class TransactionServiceTests
{
    [Fact]
    public void AddDepositTransaction()
    {
        var transactionService = new TransactionService();

        transactionService.Deposit(1000);
        Assert.Equal(1000, transactionService.Transactions[0].Amount);
    }
    
    [Fact]
    public void AddWithdrawTransaction()
    {
        var transactionService = new TransactionService();

        transactionService.Withdraw(500);
        Assert.Equal(-500, transactionService.Transactions[0].Amount);
    }
}