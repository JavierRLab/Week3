namespace BattleShipsKata;

public class BattleShipsGame
{
    private readonly List<Player> _players = new();
    private Player _currentPlayer;
    public void Start(List<Ship> ships)
    {
        throw new NotImplementedException();
    }

    public void Add(string playerName)
    {
        _players.Add(new Player(playerName));
        _currentPlayer = _players.Last();
    }

    public void Print()
    {
        throw new NotImplementedException();
    }
}