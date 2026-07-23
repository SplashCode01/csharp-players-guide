namespace FountainObjects;

class Program
{
    static void Main(string[] args)
    {
        GameLogic game = CreateSmallGame();
        game.Run();
    }

    public static GameLogic CreateSmallGame()
    {
        Map map = new Map(4, 4);
        Location start = new Location(0, 0);
        map.SetRoomType(start, RoomType.Entrance);
        map.SetRoomType(new Location(0, 2), RoomType.Fountain);

        return new GameLogic(map, new Player(start));
    }
}
