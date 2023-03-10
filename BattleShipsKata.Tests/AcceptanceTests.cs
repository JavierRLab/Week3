namespace BattleShipsKata.Tests;

public class AcceptanceTests
{
    [Fact]
    public void AddPlayer()
    {
        var writer = new StringWriter();
        Console.SetOut(writer);

        var battleShipsGame = new BattleShipsGame(10,10);
        battleShipsGame.Add("Player1");
        var carrier = new ShipType('c', 4);
        var destroyer = new ShipType('d', 3);
        var gunship = new ShipType('g', 1);
        List<Ship> ships = new List<Ship>() { 
            new Ship(8, 4, "Vertical", carrier),
            new Ship(2, 3, "Horizontal", destroyer),
            new Ship(5, 7, "Vertical", destroyer),
            new Ship(7, 2, gunship),
            new Ship(6, 4, gunship),
            new Ship(1, 7, gunship),
            new Ship(9, 9, gunship)
            
        };

        battleShipsGame.Start(ships);
        battleShipsGame.Print();
        
        var expectedBoardForPlayer1 =
            @"  | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |
               0|   |   |   |   |   |   |   |   |   |   |
               1|   |   |   |   |   |   |   |   |   |   |
               2|   |   |   |   |   |   |   | g |   |   |
               3|   |   | d | d | d |   |   |   |   |   |
               4|   |   |   |   |   |   | g |   | c |   |
               5|   |   |   |   |   |   |   |   | c |   |
               6|   |   |   |   |   |   |   |   | c |   |
               7|   | g |   |   |   | d |   |   | c |   |
               8|   |   |   |   |   | d |   |   |   |   |
               9|   |   |   |   |   | d |   |   |   | g |";
        
        
        Assert.Equal(expectedBoardForPlayer1, writer.ToString());
    }
}