namespace BattleShipsKata;

public class Ship
{
    public int Longitude, Latitude;
    public string Orientation;
    public string Type;

    public Ship(int longitude, int latitude, string orientation, string type)
    {
        Longitude = longitude;
        Latitude = latitude;
        Orientation = orientation;
        Type = type;
    }
    public Ship(int longitude, int latitude, string type)
    {
        Longitude = longitude;
        Latitude = latitude;
        Orientation = "Horizontal";
        Type = type;
    }
}