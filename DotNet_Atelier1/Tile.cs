namespace DotNet_Atelier1;

public abstract class Tile
{
    public abstract bool IsTraversable { get; }
    public abstract bool Pass();
    public abstract char Display();
    
    protected Tile(char c) { }
    protected Tile() { }
}