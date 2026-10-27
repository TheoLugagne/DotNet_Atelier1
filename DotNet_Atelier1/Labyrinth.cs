namespace DotNet_Atelier1;

public class Labyrinth
{
    private static readonly char[] WallChar = { '+', '-', '|' };
    private static readonly char DoorChar = '/';
    
    private readonly Tile[,] _tiles;
    private readonly int _width;
    private readonly int _height;
    
    public Labyrinth(string map)
    {
        var lines = map.Split("\r\n");
        _width = lines[0].Length;
        _height = lines.Length;
        _tiles = new Tile[_width, _height];
        
        for (var y = 0; y < _height; y++)
        {
            var line = lines[y];
            for (var x = 0; x < _width; x++)
            {
                _tiles[x, y] = GetTile(line[x]);
            }
        }
    }
    
    public void Display()
    {
        // Implementation for displaying the labyrinth
        for (var y = 0; y < _height; y++)
        {
            for (var x = 0; x < _width; x++)
            {
                Console.Write(_tiles[x, y].Display());
            }
            Console.WriteLine();
        }
    }

    private static Tile GetTile(char c)
    {
        return c switch
        {
            _ when c == WallChar[0] || c == WallChar[1] || c == WallChar[2] => new Wall(c),
            _ when c == DoorChar => new Door(c),
            _ => new Room(c),
        };
    }
}