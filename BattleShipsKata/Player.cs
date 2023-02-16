namespace BattleShipsKata;

public class Player
{
    private string _name;
    private char[,] _board;

    public Player(string playerName, int boardWidth, int boardHeight)
    {
        _name = playerName;
        _board = new char[boardWidth, boardHeight];

    }

    public void FillBoard(List<Ship> ships)
    {
        foreach (var ship in ships)
        {
            
        }
    }

    public string GetBoardMessage()
    {
        throw new NotImplementedException();
    }
}