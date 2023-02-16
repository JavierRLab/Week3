namespace BattleShipsKata;

public class BattleShipsGame
{
    private readonly List<Player?> _players = new();
    private Player? _currentPlayer;
    private int _boardWidth;
    private int _boardHeight;

    public BattleShipsGame(int boardWidth, int boardHeight)
    {
        _boardWidth = boardWidth;
        _boardHeight = boardHeight;
    }

    public void Start(List<Ship> ships)
    {
        _currentPlayer?.FillBoard(ships);
    }

    public void Add(string playerName)
    {
        _players.Add(new Player(playerName, _boardWidth, _boardHeight));
        _currentPlayer = _players.Last();
    }

    public void Print()
    {
        throw new NotImplementedException();
    }
}