namespace BattleShipsKata;

public class BattleShipsGame
{
    private readonly List<Player> _players = new();
    public void Start(List<Ship> ships)
    {
        throw new NotImplementedException();
    }

    public void Add(string playerName)
    {
        _players.Add(new Player(playerName));
    }

    public void Print()
    {
        throw new NotImplementedException();
    }
}