namespace CharacterCopyKata;

public class Copier
{
    private readonly ISource _inputSource;
    private readonly IDestination _copiedDestination;

    public Copier(ISource inputSource, IDestination copiedDestination)
    {
        _inputSource = inputSource;
        _copiedDestination = copiedDestination;
    }

    public void Copy()
    {
        char character = _inputSource.GetChar();
        while (!'\n'.Equals(character))
        {
            _copiedDestination.SetChar(character);
            character = _inputSource.GetChar();
        } 
    }
}

public interface ISource
{
    char GetChar();
}

public interface IDestination
{
    void SetChar(char character);
}