namespace BattleShipsKata;

public class Ship
{
    public int Longitude, Latitude;
    public string Orientation;
    public ShipType Type;

    public Ship(int longitude, int latitude, string orientation, ShipType type)
    {
        Longitude = longitude;
        Latitude = latitude;
        Orientation = orientation;
        Type = type;
    }
    public Ship(int longitude, int latitude, ShipType type)
    {
        Longitude = longitude;
        Latitude = latitude;
        Orientation = "Horizontal";
        Type = type;
    }
}

public class ShipType
{
    private char symbol;
    private int size;

    public ShipType(char symbol, int size)
    {
        this.symbol = symbol;
        this.size = size;
    }
}