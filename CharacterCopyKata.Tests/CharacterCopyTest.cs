using System.Security.Cryptography;

namespace CharacterCopyKata.Tests;

public class CharacterCopyTest
{
    [Fact]
    public void CopyEmptyLine()
    {
        var expectedString = "";
        ISource inputSource = new StringSourceMock("\n");
        IDestination expectedDestination = new DestinationSpy();
        var copier = new Copier(inputSource, expectedDestination);
        copier.Copy();
        var copiedString = ((DestinationSpy)expectedDestination).CopiedString;
        Assert.Equal(expectedString, copiedString);
    }
    
    [Fact]
    public void CopyString()
    {
        var expectedString = "asdf";
        ISource inputSource = new StringSourceMock(expectedString+"\n");
        IDestination expectedDestination = new DestinationSpy();
        var copier = new Copier(inputSource, expectedDestination);
        copier.Copy();
        var copiedString = ((DestinationSpy)expectedDestination).CopiedString;
        Assert.Equal(expectedString, copiedString);
    }
    
    
}

public class StringSourceMock : ISource
{
    public readonly char[] Container;
    private int _currentIndex;

    public StringSourceMock(string containerStr)
    {
        Container = containerStr.ToCharArray();
    }
    public char GetChar() => Container[_currentIndex++];
}
public class DestinationSpy : IDestination
{
    public string CopiedString = "";

    public void SetChar(char character)
    {
        CopiedString += character;
    }
}