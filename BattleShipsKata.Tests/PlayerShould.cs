namespace BattleShipsKata.Tests;

public class PlayerShould
{
    [Fact(DisplayName = "initialize board with ships")]
    public void Test1()
    {
        var player = new Player("Player1", 10, 10);
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
        player.FillBoard(ships);
        
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
        
        
        Assert.Equal(expectedBoardForPlayer1, player.GetBoardMessage());
    }
}